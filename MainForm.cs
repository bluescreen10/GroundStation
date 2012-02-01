using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GroundStation
{
	public partial class MainForm : Form
	{
		public class ConfigStruct
		{
			public uint GyroOrientation;
			public uint FrameConfiguration;

			public uint PitchRollControlScale;
			public uint YawControlScale;

			public uint PitchRoll_PGain;
			public uint PitchRoll_IGain;
			public uint PitchRoll_DGain;
			public uint PitchRoll_D2Gain;

			public uint Yaw_PGain;
			public uint Yaw_IGain;
			public uint Yaw_DGain;
			public uint Yaw_D2Gain;

			public uint ThrottleStartupTime;

			public uint DummyPad0;
			public uint DummyPad1;
			public uint DummyPad2;
		}
		
		string portName = null;
		SerialPort comm = null;
		bool Active = false;
		bool ConfigActive = false;
		bool GraphActive = true;
		bool internalChange = false;

		ConfigStruct configStruct = new ConfigStruct();


		public MainForm(string name)
		{
			portName = name;
			InitializeComponent();
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			if ( portName == null) {
			
				string[] names = SerialPort.GetPortNames();

				List<string> Ports = new List<string>();
				foreach(string name in names)
				{
					if(name != "COM1" && name != "COM2" && name != "COM3" && name != "COM4")
						Ports.Add( name );
				}
				
				if ( Ports.Count > 0 )
					portName = Ports[0];
			}
			
			// Open the serial port COM8 at 115200 baud, no parity, 8 bits, one stop bit
			comm = new SerialPort( portName, 115200, Parity.None, 8, StopBits.One );
			comm.Open();
			Active = true;
			tickTimer.Enabled = true;
			statsTimer.Enabled = true;
		}


		private void SetActive( bool NewActive )
		{
			if(Active == NewActive) return;
			if(NewActive == false) {
				comm.Close();
			}
			else {
				comm.Open();
			}

			Active = NewActive;
		}

		int GetCommWord()
		{
			int val = (short)(comm.ReadByte() << 8);
			val |= comm.ReadByte();
			return val;
		}


		void Application_Idle( object sender, EventArgs e )
		{
			if (Active == false) return;

			while(comm.BytesToRead >= 2)
			{
				int PacketType = 0;
				while(comm.BytesToRead >= 2 && PacketType == 0)
				{
					int b1 = comm.ReadByte();
					int b2 = 0;
					if(b1 == 0x7F) {
						b2 = comm.ReadByte();
					}

					if(b1 == 0x7F)
					{
						if(b2 == 0x7F)		PacketType = 1;
						else if(b2 == 0x7E)	PacketType = 2;
						else if(b2 == 0x70)	PacketType = 3;
						else if(b2 == 0x71)	PacketType = 4;
						else if(b2 == 0x72) PacketType = 5;
						else if(b2 == 0x79) PacketType = 100;
					}
				}

				if(PacketType == 0) continue;


				if(PacketType == 1)		// This is a gyro data packet
				{
					int[] sample = new int[3];
					sample[0] = GetCommWord();
					sample[1] = GetCommWord();
					sample[2] = GetCommWord();

					graph.AddSample( sample, GraphActive && comm.BytesToRead < 10 );
				}
				else if(PacketType == 2)	// This is a config packet
				{
					ReadConfigData();
				}
				else if( PacketType == 3 )
				{
					lblStatus.Text = "Config data transmitted...";
				}
				else if( PacketType == 4 )
				{
					lblStatus.Text = "Eeprom write issued...";
				}
				else if(PacketType == 5)
				{
					lblStatus.Text = "Eeprom write succeeded - rebooting";
				}
				else if(PacketType == 100)
				{
					lblStatus.Text = "Error - please retry.";
				}
			}
		}

		private void statsTimer_Tick( object sender, EventArgs e )
		{
			graph.UpdateStats();
			lblGXMin.Text = graph.Mins[0].ToString();
			lblGXMax.Text = graph.Maxs[0].ToString();
			lblGXAvg.Text = graph.Avgs[0].ToString( "00.0000" );
			lblGXVar.Text = graph.Vars[0].ToString( "0.00000" );

			lblGYMin.Text = graph.Mins[1].ToString();
			lblGYMax.Text = graph.Maxs[1].ToString();
			lblGYAvg.Text = graph.Avgs[1].ToString( "00.0000" );
			lblGYVar.Text = graph.Vars[1].ToString( "0.00000" );

			lblGZMin.Text = graph.Mins[2].ToString();
			lblGZMax.Text = graph.Maxs[2].ToString();
			lblGZAvg.Text = graph.Avgs[2].ToString( "00.0000" );
			lblGZVar.Text = graph.Vars[2].ToString( "0.00000" );
		}



		private void MainForm_Activated( object sender, EventArgs e )
		{
			//SetActive(true);
		}

		private void MainForm_Deactivate( object sender, EventArgs e )
		{
			//SetActive(false);
		}

		private void tabControl1_SelectedIndexChanged( object sender, EventArgs e )
		{
			GraphActive = (tabControl1.SelectedIndex == 0);
			ConfigActive = (tabControl1.SelectedIndex == 1);

			if(ConfigActive) {
				GetCurrentConfig();
			}
		}


		private void tbRollPitchSens_Scroll( object sender, EventArgs e )
		{
			string s = tbRollPitchSens.Value.ToString() + " ";

			if(tbRollPitchSens.Value < 2)
				s = s + "(trainer)";
			else if(tbRollPitchSens.Value < 4)
				s = s + "(low)";
			else if(tbRollPitchSens.Value < 8)
				s = s + "(med)";
			else if( tbRollPitchSens.Value < 16)
				s = s + "(high)";
			else
				s = s + "(crazy)";

			lblRollPitchSens.Text = s;

			if( tbRollPitchSens.Value == 32 )
				configStruct.PitchRollControlScale = 0xffffffff;
			else
				configStruct.PitchRollControlScale = (uint)tbRollPitchSens.Value << 27;
		}

		private void tbYawSens_Scroll( object sender, EventArgs e )
		{
			string s = tbYawSens.Value.ToString() + " ";

			if(tbYawSens.Value < 2)
				s = s + "(trainer)";
			else if(tbYawSens.Value < 4)
				s = s + "(low)";
			else if(tbYawSens.Value < 8)
				s = s + "(med)";
			else if(tbYawSens.Value < 16)
				s = s + "(high)";
			else
				s = s + "(crazy)";

			lblYawSens.Text = s;

			if(tbYawSens.Value == 32)
				configStruct.YawControlScale = 0xffffffff;
			else
				configStruct.YawControlScale = (uint)tbYawSens.Value << 27;
		}

		private void tbThrottleMaxHoldTime_ValueChanged( object sender, EventArgs e )
		{
			int v = (int)tbThrottleMaxHoldTime.Value;
			string s;
			if(v == 1)
			{
				s = "Off";
				configStruct.ThrottleStartupTime = 0;
			}
			else
			{
				s = (v * 100).ToString() + " mS";
				configStruct.ThrottleStartupTime = (uint)v;
			}

			lblThrottleMaxTime.Text = s;
		}

		private void rbFramePlus_CheckedChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			if(rbFramePlus.Checked)
				configStruct.FrameConfiguration = 0;
			else
				configStruct.FrameConfiguration = 1;
		}

		private void rbGyro_CheckedChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			if(rbGyroNorm.Checked)
				configStruct.GyroOrientation = 0;
			else if(rbGyroCCW.Checked)
				configStruct.GyroOrientation = 1;
			else
				configStruct.GyroOrientation = 2;
		}


		private void udRollPitchKP_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.PitchRoll_PGain = (uint)udRollPitchKP.Value << 8;
		}

		private void udRollPitchKI_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.PitchRoll_IGain = (uint)udRollPitchKI.Value << 16;
		}

		private void udRollPitchKD_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.PitchRoll_DGain = (uint)udRollPitchKD.Value << 16;
		}

		private void udRollPitchKD2_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.PitchRoll_D2Gain = (uint)udRollPitchKD2.Value << 16;
		}

		private void udYawKP_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.Yaw_PGain = (uint)udYawKP.Value << 8;
		}

		private void udYawKI_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.Yaw_IGain = (uint)udYawKI.Value << 16;
		}

		private void udYawKD_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.Yaw_DGain = (uint)udYawKD.Value << 16;
		}

		private void udYawKD2_ValueChanged( object sender, EventArgs e )
		{
			if(internalChange == true) return;
			configStruct.Yaw_D2Gain = (uint)udYawKD2.Value << 16;
		}

		private void btnGetConfig_Click( object sender, EventArgs e )
		{
			GetCurrentConfig();
		}

		public void GetCurrentConfig()
		{
			lblStatus.Text = "Requesting config data...";

			// Send the "GetConfig" trigger - the results will come back on their own
			byte[] tx = new byte[2];
			tx[0] = 0xAA;
			tx[1] = 0xA5;
			comm.Write( tx, 0, 2 );
		}

		public void ReadConfigData()
		{
			// ONLY call this function from the Comm handler after getting the 0x7878 header
			byte[] rx = new byte[1];
			int total = 0;
			comm.Read( rx, 0, 1 );

			total = rx[0] * 4;
			rx = new byte[total];
			int result = 0;
			while(result < 64)
			{
				int thisRead = comm.Read( rx, result, total - result );
				result += thisRead;

				if(thisRead == 0) {	// Abort if something went wrong
					result = 64;
					total = 0;
				}
			}

			if(total != 64) return;

			configStruct.GyroOrientation = GetUInt( rx, 0 );
			configStruct.FrameConfiguration = GetUInt( rx, 1 );

			configStruct.PitchRollControlScale = GetUInt( rx, 2 );
			configStruct.YawControlScale = GetUInt( rx, 3 );

			configStruct.PitchRoll_PGain = GetUInt( rx, 4 );
			configStruct.PitchRoll_IGain = GetUInt( rx, 5 );
			configStruct.PitchRoll_DGain = GetUInt( rx, 6 );
			configStruct.PitchRoll_D2Gain = GetUInt( rx, 7 );

			configStruct.Yaw_PGain = GetUInt( rx, 8 );
			configStruct.Yaw_IGain = GetUInt( rx, 9 );
			configStruct.Yaw_DGain = GetUInt( rx, 10 );
			configStruct.Yaw_D2Gain = GetUInt( rx, 11 );

			configStruct.ThrottleStartupTime = GetUInt( rx, 12 );

			configStruct.DummyPad0 = GetUInt( rx, 13 );
			configStruct.DummyPad1 = GetUInt( rx, 14 );
			configStruct.DummyPad2 = GetUInt( rx, 15 );


			// Update all the controls

			internalChange = true;

			rbFramePlus.Checked = (configStruct.FrameConfiguration == 0);
			rbFrameX.Checked = (configStruct.FrameConfiguration == 1);

			rbGyroNorm.Checked = (configStruct.GyroOrientation == 0);
			rbGyroCCW.Checked = (configStruct.GyroOrientation == 1);
			rbGyroCW.Checked = (configStruct.GyroOrientation == 2);

			if(configStruct.PitchRollControlScale == 0xffffffff)
				tbRollPitchSens.Value = 32;
			else
				tbRollPitchSens.Value = (int)(configStruct.PitchRollControlScale >> 27);

			if(configStruct.YawControlScale == 0xffffffff)
				tbYawSens.Value = 32;
			else
				tbYawSens.Value = (int)(configStruct.PitchRollControlScale >> 27);

			if(configStruct.ThrottleStartupTime == 0)
				tbThrottleMaxHoldTime.Value = 1;
			else
				tbThrottleMaxHoldTime.Value = (int)configStruct.ThrottleStartupTime;

			udRollPitchKP.Value = configStruct.PitchRoll_PGain >> 8;
			udRollPitchKI.Value = configStruct.PitchRoll_IGain >> 16;
			udRollPitchKD.Value = configStruct.PitchRoll_DGain >> 16;
			udRollPitchKD2.Value = configStruct.PitchRoll_D2Gain >> 16;

			udYawKP.Value = configStruct.Yaw_PGain >> 8;
			udYawKI.Value = configStruct.Yaw_IGain >> 16;
			udYawKD.Value = configStruct.Yaw_DGain >> 16;
			udYawKD2.Value = configStruct.Yaw_D2Gain >> 16;

			internalChange = false;

			lblStatus.Text = "Config data received.";
		}


		byte[] SerializeConfigData()
		{
			byte[] tx = new byte[64];

			WriteUInt( configStruct.GyroOrientation, tx, 0 );
			WriteUInt( configStruct.FrameConfiguration, tx, 1 );

			WriteUInt( configStruct.PitchRollControlScale, tx, 2 );
			WriteUInt( configStruct.YawControlScale, tx, 3 );

			WriteUInt( configStruct.PitchRoll_PGain, tx, 4 );
			WriteUInt( configStruct.PitchRoll_IGain, tx, 5 );
			WriteUInt( configStruct.PitchRoll_DGain, tx, 6 );
			WriteUInt( configStruct.PitchRoll_D2Gain, tx, 7 );

			WriteUInt( configStruct.Yaw_PGain, tx, 8 );
			WriteUInt( configStruct.Yaw_IGain, tx, 9 );
			WriteUInt( configStruct.Yaw_DGain, tx, 10 );
			WriteUInt( configStruct.Yaw_D2Gain, tx, 11 );

			WriteUInt( configStruct.ThrottleStartupTime, tx, 12 );

			WriteUInt( configStruct.DummyPad0, tx, 13 );
			WriteUInt( configStruct.DummyPad1, tx, 14 );
			WriteUInt( configStruct.DummyPad2, tx, 15 );

			return tx;
		}

		uint GetUInt( byte[] rx, int offset )
		{
			offset <<= 2;
			uint result = (uint)rx[offset] |
				((uint)rx[offset + 1] << 8) |
				((uint)rx[offset + 2] << 16) |
				((uint)rx[offset + 3] << 24);
			return result;
		}

		void WriteUInt( uint value, byte[] tx, int offset )
		{
			offset <<= 2;
			tx[offset] = (byte)(value);
			tx[offset + 1] = (byte)(value >> 8);
			tx[offset + 2] = (byte)(value >> 16);
			tx[offset + 3] = (byte)(value >> 24);
		}


		private void btnSetConfig_Click( object sender, EventArgs e )
		{
			// Send the "SetConfig" trigger
			byte[] txCommand = { 0xAA, 0x5A };
			byte[] txData = SerializeConfigData();

			comm.Write( txCommand, 0, 2 );

			Thread.Sleep( 5 );
	
			comm.Write( txData, 0, 64 );

			while(comm.BytesToWrite > 0) {
				Thread.Sleep( 5 );
			}

			// Wait for the Ack or timeout

			// Show success / failure
		}
	}
}
