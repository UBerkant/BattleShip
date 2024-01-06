using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiralBatti.CokOyunculu
{
    public partial class Hosting : Form
    {
        public Hosting()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e) // bağlanma - client
        {
            GamePlatform newform4 = new GamePlatform(false, IPText.Text);
            Visible = false;
            if (!newform4.IsDisposed)
            {
                newform4.ShowDialog();
            }
            Visible = true;
        }

        private void HostButton_Click(object sender, EventArgs e) // oluşturma - host
        {
            GamePlatform newForm4 = new GamePlatform(true);
            Visible = false;
            if (!newForm4.IsDisposed)
            {
                newForm4.ShowDialog();
            }
            Visible = true;
        }

    }
}
