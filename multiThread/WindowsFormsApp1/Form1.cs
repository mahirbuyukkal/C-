using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnb.Click += Btnb_Click;
            btny.Click += Btny_Click;
            btnr.Click += Btnr_Click;
        }
        Random rnd;
        Thread th1;
        Thread th2;
        Thread th3;

        private void Btnr_Click(object sender, EventArgs e)
        {
            th3 = new Thread(metot3);
            th3.Start();
        }

        private void Btny_Click(object sender, EventArgs e)
        {
            th1 = new Thread(metot1);
            th1.Start();
        }

        private void Btnb_Click(object sender, EventArgs e)
        {
            th2 = new Thread(metot2);
            th2.Start();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        public void metot1() //Yellow
        {
            for(int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                    rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }
        public void metot2() //Blue
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                    rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }
        public void metot3() //Red
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                    rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }

    }
}
