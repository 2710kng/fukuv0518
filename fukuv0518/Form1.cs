namespace fukuv0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text="�t�ˌ���";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = 90;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }
    }
}