using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace FastTraceroute
{
    class NumberComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            ListViewItem lvx = (ListViewItem)a;
            ListViewItem lvy = (ListViewItem)b;
            int x = int.Parse(lvx.Text.ToString());
            int y = int.Parse(lvy.Text.ToString());
            return x > y ? 1 : x < y ? -1 : 0;
        }
    }
}
