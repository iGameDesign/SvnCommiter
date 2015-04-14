using System;
using System.Collections.Generic;				 				 	
using System.Windows.Forms;		 	 				 	
using System.Diagnostics;

namespace SvnCommiter
{
    static class Program			 			 	 	
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]									 	
        static void Main(params string[] args)		 	 				 	
        {
            //if (args.Length == 0)
            //{
            //    Process.Start("UpdateProgram.exe");
            //    return;			  		 	 	
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SvnCommiterUI());									 	
        }									 	
    }
}