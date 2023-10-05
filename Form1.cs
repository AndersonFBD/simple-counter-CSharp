using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            counter++;
            textBox1.Text = counter.ToString();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            counter--;
            textBox1.Text = counter.ToString();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            counter = 0;
            textBox1.Text = counter.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}