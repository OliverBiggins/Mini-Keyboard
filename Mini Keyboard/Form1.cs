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
        int Interval = 5000;
        int Click = 0;
        string Letter;
        string[] B8 = new string[7] {"a", "b", "c", "8", "A", "B", "C"};

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


        private void btn_8_Click_1(object sender, EventArgs e)
        {
            
            Click = Click + 1;
            Letter = B8[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            txt_WordBuilder.AppendText(Letter);
            Click = 0;
        }

    }
}
