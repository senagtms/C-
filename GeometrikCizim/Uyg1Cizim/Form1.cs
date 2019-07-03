using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg1Cizim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen Kalem = new Pen(Color.Cyan,3.1f);
            cizimAlani.DrawLine(Kalem, 50, 60, 100, 200);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Magenta, 4);
            cizimAlani.DrawEllipse(kalem, 90, 85, 60, 60);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Indigo, 5);
            cizimAlani.DrawRectangle(kalem, 110, 100, 80, 90);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen Kalem = new Pen(Color.Coral, 4);
            cizimAlani.DrawRectangle(Kalem, e.X, e.Y, 50, 50);
            label1.Text = e.X + "," + e.Y;
            
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen Kalem = new Pen(Color.DarkOliveGreen, 0.5f);
            cizimAlani.DrawEllipse(Kalem, e.X, e.Y, 5, 5);
        }

        int[] Xler = new int[3];
        int[] Yler = new int[3];
        int tS = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Xler[tS] = e.X;
            Yler[tS] = e.Y;
            tS++;
            if (tS == 3)
            {
                //cizdir ve ts'yi sıfırla
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen Kalem = new Pen(Color.BlueViolet, 2f);
                cizimAlani.DrawLine(Kalem, Xler[0], Yler[0], Xler[1], Yler[1]);
                cizimAlani.DrawLine(Kalem, Xler[1], Yler[1], Xler[2], Yler[2]);
                cizimAlani.DrawLine(Kalem, Xler[2], Yler[2], Xler[0], Yler[0]);
                tS = 0;

            }
        }

        int[] Xler2 = new int[2];
        int[] Yler2 = new int[2];
        int tS2 = 0;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Xler2[tS2] = e.X;
            Yler2[tS2] = e.Y;
            tS2++;
            if (tS2 == 2)
            {
                Graphics cizimAlani = panel3.CreateGraphics();
                Pen Kalem = new Pen(Color.Black, 2f);
                cizimAlani.DrawLine(Kalem, Xler2[0], Yler2[0], Xler2[1], Yler2[1]);
                tS2 = 0;
            }
        }
    }
}
