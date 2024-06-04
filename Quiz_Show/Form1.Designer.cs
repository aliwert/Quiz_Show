namespace Quiz_Show
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblQuestion = new Label();
            LblTrue = new Label();
            LblFalse = new Label();
            BtnNext = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(565, 232);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(0, 263);
            BtnA.Margin = new Padding(4);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(272, 41);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(280, 263);
            BtnB.Margin = new Padding(4);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(285, 41);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(0, 323);
            BtnC.Margin = new Padding(4);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(272, 41);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(280, 323);
            BtnD.Margin = new Padding(4);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(285, 41);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 7);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 5;
            label1.Text = "Question No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(609, 58);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 6;
            label2.Text = "True:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 112);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 7;
            label3.Text = "False:";
            // 
            // LblQuestion
            // 
            LblQuestion.AutoSize = true;
            LblQuestion.Location = new Point(749, 7);
            LblQuestion.Name = "LblQuestion";
            LblQuestion.Size = new Size(24, 28);
            LblQuestion.TabIndex = 8;
            LblQuestion.Text = "0";
            // 
            // LblTrue
            // 
            LblTrue.AutoSize = true;
            LblTrue.Location = new Point(749, 58);
            LblTrue.Name = "LblTrue";
            LblTrue.Size = new Size(24, 28);
            LblTrue.TabIndex = 9;
            LblTrue.Text = "0";
            // 
            // LblFalse
            // 
            LblFalse.AutoSize = true;
            LblFalse.Location = new Point(749, 112);
            LblFalse.Name = "LblFalse";
            LblFalse.Size = new Size(24, 28);
            LblFalse.TabIndex = 10;
            LblFalse.Text = "0";
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(609, 153);
            BtnNext.Margin = new Padding(4);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(164, 41);
            BtnNext.TabIndex = 11;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(742, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 416);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(714, 457);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 535);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnNext);
            Controls.Add(LblFalse);
            Controls.Add(LblTrue);
            Controls.Add(LblQuestion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Quiz Show";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblQuestion;
        private Label LblTrue;
        private Label LblFalse;
        private Button BtnNext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
