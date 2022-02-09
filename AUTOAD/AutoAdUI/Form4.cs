using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoAdUI
{
    public partial class Form4 : Form
    {
        Timer MyTimer = new Timer();
        Timer timerPhoto = new Timer();
        public Form4()
        {
            InitializeComponent();
        }

        private void timerPhoto_Tick(object sender, EventArgs e)
        {
            
            foreach (object t in this.Controls)
            {

                if (t.GetType() == typeof(PictureBox))
                {
                    Task.Delay(80).Wait();
                    ((PictureBox)t).SizeMode = PictureBoxSizeMode.StretchImage;
                    ((PictureBox)t).Show();
                }
                
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {



            MyTimer.Interval = (1 * 8 * 1150);
            MyTimer.Tick += new EventHandler(Timer_Tick);
            MyTimer.Start();

            timerPhoto.Interval = (1 * 2 * 800);
            timerPhoto.Tick += new EventHandler(timerPhoto_Tick);
            timerPhoto.Start();


            foreach (object t in this.Controls)
                if (t.GetType() == typeof(PictureBox))
                    ((PictureBox)t).Hide();
            fundal1.Show();
            fundal2.Show();

        }


    }

}