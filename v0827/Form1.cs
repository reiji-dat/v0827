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
        static Random rand = new Random();

        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int vx4 = rand.Next(-10,11);
        int vy4 = rand.Next(-10,11);
        int vx5 = rand.Next(-10,11);
        int vy5 = rand.Next(-10,11);
        int score = 0;
        bool pien = false;

        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label4.Left = rand.Next(ClientSize.Width - label1.Width);
            label4.Top = rand.Next(ClientSize.Height - label1.Height);
            label5.Left = rand.Next(ClientSize.Width - label1.Width);
            label5.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            label4.Left += vx4;
            label4.Left += vx4;
            label5.Top += vy5;
            label5.Top += vy5;
            
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



            if (label4.Left < 0)
            {
                vx4 = (int)Math.Abs(vx);
            }
            if (label4.Top < 0)
            {
                vy4 = (int)Math.Abs(vy);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx4 = -(int)Math.Abs(vx);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy4 = -(int)Math.Abs(vy);
            }



            if (label5.Left < 0)
            {
                vx5 = (int)Math.Abs(vx);
            }
            if (label5.Top < 0)
            {
                vy5 = (int)Math.Abs(vy);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx5 = -(int)Math.Abs(vx);
            }
            if (label5.Bottom > ClientSize.Height)
            {
                vy5 = -(int)Math.Abs(vy);
            }
              
            if (    label1.Left   <=  mp.X 
                &&  label1.Right  >   mp.X
                &&  label1.Top    <=  mp.Y 
                &&  label1.Bottom >   mp.Y )
            {
                if (!pien)
                {
                    score++;
                    label1.Text = "( ﾉД`)ｼｸｼｸ…";
                    pien = true;
                    timer1.Enabled = false;
                    label3.Text = "score " + score;
                    MessageBox.Show("つかまっちゃった(泣)" + score + "回目だよ(泣)");
                    label1.Text = "(´・ω・`)";
                    pien = false;
                }
            }
            label2.Text = mp.X + ","+ mp.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = rand.Next(-10, 11);
            vy = rand.Next(-10, 11);
            label1.Left = rand.Next(ClientSize.Width - label1.Size.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Size.Height);
            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
