using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeakageTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            try
            {
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Init");
                //key.SetValue()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.Run(new frmMain());

        }
    }
}