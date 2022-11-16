namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
            int x;
            x = numero.Next(1, 60);
            textBox1.Text = x.ToString();

            x = numero.Next(1, 60);
            textBox2.Text = x.ToString();

            x = numero.Next(1, 60);
            textBox3.Text = x.ToString();

            x = numero.Next(1, 60);
            textBox4.Text = x.ToString();

            x = numero.Next(1, 60);
            textBox5.Text = x.ToString();

            x = numero.Next(1, 60);
            textBox6.Text = x.ToString();











        }
    }
}