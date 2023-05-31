using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Economy_Client_App
{
    internal static class Program
    {
        public static F1 MainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new F1();
            Application.Run(MainForm);
        }

    }
}
