using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace notepad_final
{
    public partial class Find2 : Form
    {
        Form1 f1;
        public Find2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Find2_Load(object sender, EventArgs e)
        {
            this.Text = "Find";
            this.label1.Text="Find What";
            this.button1.Text = "Find";
            this.button2.Text = "Cancel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(this.textBox1.Text))
            {

                MessageBox.Show("Word Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            
            }
        }
    }
}
