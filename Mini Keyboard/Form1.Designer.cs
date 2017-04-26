namespace Mini_Keyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Notepad = new System.Windows.Forms.TextBox();
            this.txt_WordBuilder = new System.Windows.Forms.RichTextBox();
            this.txt_ModeStatus = new System.Windows.Forms.TextBox();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_Punc = new System.Windows.Forms.Button();
            this.btn_Space = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_SendPredict = new System.Windows.Forms.Button();
            this.btn_Blank = new System.Windows.Forms.Button();
            this.btn_Blank2 = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(617, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // txt_Notepad
            // 
            this.txt_Notepad.Location = new System.Drawing.Point(9, 35);
            this.txt_Notepad.Multiline = true;
            this.txt_Notepad.Name = "txt_Notepad";
            this.txt_Notepad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Notepad.Size = new System.Drawing.Size(596, 143);
            this.txt_Notepad.TabIndex = 1;
            // 
            // txt_WordBuilder
            // 
            this.txt_WordBuilder.Location = new System.Drawing.Point(199, 184);
            this.txt_WordBuilder.Name = "txt_WordBuilder";
            this.txt_WordBuilder.Size = new System.Drawing.Size(151, 30);
            this.txt_WordBuilder.TabIndex = 2;
            this.txt_WordBuilder.Text = "";
            // 
            // txt_ModeStatus
            // 
            this.txt_ModeStatus.Location = new System.Drawing.Point(362, 187);
            this.txt_ModeStatus.Name = "txt_ModeStatus";
            this.txt_ModeStatus.ReadOnly = true;
            this.txt_ModeStatus.Size = new System.Drawing.Size(64, 20);
            this.txt_ModeStatus.TabIndex = 3;
            this.txt_ModeStatus.Text = "Multi-Press";
            // 
            // btn_Mode
            // 
            this.btn_Mode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Mode.Location = new System.Drawing.Point(199, 219);
            this.btn_Mode.Name = "btn_Mode";
            this.btn_Mode.Size = new System.Drawing.Size(50, 50);
            this.btn_Mode.TabIndex = 4;
            this.btn_Mode.Text = "Mode";
            this.btn_Mode.UseVisualStyleBackColor = false;
            this.btn_Mode.Click += new System.EventHandler(this.btn_Mode_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Next.Location = new System.Drawing.Point(255, 220);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(50, 50);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Prev.Location = new System.Drawing.Point(311, 219);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(50, 50);
            this.btn_Prev.TabIndex = 6;
            this.btn_Prev.Text = "Previo-us";
            this.btn_Prev.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Red;
            this.btn_7.Location = new System.Drawing.Point(199, 275);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7\r\n.,\"";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Red;
            this.btn_8.Location = new System.Drawing.Point(255, 275);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8\r\nABC";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Red;
            this.btn_9.Location = new System.Drawing.Point(311, 275);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9\r\nDEF";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Red;
            this.btn_4.Location = new System.Drawing.Point(199, 331);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "4\r\nGHI";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Red;
            this.btn_5.Location = new System.Drawing.Point(255, 331);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 11;
            this.btn_5.Text = "5\r\nJKL";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Red;
            this.btn_6.Location = new System.Drawing.Point(311, 331);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6\r\nMNO";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Red;
            this.btn_1.Location = new System.Drawing.Point(199, 386);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1\r\nPQRS";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Red;
            this.btn_2.Location = new System.Drawing.Point(255, 387);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2\r\nTUV";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Red;
            this.btn_3.Location = new System.Drawing.Point(311, 387);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3\r\nWXYZ";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_Punc
            // 
            this.btn_Punc.BackColor = System.Drawing.Color.Red;
            this.btn_Punc.Location = new System.Drawing.Point(199, 442);
            this.btn_Punc.Name = "btn_Punc";
            this.btn_Punc.Size = new System.Drawing.Size(50, 50);
            this.btn_Punc.TabIndex = 16;
            this.btn_Punc.Text = "\"-...";
            this.btn_Punc.UseVisualStyleBackColor = false;
            // 
            // btn_Space
            // 
            this.btn_Space.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Space.Location = new System.Drawing.Point(255, 442);
            this.btn_Space.Name = "btn_Space";
            this.btn_Space.Size = new System.Drawing.Size(50, 50);
            this.btn_Space.TabIndex = 17;
            this.btn_Space.Text = "000\r\n[ _ ]";
            this.btn_Space.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Red;
            this.btn_0.Location = new System.Drawing.Point(311, 442);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0.TabIndex = 18;
            this.btn_0.Text = "#\r\n000";
            this.btn_0.UseVisualStyleBackColor = false;
            // 
            // btn_SendPredict
            // 
            this.btn_SendPredict.BackColor = System.Drawing.Color.Orange;
            this.btn_SendPredict.Location = new System.Drawing.Point(367, 220);
            this.btn_SendPredict.Name = "btn_SendPredict";
            this.btn_SendPredict.Size = new System.Drawing.Size(50, 50);
            this.btn_SendPredict.TabIndex = 19;
            this.btn_SendPredict.Text = "Send Predic-ted";
            this.btn_SendPredict.UseVisualStyleBackColor = false;
            // 
            // btn_Blank
            // 
            this.btn_Blank.BackColor = System.Drawing.Color.Orange;
            this.btn_Blank.Location = new System.Drawing.Point(367, 276);
            this.btn_Blank.Name = "btn_Blank";
            this.btn_Blank.Size = new System.Drawing.Size(50, 50);
            this.btn_Blank.TabIndex = 20;
            this.btn_Blank.UseVisualStyleBackColor = false;
            // 
            // btn_Blank2
            // 
            this.btn_Blank2.BackColor = System.Drawing.Color.Orange;
            this.btn_Blank2.Location = new System.Drawing.Point(367, 331);
            this.btn_Blank2.Name = "btn_Blank2";
            this.btn_Blank2.Size = new System.Drawing.Size(50, 50);
            this.btn_Blank2.TabIndex = 21;
            this.btn_Blank2.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Orange;
            this.btn_Enter.Location = new System.Drawing.Point(367, 386);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(50, 106);
            this.btn_Enter.TabIndex = 22;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 518);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_Blank2);
            this.Controls.Add(this.btn_Blank);
            this.Controls.Add(this.btn_SendPredict);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_Space);
            this.Controls.Add(this.btn_Punc);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Mode);
            this.Controls.Add(this.txt_ModeStatus);
            this.Controls.Add(this.txt_WordBuilder);
            this.Controls.Add(this.txt_Notepad);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Notepad;
        private System.Windows.Forms.RichTextBox txt_WordBuilder;
        private System.Windows.Forms.TextBox txt_ModeStatus;
        private System.Windows.Forms.Button btn_Mode;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_Punc;
        private System.Windows.Forms.Button btn_Space;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_SendPredict;
        private System.Windows.Forms.Button btn_Blank;
        private System.Windows.Forms.Button btn_Blank2;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Timer timer1;

    }
}

