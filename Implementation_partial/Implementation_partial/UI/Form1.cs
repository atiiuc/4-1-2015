using System;
using System.Windows.Forms;

namespace Implementation_partial.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c1=new Course();

            MessageBox.Show(c1.x+c1.y);
        }
    }
}
