using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiralBatti
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int secilen_konum;
        bool turn, olabilir_mi = false, olumlu1, olumlu2, zar = true;
        int gemi_sayisi = 0, kutu = 0, boyut = 10, dusman_gemi_sayisi = 0, max_gemi=24;
        int[] oyuncu1 = new int[24];
        int[] oyuncu2 = new int[24];
        List<int> vuran_konum = new List<int>();
        Random rnd = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkBox3.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Yazı-Tura dan birisini seçiniz.");
            }
            else
            {
                int para = rnd.Next(0, 2);
                if (para == 0)
                {
                    if (checkBox2.Checked)
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
                    if (checkBox3.Checked)
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
                groupBox4.Visible = false;
                zar = false;
                label4.Text = "";
            }
        }
        public void AlanBoyutu()
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
                    cmd.BackColor = Color.Cyan;
                    cmd.Dock = DockStyle.Fill;
                    kutu++;
                    cmd.Name = kutu.ToString();
                    cmd.Click += new EventHandler(yazdir);
                    tableLayoutPanel1.Controls.Add(cmd, x, i);
                    cmd.Text = "E";
                }
            }
        }
        public void yazdir(object sender, EventArgs e)
        {
            Button dButton = new Button();
            dButton = sender as Button;
            numericUpDown1.Value = int.Parse(dButton.Name);
            if (olabilir_mi == false)
            {
                oyuncu1_yerlestir();                
                dButton.Text = "";
                dButton.BackgroundImageLayout=ImageLayout.Stretch;
                dButton.BackgroundImage = AmiralBatti.Properties.Resources.WarShip;
                if (olumlu1 == true)
                {
                    dusman_yerlestir();
                    if (olumlu2 == true)
                    {
                        textBox3.Text = dusman_gemi_sayisi.ToString();
                        textBox4.Text = gemi_sayisi.ToString();
                    }
                }
                if (gemi_sayisi == max_gemi)
                {
                    groupBox4.Visible = true;
                    label4.Text = "Sıra belirleyebilmek için zar atınız.";
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
                            label4.Text = "Oyunu Kazandınız.";
                            groupBox2.Enabled = false;
                        }
                        else
                        {
                            dusman_vurus();
                            if (gemi_sayisi == 0)
                            {
                                label4.Text = "Oyunu Kaybettiniz...";
                                groupBox2.Enabled = false;
                            }
                        }
                    }
                    if (turn == false)
                    {
                        dusman_vurus();
                        if (gemi_sayisi == 0)
                        {
                            label4.Text = "Oyunu Kaybettiniz...";
                            groupBox2.Enabled = false;
                        }
                        else
                        {
                            oyuncu_vurus();
                            if (dusman_gemi_sayisi == 0)
                            {
                                label4.Text = "Oyunu Kazandınız.";
                                groupBox2.Enabled = false;
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
                            textBox4.Text = gemi_sayisi.ToString();
                            label6.Text = "Geminiz Vuruldu.";
                            vuran_konum.Add(random);
                            break;
                        }
                        if (oyuncu1[max_gemi-1] == random)
                        {
                            gemi_sayisi = 0;
                            textBox4.Text = gemi_sayisi.ToString();
                            label6.Text = "Filo Komutanınız Vuruldu..";
                            break;
                        }
                        else
                        {
                            label6.Text = "Düşman Iskaladı.";
                        }
                    }
                    var_mi = false;
                }
            } while (var_mi == true);
        }


        public void oyuncu_vurus()
        {
            int vurulan_konum = int.Parse(numericUpDown1.Value.ToString());
            for (int i = 0; i < max_gemi; i++)
            {
                if (oyuncu2[max_gemi-1] == vurulan_konum)
                {
                    dusman_gemi_sayisi = 0;
                    textBox3.Text = dusman_gemi_sayisi.ToString();
                    label5.Text = "Filo Komutanını Vurdunuz..";
                    break;
                }
                if (oyuncu2[i] == vurulan_konum)
                {
                    dusman_gemi_sayisi--;
                    textBox3.Text = dusman_gemi_sayisi.ToString();
                    label5.Text = "Düşman Gemiyi Vurdunuz..";
                    break;
                }
                else
                {
                    label5.Text = "Iskaladınız..";
                }
            }
        }
        public void oyuncu1_yerlestir()
        {
            secilen_konum = int.Parse(numericUpDown1.Value.ToString());
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
                label7.Text = gemi_sayisi.ToString();
            }
            if (gemi_sayisi == max_gemi)
            {
                groupBox1.Visible = false;
                olabilir_mi = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = "0";
            label4.Text = "";
            numericUpDown1.Value = 1;
            label5.Text = "";
            label6.Text = "";
            AlanBoyutu();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Enabled = false;
            }
            else if (!checkBox2.Checked)
            {
                checkBox3.Enabled = true;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
            }
            else if (!checkBox3.Checked)
            {
                checkBox2.Enabled = true;
            }
        }
    }
}
