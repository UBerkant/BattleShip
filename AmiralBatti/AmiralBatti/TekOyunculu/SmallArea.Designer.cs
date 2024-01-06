namespace AmiralBatti
{
    partial class SmallArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TailsCheck = new System.Windows.Forms.CheckBox();
            this.HeadsCheck = new System.Windows.Forms.CheckBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.GameAreaTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.GameBoardGroup = new System.Windows.Forms.GroupBox();
            this.PlayerShootResultLabel = new System.Windows.Forms.Label();
            this.EnemyShootResultLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PlayerShipCounterGroup = new System.Windows.Forms.GroupBox();
            this.PlayerShipCounterText = new System.Windows.Forms.TextBox();
            this.EnemyShipCounterGroup = new System.Windows.Forms.GroupBox();
            this.EnemyShipCounterText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShipCounterLabel = new System.Windows.Forms.Label();
            this.KonumNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.GameBoardGroup.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PlayerShipCounterGroup.SuspendLayout();
            this.EnemyShipCounterGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonumNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TailsCheck);
            this.groupBox4.Controls.Add(this.HeadsCheck);
            this.groupBox4.Controls.Add(this.CoinFlipButton);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(680, 170);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(266, 235);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yazı-Tura / Coin";
            this.groupBox4.Visible = false;
            // 
            // TailsCheck
            // 
            this.TailsCheck.AutoSize = true;
            this.TailsCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TailsCheck.Location = new System.Drawing.Point(99, 115);
            this.TailsCheck.Margin = new System.Windows.Forms.Padding(4);
            this.TailsCheck.Name = "TailsCheck";
            this.TailsCheck.Size = new System.Drawing.Size(100, 22);
            this.TailsCheck.TabIndex = 2;
            this.TailsCheck.Text = "Tura / Tails";
            this.TailsCheck.UseVisualStyleBackColor = true;
            this.TailsCheck.CheckedChanged += new System.EventHandler(this.TailsCheck_CheckedChanged);
            // 
            // HeadsCheck
            // 
            this.HeadsCheck.AutoSize = true;
            this.HeadsCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeadsCheck.Location = new System.Drawing.Point(99, 61);
            this.HeadsCheck.Margin = new System.Windows.Forms.Padding(4);
            this.HeadsCheck.Name = "HeadsCheck";
            this.HeadsCheck.Size = new System.Drawing.Size(113, 22);
            this.HeadsCheck.TabIndex = 1;
            this.HeadsCheck.Text = "Yazı - Heads";
            this.HeadsCheck.UseVisualStyleBackColor = true;
            this.HeadsCheck.CheckedChanged += new System.EventHandler(this.HeadsCheck_CheckedChanged);
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(22, 152);
            this.CoinFlipButton.Margin = new System.Windows.Forms.Padding(4);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(206, 61);
            this.CoinFlipButton.TabIndex = 0;
            this.CoinFlipButton.Text = "Yazı-Tura At / Coin Flip";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WinnerLabel.Location = new System.Drawing.Point(954, 231);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(130, 18);
            this.WinnerLabel.TabIndex = 5;
            this.WinnerLabel.Text = "Kazanan / Winner";
            // 
            // GameAreaTable
            // 
            this.GameAreaTable.ColumnCount = 2;
            this.GameAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76672F));
            this.GameAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23328F));
            this.GameAreaTable.Location = new System.Drawing.Point(12, 25);
            this.GameAreaTable.Name = "GameAreaTable";
            this.GameAreaTable.RowCount = 2;
            this.GameAreaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameAreaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameAreaTable.Size = new System.Drawing.Size(643, 738);
            this.GameAreaTable.TabIndex = 10;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(679, 666);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(480, 109);
            this.MainMenuButton.TabIndex = 14;
            this.MainMenuButton.Text = "Ana Menü / Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // GameBoardGroup
            // 
            this.GameBoardGroup.BackColor = System.Drawing.SystemColors.Highlight;
            this.GameBoardGroup.Controls.Add(this.GameAreaTable);
            this.GameBoardGroup.Location = new System.Drawing.Point(12, 12);
            this.GameBoardGroup.Name = "GameBoardGroup";
            this.GameBoardGroup.Size = new System.Drawing.Size(661, 769);
            this.GameBoardGroup.TabIndex = 15;
            this.GameBoardGroup.TabStop = false;
            this.GameBoardGroup.Text = "Oyun Alanı - Game Board";
            // 
            // PlayerShootResultLabel
            // 
            this.PlayerShootResultLabel.AutoSize = true;
            this.PlayerShootResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayerShootResultLabel.Location = new System.Drawing.Point(954, 256);
            this.PlayerShootResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerShootResultLabel.Name = "PlayerShootResultLabel";
            this.PlayerShootResultLabel.Size = new System.Drawing.Size(319, 18);
            this.PlayerShootResultLabel.TabIndex = 18;
            this.PlayerShootResultLabel.Text = "Oyuncunun vuruş Sonucu / Player\'s fire Result";
            // 
            // EnemyShootResultLabel
            // 
            this.EnemyShootResultLabel.AutoSize = true;
            this.EnemyShootResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnemyShootResultLabel.Location = new System.Drawing.Point(954, 284);
            this.EnemyShootResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyShootResultLabel.Name = "EnemyShootResultLabel";
            this.EnemyShootResultLabel.Size = new System.Drawing.Size(328, 18);
            this.EnemyShootResultLabel.TabIndex = 19;
            this.EnemyShootResultLabel.Text = "Düşmanın vuruş sonucu / Opponent\'s fire result";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PlayerShipCounterGroup);
            this.groupBox5.Controls.Add(this.EnemyShipCounterGroup);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(679, 413);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(502, 161);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // PlayerShipCounterGroup
            // 
            this.PlayerShipCounterGroup.Controls.Add(this.PlayerShipCounterText);
            this.PlayerShipCounterGroup.Location = new System.Drawing.Point(7, 24);
            this.PlayerShipCounterGroup.Name = "PlayerShipCounterGroup";
            this.PlayerShipCounterGroup.Size = new System.Drawing.Size(488, 62);
            this.PlayerShipCounterGroup.TabIndex = 17;
            this.PlayerShipCounterGroup.TabStop = false;
            this.PlayerShipCounterGroup.Text = "Gemi Sayınız / Your Ship Counter";
            // 
            // PlayerShipCounterText
            // 
            this.PlayerShipCounterText.Enabled = false;
            this.PlayerShipCounterText.Location = new System.Drawing.Point(201, 30);
            this.PlayerShipCounterText.Name = "PlayerShipCounterText";
            this.PlayerShipCounterText.Size = new System.Drawing.Size(100, 26);
            this.PlayerShipCounterText.TabIndex = 0;
            // 
            // EnemyShipCounterGroup
            // 
            this.EnemyShipCounterGroup.Controls.Add(this.EnemyShipCounterText);
            this.EnemyShipCounterGroup.Location = new System.Drawing.Point(7, 92);
            this.EnemyShipCounterGroup.Name = "EnemyShipCounterGroup";
            this.EnemyShipCounterGroup.Size = new System.Drawing.Size(488, 62);
            this.EnemyShipCounterGroup.TabIndex = 16;
            this.EnemyShipCounterGroup.TabStop = false;
            this.EnemyShipCounterGroup.Text = "Düşman Gemi Sayısı / Opponents Ship Counter";
            // 
            // EnemyShipCounterText
            // 
            this.EnemyShipCounterText.Enabled = false;
            this.EnemyShipCounterText.Location = new System.Drawing.Point(201, 30);
            this.EnemyShipCounterText.Name = "EnemyShipCounterText";
            this.EnemyShipCounterText.Size = new System.Drawing.Size(100, 26);
            this.EnemyShipCounterText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ShipCounterLabel);
            this.groupBox1.Controls.Add(this.KonumNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(680, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(405, 137);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yerleştirme / Placing Phase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mevcut Gemi Sayısı";
            // 
            // ShipCounterLabel
            // 
            this.ShipCounterLabel.AutoSize = true;
            this.ShipCounterLabel.Location = new System.Drawing.Point(209, 36);
            this.ShipCounterLabel.Name = "ShipCounterLabel";
            this.ShipCounterLabel.Size = new System.Drawing.Size(194, 18);
            this.ShipCounterLabel.TabIndex = 8;
            this.ShipCounterLabel.Text = "Gemi Sayısı / Ship Counter";
            // 
            // KonumNumeric
            // 
            this.KonumNumeric.Enabled = false;
            this.KonumNumeric.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KonumNumeric.Location = new System.Drawing.Point(253, 79);
            this.KonumNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.KonumNumeric.Name = "KonumNumeric";
            this.KonumNumeric.Size = new System.Drawing.Size(144, 26);
            this.KonumNumeric.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçilen Konum / Selected Place";
            // 
            // SmallArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 801);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.EnemyShootResultLabel);
            this.Controls.Add(this.PlayerShootResultLabel);
            this.Controls.Add(this.GameBoardGroup);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmallArea";
            this.Text = "Amiral Battı / BattleShips";
            this.Load += new System.EventHandler(this.SmallArea_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GameBoardGroup.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.PlayerShipCounterGroup.ResumeLayout(false);
            this.PlayerShipCounterGroup.PerformLayout();
            this.EnemyShipCounterGroup.ResumeLayout(false);
            this.EnemyShipCounterGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonumNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox TailsCheck;
        private System.Windows.Forms.CheckBox HeadsCheck;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.TableLayoutPanel GameAreaTable;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.GroupBox GameBoardGroup;
        private System.Windows.Forms.Label PlayerShootResultLabel;
        private System.Windows.Forms.Label EnemyShootResultLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox PlayerShipCounterGroup;
        private System.Windows.Forms.TextBox PlayerShipCounterText;
        private System.Windows.Forms.GroupBox EnemyShipCounterGroup;
        private System.Windows.Forms.TextBox EnemyShipCounterText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ShipCounterLabel;
        private System.Windows.Forms.NumericUpDown KonumNumeric;
        private System.Windows.Forms.Label label1;
    }
}

