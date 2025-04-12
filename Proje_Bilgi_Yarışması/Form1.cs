namespace Proje_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlış = 0;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            Lbls.Text = soruno.ToString();

            if (soruno == 0)
            {
                richTextBox1.Text = "";
                btnsonraki.Text = "Başla";
            }
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label1.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehrimiz ege bölgesinde değildir ?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label1.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar kimin eseridir ?";
                btna.Text = "Sait Faik Abasıyanık";
                btnb.Text = "Cemmal Süreyya";
                btnc.Text = "Attila İlhan";
                btnd.Text = "Reşat Nuri Güntekin";
                label1.Text = "Sait Faik Abasıyanık";
                btnsonraki.Text = "Sonuçar";
            }
            if (soruno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru :" + doğru + " /" + " Yanlış :" + yanlış);
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label2.Text = btna.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                Lbld.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                Lbly.Text = yanlış.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label2.Text = btnb.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                Lbld.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                Lbly.Text = yanlış.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label2.Text = btnc.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                Lbld.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                Lbly.Text = yanlış.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label2.Text = btnd.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                Lbld.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                Lbly.Text = yanlış.ToString();
                pictureBox1.Visible = true;

            }
        }
    }
}
