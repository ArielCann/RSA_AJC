using System.Numerics;

namespace RSA_AJC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bob.Text = Crypto.RSA_E(3571, 101, Alice.Text);
            Alice.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bob.Text = Crypto.RSA_D(Bob.Text);
        }
    }
}
