﻿using System;
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
            label2.Text = mp.X + ","+ mp.Y;
            label2.Left = mp.X;
            label2.Top = mp.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("捕まっちゃった(泣)");
            vx = 0;
            vy = 0;
        }
    }
}
