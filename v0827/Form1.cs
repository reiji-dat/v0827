using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        bool pien = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            Point mp = MousePosition;
            mp = PointToClient(mp);
            if(label1.Left < 0)
            {
                vx = (int)Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = (int)Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -(int)Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -(int)Math.Abs(vy);
            }
            label2.Text = mp.X + ","+ mp.Y;
            label2.Left = mp.X;
            label2.Top = mp.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
            if (!pien)
            {
                label1.Text = "( ﾉД`)ｼｸｼｸ…";
                MessageBox.Show("捕まっちゃった(泣)");
                pien = true;
            }
        }
    }
}
