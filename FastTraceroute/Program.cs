using System;
using System.Windows.Forms;

namespace FastTraceroute
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new TracerouteForm());
        }

    }
}
