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
    public partial class Replace3 : Form
    {
        Form1 f1;
        public Replace3(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Replace3_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.label1.Text = "Find What ";
            this.label2.Text = "Replace With ";
            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.textBox1.Text = this.textBox1.Text.Replace(this.textBox1.Text,this.textBox2.Text);
        }
    }
}
