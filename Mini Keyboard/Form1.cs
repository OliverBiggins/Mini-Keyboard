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
        string Word;
        string[] B9 = new string[7] { "d", "e", "f", "9", "D", "E", "F" };
        string[] B8 = new string[7] { "a", "b", "c", "8", "A", "B", "C" };
        string[] B7 = new string[7] { ".", "~", "''", "7", "'", ":", ";" };
        string[] B6 = new string[7] { "m", "n", "o", "6", "M", "N", "O" };
        string[] B5 = new string[7] { "j", "k", "l", "5", "J", "K", "L" };
        string[] B4 = new string[7] { "g", "h", "i", "4", "G", "H", "I" };
        string[] B3 = new string[9] { "w", "x", "y", "z", "3", "W", "X", "Y", "Z" };
        string[] B2 = new string[7] { "t", "u", "v", "2", "T", "U", "V" };
        string[] B1 = new string[9] { "p", "q", "r", "s", "1", "P", "Q", "R", "S" };

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

        private void btn_7_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B7[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B9[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B4[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B5[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B6[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B1[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B2[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Click = Click + 1;
            Letter = B3[Click - 1];
            if (Click == 7)
            {
                Click = 0;
            }
        }

        private void btn_Space_Click(object sender, EventArgs e)
        {
            Word = txt_WordBuilder.Text;
            txt_WordBuilder.Text = "";
            txt_Notepad.AppendText(Word + " ");
        }

    }
}
