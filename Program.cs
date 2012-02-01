using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroundStation
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			
			string portName = null;
			
			if ( args.Length > 0 )
				portName = args[0];
			 
			Application.Run( new MainForm(portName) );
						
		}
	}
}
