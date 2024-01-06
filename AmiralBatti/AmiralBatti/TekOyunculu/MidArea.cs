using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AmiralBatti
{
    public partial class MidArea : Form
    {
        public MidArea()
        {
            InitializeComponent();
        }
        int secilen_konum;
        bool turn, olabilir_mi = false, olumlu1, olumlu2, zar = true;
        int gemi_sayisi = 0, kutu = 0, boyut = 6, dusman_gemi_sayisi = 0, max_gemi=8;
        int[] oyuncu1 = new int[8];
        int[] oyuncu2 = new int[8];
        List<int> vuran_konum = new List<int>();
        Random rnd = new Random();
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
                        turn = true;
                        MessageBox.Show("Yazı!!! Başlangıç turu sizde.");
                    }
                    else
                    {
                        turn = false;
                        MessageBox.Show("Tura! Başlangıcı Rakibiniz yapacak.");
                    }
                }
                if (para == 1)
                {
                    if (TailsCheck.Checked)
                    {
                        turn = true;
                        MessageBox.Show("Tura!!! Başlangıç turu sizde.");
                    }
                    else
                    {
                        turn = false;
                        MessageBox.Show("Yazı! Başlangıcı Rakibiniz yapacak.");
                    }
                }
                CoinFlipGroup.Visible = false;
                zar = false;
                WinnerLabel.Text = "";
            }
        }
        public void AlanBoyutu()
        {
            GameAreaTable.ColumnStyles.Clear();
            GameAreaTable.RowStyles.Clear();
            GameAreaTable.Controls.Clear();
            GameAreaTable.ColumnCount = boyut;
            GameAreaTable.RowCount = boyut;
            for (int i = 0; i < GameAreaTable.ColumnCount; i++)
            {
                GameAreaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                for (int x = 0; x < GameAreaTable.RowCount; x++)
                {
                    if (i == 0)
                    {
                        GameAreaTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    }
                    Button cmd = new Button();
                    cmd.BackColor = Color.Cyan;
                    cmd.Dock = DockStyle.Fill;
                    kutu++;
                    cmd.Name = kutu.ToString();
                    cmd.Click += new EventHandler(yazdir);
                    GameAreaTable.Controls.Add(cmd, x, i);
                    cmd.Text = "E";
                }
            }
        }
        public void yazdir(object sender, EventArgs e)
        {
            Button dButton = new Button();
            dButton = sender as Button;
            KonumNumeric.Value = int.Parse(dButton.Name);
            if (olabilir_mi == false)
            {
                oyuncu1_yerlestir();
                dButton.Text = "";
                dButton.BackgroundImageLayout = ImageLayout.Stretch;
                dButton.BackgroundImage = AmiralBatti.Properties.Resources.WarShip;
                if (olumlu1 == true)
                {
                    dusman_yerlestir();
                    if (olumlu2 == true)
                    {
                        EnemyShipCounterText.Text = dusman_gemi_sayisi.ToString();
                        PlayerShipCounterText.Text = gemi_sayisi.ToString();
                    }
                }
                if (gemi_sayisi == max_gemi)
                {
                    CoinFlipGroup.Visible = true;
                    WinnerLabel.Text = "Sıra belirleyebilmek için zar atınız.";
                }
            }
            if (olabilir_mi == true)
            {
                if (zar == false)
                {
                    if (turn == true)
                    {
                        oyuncu_vurus();
                        if (dusman_gemi_sayisi == 0)
                        {
                            WinnerLabel.Text = "Oyunu Kazandınız.";
                            GameBoardGroup.Enabled = false;
                        }
                        else
                        {
                            dusman_vurus();
                            if (gemi_sayisi == 0)
                            {
                                WinnerLabel.Text = "Oyunu Kaybettiniz...";
                                GameBoardGroup.Enabled = false;
                            }
                        }
                    }
                    if (turn == false)
                    {
                        dusman_vurus();
                        if (gemi_sayisi == 0)
                        {
                            WinnerLabel.Text = "Oyunu Kaybettiniz...";
                            GameBoardGroup.Enabled = false;
                        }
                        else
                        {
                            oyuncu_vurus();
                            if (dusman_gemi_sayisi == 0)
                            {
                                WinnerLabel.Text = "Oyunu Kazandınız.";
                                GameBoardGroup.Enabled = false;
                            }
                        }
                    }
                    dButton.Enabled = false;
                }
            }
        }
        public void dusman_vurus()
        {
            bool var_mi = false;
            do
            {
                int random = rnd.Next(1, kutu);
                if (vuran_konum.Contains(random))
                {
                    var_mi = true;
                }
                else
                {
                    for (int i = 0; i < max_gemi; i++)
                    {
                        if (oyuncu1[i] == random)
                        {
                            gemi_sayisi--;
                            PlayerShipCounterText.Text = gemi_sayisi.ToString();
                            EnemyShootResultLabel.Text = "Geminiz Vuruldu.";
                            vuran_konum.Add(random);
                            break;
                        }
                        if (oyuncu1[max_gemi-1] == random)
                        {
                            gemi_sayisi = 0;
                            PlayerShipCounterText.Text = gemi_sayisi.ToString();
                            EnemyShootResultLabel.Text = "Filo Komutanınız Vuruldu..";
                            break;
                        }
                        else
                        {
                            EnemyShootResultLabel.Text = "Düşman Iskaladı.";
                        }
                    }
                    var_mi = false;
                }
            } while (var_mi == true);
        }

        private void MidArea_Load(object sender, EventArgs e)
        {
            ShipCounterLabel.Text = "0";
            WinnerLabel.Text = "";
            KonumNumeric.Value = 1;
            PlayerShootResultLabel.Text = "";
            EnemyShootResultLabel.Text = "";
            AlanBoyutu();
        }

        public void oyuncu_vurus()
        {
            int vurulan_konum = int.Parse(KonumNumeric.Value.ToString());
            for (int i = 0; i < max_gemi; i++)
            {
                if (oyuncu2[7] == vurulan_konum)
                {
                    dusman_gemi_sayisi = 0;
                    EnemyShipCounterText.Text = dusman_gemi_sayisi.ToString();
                    PlayerShootResultLabel.Text = "Filo Komutanını Vurdunuz..";
                    break;
                }
                if (oyuncu2[i] == vurulan_konum)
                {
                    dusman_gemi_sayisi--;
                    EnemyShipCounterText.Text = dusman_gemi_sayisi.ToString();
                    PlayerShootResultLabel.Text = "Düşman Gemiyi Vurdunuz..";
                    break;
                }
                else
                {
                    PlayerShootResultLabel.Text = "Iskaladınız..";
                }
            }
        }
        public void oyuncu1_yerlestir()
        {
            secilen_konum = int.Parse(KonumNumeric.Value.ToString());
            bool yerlestir = false;
            for (int i = 0; i < oyuncu1.Length; i++)
            {
                if (oyuncu1[i] == secilen_konum)
                {
                    MessageBox.Show("Seçilen konumda gemi mevcut.");
                    yerlestir = false;
                    olumlu1 = false;
                    break;
                }
                else
                {
                    yerlestir = true;
                    olumlu1 = true;
                }
            }
            if (yerlestir == true)
            {
                oyuncu1[gemi_sayisi] = secilen_konum;
                olumlu1 = true;
            }
        }
        public void dusman_yerlestir()
        {
            bool olumlu = false;
            int random;
            do
            {
                random = rnd.Next(1, kutu);
                for (int i = 0; i < gemi_sayisi; i++)
                {
                    if (oyuncu2[i] == random)
                    {
                        olumlu = true;
                    }
                    else
                    {
                        olumlu = false;
                    }
                }
            } while (olumlu == true);
            if (olumlu == false)
            {
                oyuncu2[gemi_sayisi] = random;
                olumlu2 = true;
                gemi_sayisi++;
                dusman_gemi_sayisi++;
                ShipCounterLabel.Text = gemi_sayisi.ToString();
            }
            if (gemi_sayisi == max_gemi)
            {
                PlacingGroup.Visible = false;
                olabilir_mi = true;
            }
        }
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
