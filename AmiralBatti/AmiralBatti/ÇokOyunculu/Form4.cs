using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace AmiralBatti
{
    public partial class Form4 : Form
    {
        public Form4(bool host_mu, string ip=null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            if (host_mu)
            {
                label3.Text = "Oyuncu 1";
                tcp_server = new TcpListener(System.Net.IPAddress.Any, 5732);
                tcp_server.Start();
                tcp_soket = tcp_server.AcceptSocket();
            }
            else
            {
                label3.Text = "Oyuncu 2";
                try
                {
                    tcp_client = new TcpClient(ip, 5732);
                    tcp_soket = tcp_client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch(Exception except)
                {
                    MessageBox.Show(except.Message);
                    Close();
                }
            }
        }
        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Oyunbitti())
            {
                return;
            }
            Dondur();
            label1.Text = "Sıra Rakibinizde.";
            ReceiveMove();
            label1.Text = "Sıra Sizde.";
            if (!Oyunbitti())
            {
                Devam();
            }
        }
        public Socket tcp_soket;
        public BackgroundWorker MessageReceiver = new BackgroundWorker();
        public TcpListener tcp_server = null;
        public TcpClient tcp_client;
        int[] oyuncu1 = new int[10];
        int[] oyuncu2 = new int[10];
        int kutu = 0, oyuncu1_gemi_sayisi=10, oyuncu2_gemi_sayisi=10, gemisayisi=0, max_gemi=10, boyut=5;
        bool turn=true;
        bool war_phase=false, placing_phase=true;
        Random rnd = new Random();
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (tcp_server != null)
            {
                tcp_server.Stop();
            }
        }
        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            tcp_soket.Receive(buffer);
            if(buffer[0]>=1 && buffer[0] <= 25)
            {
                if (war_phase == true)
                {
                    for (int i = 0; i <= max_gemi - 1; i++)
                    {
                        if (oyuncu1[i] == buffer[0])
                        {
                            oyuncu1_gemi_sayisi--;
                            label4.Text = "Oyuncu 1 gemisi vuruldu.";                            
                        }
                        if (oyuncu1[i] == buffer[0] && i == max_gemi-1)
                        {
                            oyuncu1_gemi_sayisi = 0;
                            label4.Text = "Oyuncu 1 filo komutanı vuruldu";
                            break;
                        }
                        else
                        {
                            label4.Text = "Oyuncu 2 Iskaladı.";
                        }
                    }
                }
                if (placing_phase==true)
                {
                    oyuncu1[gemisayisi] = buffer[0];
                    label5.Text = "";
                    turn = false;
                }
            }
            if(buffer[0]>=26 && buffer[0] <= 50)
            {
                if (war_phase==true)
                {
                    for (int i = 0; i <= max_gemi - 1; i++)
                    {
                        if (oyuncu2[i] == buffer[0])
                        {
                            oyuncu2_gemi_sayisi--;
                            label4.Text = "Oyuncu 2 gemisi vuruldu.";                            
                        }
                        if (oyuncu2[i] == buffer[0] && i == max_gemi - 1)
                        {
                            oyuncu2_gemi_sayisi=0;
                            label4.Text = "Oyuncu 2 filo komutanı vuruldu.";
                            break;
                        }
                        else
                        {
                            label4.Text = "Oyuncu 1 Iskaladı.";
                        }
                    }
                }
                if (placing_phase == true)
                {
                    oyuncu2[gemisayisi] = buffer[0];
                    turn = true;
                }
            }
            if (buffer[0] == 101)
            {
                label5.Text = "Başlangıç Turu sizde.";
                turn = false;
            }
        }
        private void Dondur()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Visible = false;
        }
        private void Devam()
        {            
            if (turn == false && war_phase == false)
            {
                groupBox1.Enabled = true;
            }
            if (turn == true && war_phase == false)
            {
                groupBox2.Enabled = true;
            }
            if (turn == false && war_phase == true)
            {
                groupBox2.Enabled = true;
            }
            if (turn == true && war_phase == true)
            {
                groupBox1.Enabled = true;
            }            
        }
        public void yazdir(object sender, EventArgs e)
        {
            Button dButton = new Button();
            dButton = sender as Button;
            if (war_phase == true)
            {
                dButton.Enabled = false;
                dButton.FlatAppearance.BorderSize = 3;
                dButton.FlatAppearance.BorderColor = Color.Red;
                int n = int.Parse(dButton.Name);
                byte[] num = { (byte)n };
                tcp_soket.Send(num);
                MessageReceiver.RunWorkerAsync();
            }
            if (placing_phase == true)
            {
                bool olumlu = true;
                for (int i = 0; i < gemisayisi; i++)
                {
                    if (oyuncu1[i] == int.Parse(dButton.Name))
                    {
                        olumlu = false;
                    }
                }
                if (olumlu == true)
                {
                    oyuncu1[gemisayisi] = int.Parse(dButton.Name);
                    gemisayisi++;
                    if (gemisayisi == max_gemi)
                    {
                        war_phase = true;
                        placing_phase = false;
                    }
                    dButton.FlatAppearance.BorderSize = 3;
                    dButton.FlatAppearance.BorderColor = Color.Lime;
                    int n = int.Parse(dButton.Name);
                    byte[] num = { (byte) n };
                    tcp_soket.Send(num);
                    MessageReceiver.RunWorkerAsync();
                }
            }
        }
        public void yazdir2(object sender, EventArgs e)
        {
            Button dButton = new Button();
            dButton = sender as Button;
            if (war_phase == true)
            {
                dButton.Enabled = false;
                dButton.FlatAppearance.BorderSize = 3;
                dButton.FlatAppearance.BorderColor = Color.Red;
                byte[] num = { (byte) int.Parse(dButton.Name)};
                tcp_soket.Send(num);
                MessageReceiver.RunWorkerAsync();
            }
            if (placing_phase == true)
            {
                bool olumlu = true;
                for (int i = 0; i < gemisayisi; i++)
                {
                    if (oyuncu2[i] == int.Parse(dButton.Name))
                    {
                        olumlu = false;
                    }
                }
                if (olumlu == true)
                {
                    oyuncu2[gemisayisi] = int.Parse(dButton.Name);
                    gemisayisi++;
                    if (gemisayisi == max_gemi)
                    {
                        war_phase = true;
                        placing_phase = false;
                    }
                    dButton.FlatAppearance.BorderSize = 3;
                    dButton.FlatAppearance.BorderColor = Color.Lime;
                    byte[] num = { (byte) int.Parse(dButton.Name) };
                    tcp_soket.Send(num);
                    MessageReceiver.RunWorkerAsync();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("Yazı-Tura dan birisini seçiniz.");
            }
            else
            {
                int para = rnd.Next(0, 2);
                if (para == 0)
                {
                    if (checkBox4.Checked)
                    {
                        groupBox2.Enabled = true;
                        label1.Text = "Sıra Sizde.";
                        label5.Text="Yazı!!! Başlangıç turu sizde.";
                    }
                    else
                    {
                        label1.Text = "Sıra Rakibinizde.";
                        label5.Text="Tura! Başlangıcı Rakibiniz yapacak.";
                        byte[] num = { 101 };
                        tcp_soket.Send(num);
                        MessageReceiver.RunWorkerAsync();
                    }
                }
                if (para == 1)
                {
                    if (checkBox3.Checked)
                    {
                        groupBox2.Enabled = true;
                        label1.Text = "Sıra Sizde";
                        label5.Text="Tura!!! Başlangıç turu sizde.";
                    }
                    else
                    {
                        label1.Text = "Sıra Rakibinizde.";
                        label5.Text="Yazı! Başlangıcı Rakibiniz yapacak.";
                        byte[] num = { 101 };
                        tcp_soket.Send(num);
                        MessageReceiver.RunWorkerAsync();
                    }
                }
                groupBox4.Visible = false;                
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Enabled = false;
            }
            else if (!checkBox4.Checked)
            {
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Enabled = false;
            }
            else if (!checkBox3.Checked)
            {
                checkBox4.Enabled = true;
            }
        }
        public void AlanBoyutu1()
        {
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = boyut;
            tableLayoutPanel1.RowCount = boyut;
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                for (int x = 0; x < tableLayoutPanel1.RowCount; x++)
                {
                    if (i == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    }
                    Button cmd = new Button();
                    cmd.BackColor = SystemColors.Highlight;
                    cmd.FlatAppearance.BorderSize = 2;
                    cmd.FlatAppearance.BorderColor = Color.DarkGray;
                    cmd.FlatStyle = FlatStyle.Flat;
                    cmd.Dock = DockStyle.Fill;
                    kutu++;
                    cmd.Name = kutu.ToString();
                    cmd.Click += new EventHandler(yazdir);
                    tableLayoutPanel1.Controls.Add(cmd, x, i);
                }
            }
        }
        public void AlanBoyutu2()
        {
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.ColumnCount = boyut;
            tableLayoutPanel2.RowCount = boyut;
            for (int i = 0; i < tableLayoutPanel2.ColumnCount; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                for (int x = 0; x < tableLayoutPanel2.RowCount; x++)
                {
                    if (i == 0)
                    {
                        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    }
                    Button cmd2 = new Button();
                    cmd2.BackColor=SystemColors.Highlight;
                    cmd2.FlatAppearance.BorderSize = 2;
                    cmd2.FlatAppearance.BorderColor = Color.DarkGray;
                    cmd2.FlatStyle = FlatStyle.Flat;
                    cmd2.Dock = DockStyle.Fill;
                    kutu++;
                    cmd2.Name = kutu.ToString();
                    cmd2.Click += new EventHandler(yazdir2);
                    tableLayoutPanel2.Controls.Add(cmd2, x, i);
                }
            }
        }
        public bool Oyunbitti()
        {
            if (oyuncu1_gemi_sayisi == 0)
            {
                label2.Text = "Oyuncu 2 Kazandı.";
                MessageBox.Show("Oyuncu 2 Kazandı.");
                return true;
            }
            if (oyuncu2_gemi_sayisi == 0)
            {
                label2.Text = "Oyuncu 1 Kazandı.";
                MessageBox.Show("Oyuncu 1 Kazandı.");
                return true;
            }
            return false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label5.Text = "";
            AlanBoyutu1();
            AlanBoyutu2();
        }
    }
}