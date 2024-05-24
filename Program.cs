using System;
using System.Windows;
namespace ConsoleApplication5
{
    public partical class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var person = textBox1.Text + " " + textBox2.Text;
            MessageBox.Show(person, "Your personal data", MessageBoxButtons.YesNo);
        }
    }
}

