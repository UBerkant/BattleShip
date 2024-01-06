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
using System.IO;
using System.Net;

namespace AmiralBatti
{
    public partial class GamePlatform : Form
    {
        public GamePlatform(bool host_mu, string ip=null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            if (host_mu)
            {              
                PlayerLabel.Text = "Oyuncu 1";
                tcp_server = new TcpListener(System.Net.IPAddress.Any, 5732);
                tcp_server.Start();
                while (true)
                {
                    MessageBox.Show("Başarıyla oturum oluşturuldu. Ikinci Oyuncu Bekleniyor.");
                    tcp_soket = tcp_server.AcceptSocket();
                }                
            }
            else
            {
                PlayerLabel.Text = "Oyuncu 2";
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
            TurnLabel.Text = "Sıra Rakibinizde.";
            ReceiveMove();
            TurnLabel.Text = "Sıra Sizde.";
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
                            if (oyuncu1[i] == buffer[0] && i == max_gemi - 1)
                            {
                                oyuncu1_gemi_sayisi = 0;
                                ShootResultLabel.Text = "Filo Komutanınız Vuruldu.";
                                break;
                            }
                            else
                            {
                                oyuncu1_gemi_sayisi--;
                                ShootResultLabel.Text = "Geminiz Vuruldu.";
                                break;
                            }
                        }
                        else
                        {
                            ShootResultLabel.Text = "Iskaladınız.";
                        }
                    }
                }
                if (placing_phase==true)
                {
                    oyuncu1[gemisayisi] = buffer[0];
                    CoinFlipResultLabel.Text = "";
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
                            if (oyuncu2[i] == buffer[0] && i == max_gemi - 1)
                            {
                                oyuncu2_gemi_sayisi = 0;
                                ShootResultLabel.Text = "Filo Komutanınız Vuruldu.";
                                break;
                            }
                            else
                            {
                                oyuncu2_gemi_sayisi--;
                                ShootResultLabel.Text = "Geminiz Vuruldu.";
                                break;
                            }
                        }
                        else
                        {
                            ShootResultLabel.Text = "Iskaladınız.";
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
                CoinFlipResultLabel.Text = "Başlangıç Turu sizde.";
                turn = false;
            }
        }
        private void Dondur()
        {
            Player2Group.Enabled = false;
            Player1Group.Enabled = false;
            CoinFlipGroupBox.Visible = false;
        }
        private void Devam()
        {            
            if (turn == false && war_phase == false)
            {
                Player2Group.Enabled = true;
            }
            if (turn == true && war_phase == false)
            {
                Player1Group.Enabled = true;
            }
            if (turn == false && war_phase == true)
            {
                Player1Group.Enabled = true;
            }
            if (turn == true && war_phase == true)
            {
                Player2Group.Enabled = true;
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
                for (int i = 0; i <= max_gemi - 1; i++)
                {
                    if (oyuncu1[i] == int.Parse(dButton.Name))
                    {
                        if (oyuncu1[i] == int.Parse(dButton.Name) && i == max_gemi - 1)
                        {
                            oyuncu1_gemi_sayisi = 0;
                            ShootResultLabel.Text = "Filo Komutanını Vurdunuz.";
                            dButton.BackgroundImageLayout = ImageLayout.Stretch;
                            dButton.BackgroundImage = AmiralBatti.Properties.Resources.Boom;
                            break;
                        }
                        else
                        {
                            oyuncu1_gemi_sayisi--;
                            ShootResultLabel.Text = "Gemiyi vurdunuz.";
                            dButton.BackgroundImageLayout = ImageLayout.Stretch;
                            dButton.BackgroundImage = AmiralBatti.Properties.Resources.Boom;
                            break;
                        }
                    }
                    else
                    {
                        ShootResultLabel.Text = "Iskaladınız.";
                    }
                }
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
                    dButton.BackgroundImageLayout = ImageLayout.Stretch;
                    dButton.BackgroundImage = AmiralBatti.Properties.Resources.WarShip;
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
                for (int i = 0; i <= max_gemi - 1; i++)
                {
                    if (oyuncu2[i] == int.Parse(dButton.Name))
                    {
                        if (oyuncu2[i] == int.Parse(dButton.Name) && i == max_gemi - 1)
                        {
                            oyuncu2_gemi_sayisi = 0;
                            ShootResultLabel.Text = "Filo Komutanını Vurdunuz.";
                            dButton.BackgroundImageLayout = ImageLayout.Stretch;
                            dButton.BackgroundImage = AmiralBatti.Properties.Resources.Boom;
                            break;
                        }
                        else
                        {
                            oyuncu2_gemi_sayisi--;
                            ShootResultLabel.Text = "Gemiyi vurdunuz.";
                            dButton.BackgroundImageLayout = ImageLayout.Stretch;
                            dButton.BackgroundImage = AmiralBatti.Properties.Resources.Boom;
                            break;
                        }
                    }
                    else
                    {
                        ShootResultLabel.Text = "Iskaladınız.";
                    }
                }
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
                    dButton.BackgroundImageLayout = ImageLayout.Stretch;
                    dButton.BackgroundImage = AmiralBatti.Properties.Resources.WarShip;
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
        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            if (!TailsCheck.Checked && !HeadsCheck.Checked)
            {
                MessageBox.Show("Yazı-Tura dan birisini seçiniz.");
            }
            else
            {
                int para = rnd.Next(0, 2);
                if (para == 0)
                {
                    if (HeadsCheck.Checked)
                    {
                        Player1Group.Enabled = true;
                        TurnLabel.Text = "Sıra Sizde.";
                        CoinFlipResultLabel.Text="Yazı!!! Başlangıç turu sizde.";
                    }
                    else
                    {
                        TurnLabel.Text = "Sıra Rakibinizde.";
                        CoinFlipResultLabel.Text="Tura! Başlangıcı Rakibiniz yapacak.";
                        byte[] num = { 101 };
                        tcp_soket.Send(num);
                        MessageReceiver.RunWorkerAsync();
                    }
                }
                if (para == 1)
                {
                    if (TailsCheck.Checked)
                    {
                        Player1Group.Enabled = true;
                        TurnLabel.Text = "Sıra Sizde";
                        CoinFlipResultLabel.Text="Tura!!! Başlangıç turu sizde.";
                    }
                    else
                    {
                        TurnLabel.Text = "Sıra Rakibinizde.";
                        CoinFlipResultLabel.Text="Yazı! Başlangıcı Rakibiniz yapacak.";
                        byte[] num = { 101 };
                        tcp_soket.Send(num);
                        MessageReceiver.RunWorkerAsync();
                    }
                }
                CoinFlipGroupBox.Visible = false;                
            }
        }

        private void HeadsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HeadsCheck.Checked)
            {
                TailsCheck.Enabled = false;
            }
            else if (!HeadsCheck.Checked)
            {
                TailsCheck.Enabled = true;
            }
        }

        private void TailsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TailsCheck.Checked)
            {
                HeadsCheck.Enabled = false;
            }
            else if (!TailsCheck.Checked)
            {
                HeadsCheck.Enabled = true;
            }
        }
        public void AlanBoyutu1()
        {
            Player1AreaTable.ColumnStyles.Clear();
            Player1AreaTable.RowStyles.Clear();
            Player1AreaTable.Controls.Clear();
            Player1AreaTable.ColumnCount = boyut;
            Player1AreaTable.RowCount = boyut;
            for (int i = 0; i < Player1AreaTable.ColumnCount; i++)
            {
                Player1AreaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                for (int x = 0; x < Player1AreaTable.RowCount; x++)
                {
                    if (i == 0)
                    {
                        Player1AreaTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
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
                    Player1AreaTable.Controls.Add(cmd, x, i);
                }
            }
        }
        public void AlanBoyutu2()
        {
            Player2AreaTable.ColumnStyles.Clear();
            Player2AreaTable.RowStyles.Clear();
            Player2AreaTable.Controls.Clear();
            Player2AreaTable.ColumnCount = boyut;
            Player2AreaTable.RowCount = boyut;
            for (int i = 0; i < Player2AreaTable.ColumnCount; i++)
            {
                Player2AreaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                for (int x = 0; x < Player2AreaTable.RowCount; x++)
                {
                    if (i == 0)
                    {
                        Player2AreaTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
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
                    Player2AreaTable.Controls.Add(cmd2, x, i);
                }
            }
        }
        public bool Oyunbitti()
        {
            if (oyuncu1_gemi_sayisi == 0)
            {
                WinnerLabel.Text = "Oyuncu 2 Kazandı.";
                MessageBox.Show("Oyuncu 2 Kazandı.");
                return true;
            }
            if (oyuncu2_gemi_sayisi == 0)
            {
                WinnerLabel.Text = "Oyuncu 1 Kazandı.";
                MessageBox.Show("Oyuncu 1 Kazandı.");
                return true;
            }
            return false;
        }
        private void GamePlatform_Load(object sender, EventArgs e)
        {
            TurnLabel.Text = "";
            WinnerLabel.Text = "";
            ShootResultLabel.Text = "";
            CoinFlipResultLabel.Text = "";
            AlanBoyutu1();
            AlanBoyutu2();
        }
    }
}