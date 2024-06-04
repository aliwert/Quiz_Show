namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            LblQuestion.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kac yilinda ilan edilmistir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bolgemizde bulunmaz?";
                BtnA.Text = "Ýzmir";
                BtnB.Text = "Balikesir";
                BtnC.Text = "Aydin";
                BtnD.Text = "Manisa";
                label4.Text = "Balikesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuslar hangi yazarimiza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Sureya";
                BtnC.Text = "Attila Ýlhan";
                BtnD.Text = "Resat Nuri";
                label4.Text = "Sait Faik";
                
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Multeciler artik ulkelerine donmeli mi?";
                BtnA.Text = "Evet";
                BtnB.Text = "Evet";
                BtnC.Text = "Evet";
                BtnD.Text = "Evet";
                label4.Text = "Evet";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Ataturk'e Kemal adini kim vermistir?";
                BtnA.Text = "Mustafa Sabri Bey";
                BtnB.Text = "Ali Riza Efendi";
                BtnC.Text = "Zubeyde Hanim";
                BtnD.Text = "Ahmet Efendi";
                label4.Text = "Mustafa Sabri Bey";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Turkiye'nin sahip oldugu uluslararasi telefon kodu nedir?";
                BtnA.Text = "+91";
                BtnB.Text = "+960";
                BtnC.Text = "+90";
                BtnD.Text = "+92";
                label4.Text = "+90";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Aspirinin ilk kez cikis yili nedir?";
                BtnA.Text = "1989";
                BtnB.Text = "1899";
                BtnC.Text = "1999";
                BtnD.Text = "1898";
                label4.Text = "1899";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Geminin bas kisminin adi nedir?";
                BtnA.Text = "Ambarlar";
                BtnB.Text = "Portuclar";
                BtnC.Text = "Irgat";
                BtnD.Text = "Pruva";
                label4.Text = "Pruva";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Futbol sahasinin buyuklugu ne kadardir?";
                BtnA.Text = "50 metre x 100 metre";
                BtnB.Text = "25 metre x 100 metre";
                BtnC.Text = "75 metre x 100 metre";
                BtnD.Text = "40 metre x 100 metre";
                label4.Text = "50 metre x 100 metre";
            }
            if (soruno == 10)
            {
           
                richTextBox1.Text = "Ataturk'ten sonra ikinci ve son maresalimiz kimdir?";
                BtnA.Text = "Ýsmet Ýnönü";
                BtnB.Text = "Kazim Karabekir";
                BtnC.Text = "Mustafa Fevzi Cakmak";
                BtnD.Text = "Ali Fuat Cebesoy";
                label4.Text = "Mustafa Fevzi Cakmak";
                BtnNext.Text = "Results";
               
            }
            if(soruno == 11)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnNext.Enabled = false;
                MessageBox.Show("True: " + dogru + "\n" + "False: " + yanlis + "\n" + "Score: " + dogru*10);
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }
    }
}
