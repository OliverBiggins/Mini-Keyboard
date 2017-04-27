using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace Mini_Keyboard
{
    public partial class Form1 : Form
    {
        //Global Variables
        String Mode = "Multi-Press";
        int Interval = 500;

        //Timer
        void main()
        {
             timer = new Timer();
             timer.Interval = 1000; // 1000 miliseconds = 1 second
             timer.Tick += new EventHandler(timer_Tick);
    timer.Enabled = true;
}
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            // Changes the mode between the 2 options
            if (txt_ModeStatus.Text == "Multi-Press")
            {
                txt_ModeStatus.Text = "Prediction";
                Mode = "Prediction";
            }
            else
            {
                txt_ModeStatus.Text = "Multi-Press";
                Mode = "Multi-Press";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            int EightClick = 0;
            EightClick = EightClick++;
            

        }
    }
}
