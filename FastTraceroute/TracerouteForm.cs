using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace FastTraceroute
{
    public partial class TracerouteForm : Form
    {
        public TracerouteForm()
        {
            InitializeComponent();
            listView1.ListViewItemSorter = new NumberComparer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string host = textBox1.Text;
            for (int i = 1; i <= 30; i++)
            {
                Ping p = new Ping();
                p.PingCompleted += P_PingCompleted;
                p.SendAsync(host, 1000, Encoding.ASCII.GetBytes("hello world"), new PingOptions(i, true), i);
            }
        }

        private void P_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            int pos = (int)e.UserState;
            PingReply r = e.Reply;
            if (r.Status == IPStatus.TimedOut)
            {
                // TODO
            }
            var item = new ListViewItem(new[] { pos.ToString(), r.Address.ToString(), r.RoundtripTime.ToString(), r.Status.ToString() });
            listView1.Items.Add(item);
            listView1.Sort();
        }
    }
}
