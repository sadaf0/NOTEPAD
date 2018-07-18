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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void save()
        {
            saveFileDialog1.Filter = "All text |*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, this.textBox1.Text);


            }
        
        
        
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
            this.textBox1.Multiline = true;
            this.textBox1.Font = new Font("Arial",16);
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.tiToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.wordWrapToolStripMenuItem.Checked = true;
            this.label1.Visible = false;
         }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Syeda Sadaf" ,"About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {

                this.wordWrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;

            }
            else
            {
                this.wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            
            
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                
            
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void tiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = DateTime.Now.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find2 f2 = new Find2(this);
            f2.Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace3 f3 = new Replace3(this);
            f3.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text |*.txt";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            { 
            
                string fname= openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fname);
                
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All text |*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, this.textBox1.Text);


            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                DialogResult dr = MessageBox.Show("Do you want to save?","Note Pad",MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {

                    save();
                }
                else if(dr==DialogResult.No)
                {
                    this.textBox1.Text = "";
                
                
                }
            
            
            
            }




        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text != "")
            {

                DialogResult dr = MessageBox.Show("Do you want to save?", "Note Pad", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {

                    save();
                }
                else if (dr == DialogResult.No)
                {
                    this.textBox1.Text = "";


                }



            }
        }
    }
}
