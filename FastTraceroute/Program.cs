using System;
using System.Windows.Forms;

namespace FastTraceroute
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new TracerouteForm());
        }

    }
}
