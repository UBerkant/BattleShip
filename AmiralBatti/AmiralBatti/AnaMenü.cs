using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiralBatti
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var c = new Form1
                {
                    ShowInTaskbar = false,
                    MinimizeBox = false,
                    MaximizeBox = false
                };
                c.StartPosition = FormStartPosition.CenterParent;
                c.ShowDialog(this);
            }
            else if (checkBox2.Checked)
            {
                var c = new Form2
                {
                    ShowInTaskbar = false,
                    MinimizeBox = false,
                    MaximizeBox = false
                };
                c.StartPosition = FormStartPosition.CenterParent;
                c.ShowDialog(this);
            }
            else if (checkBox3.Checked)
            {
                var c = new Form3
                {
                    ShowInTaskbar = false,
                    MinimizeBox = false,
                    MaximizeBox = false
                };
                c.StartPosition = FormStartPosition.CenterParent;
                c.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Oyun Alanı boyutunu seçiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var c = new ÇokOyunculu.form5
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            c.StartPosition = FormStartPosition.CenterParent;
            c.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else if (!checkBox3.Checked)
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (!checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
            else if (!checkBox2.Checked)
            {
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
            }
        }
    }
}
