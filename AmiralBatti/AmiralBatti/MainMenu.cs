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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            if (SmallAreaCheckBox.Checked)
            {
                var c = new SmallArea
                {
                    ShowInTaskbar = false,
                    MinimizeBox = false,
                    MaximizeBox = false
                };
                c.StartPosition = FormStartPosition.CenterParent;
                c.ShowDialog(this);
            }
            else if (MidAreaCheckBox.Checked)
            {
                var c = new MidArea
                {
                    ShowInTaskbar = false,
                    MinimizeBox = false,
                    MaximizeBox = false
                };
                c.StartPosition = FormStartPosition.CenterParent;
                c.ShowDialog(this);
            }
            else if (LargeAreaCheckBox.Checked)
            {
                var c = new LargeArea
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
                MessageBox.Show("Oyun Alan boyutunu seçiniz.");
            }
        }

        private void MultiPlayerButton_Click(object sender, EventArgs e)
        {
            var c = new CokOyunculu.Hosting
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            c.StartPosition = FormStartPosition.CenterParent;
            c.ShowDialog(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void LargeAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LargeAreaCheckBox.Checked)
            {
                MidAreaCheckBox.Enabled = false;
                SmallAreaCheckBox.Enabled = false;
            }
            else if (!LargeAreaCheckBox.Checked)
            {
                MidAreaCheckBox.Enabled = true;
                SmallAreaCheckBox.Enabled = true;
            }
        }

        private void SmallAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SmallAreaCheckBox.Checked)
            {
                MidAreaCheckBox.Enabled = false;
                LargeAreaCheckBox.Enabled = false;
            }
            else if (!SmallAreaCheckBox.Checked)
            {
                MidAreaCheckBox.Enabled = true;
                LargeAreaCheckBox.Enabled = true;
            }
        }

        private void MidAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MidAreaCheckBox.Checked)
            {
                LargeAreaCheckBox.Enabled = false;
                SmallAreaCheckBox.Enabled = false;
            }
            else if (!MidAreaCheckBox.Checked)
            {
                LargeAreaCheckBox.Enabled = true;
                SmallAreaCheckBox.Enabled = true;
            }
        }
    }
}
