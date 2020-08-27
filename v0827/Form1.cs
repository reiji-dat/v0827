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
        int score = 0;
        int cool = 0;   //クールタイム
        bool pien = false;

        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cool--;

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
              
            if (    label1.Left   <=  mp.X 
                &&  label1.Right  >   mp.X
                &&  label1.Top    <=  mp.Y 
                &&  label1.Bottom >   mp.Y )
            {
                if (cool < 0)   //クールタイム解除後に捕まえられる
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
            }
            label2.Text = mp.X + ","+ mp.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cool = 10;  //クールタイム10tick
            vx = rand.Next(-10, 11);
            vy = rand.Next(-10, 11);
            label1.Left = rand.Next(ClientSize.Width - label1.Size.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Size.Height);
            timer1.Enabled = true;
        }
    }
}
