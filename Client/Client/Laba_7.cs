using System;
using System.Windows.Forms;

namespace Client
{
    public partial class Laba_7 : Form
    {
        public Laba_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new  ServiceReference1.WebService1SoapClient();
            this.Text = t.HelloWorld(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = new ServiceReference1.WebService1SoapClient();
            textBox2.Text = t.MoreTwo();
        }
    }
}
