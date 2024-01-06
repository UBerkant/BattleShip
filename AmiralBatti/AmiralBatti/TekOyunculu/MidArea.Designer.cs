namespace AmiralBatti
{
    partial class MidArea
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
            this.PlacingGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShipCounterLabel = new System.Windows.Forms.Label();
            this.KonumNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CounterGroup = new System.Windows.Forms.GroupBox();
            this.PlayerShipCounter = new System.Windows.Forms.GroupBox();
            this.PlayerShipCounterText = new System.Windows.Forms.TextBox();
            this.EnemyShipCounter = new System.Windows.Forms.GroupBox();
            this.EnemyShipCounterText = new System.Windows.Forms.TextBox();
            this.EnemyShootResultLabel = new System.Windows.Forms.Label();
            this.PlayerShootResultLabel = new System.Windows.Forms.Label();
            this.GameBoardGroup = new System.Windows.Forms.GroupBox();
            this.GameAreaTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.CoinFlipGroup = new System.Windows.Forms.GroupBox();
            this.TailsCheck = new System.Windows.Forms.CheckBox();
            this.HeadsCheck = new System.Windows.Forms.CheckBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.PlacingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonumNumeric)).BeginInit();
            this.CounterGroup.SuspendLayout();
            this.PlayerShipCounter.SuspendLayout();
            this.EnemyShipCounter.SuspendLayout();
            this.GameBoardGroup.SuspendLayout();
            this.CoinFlipGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlacingGroup
            // 
            this.PlacingGroup.Controls.Add(this.label8);
            this.PlacingGroup.Controls.Add(this.ShipCounterLabel);
            this.PlacingGroup.Controls.Add(this.KonumNumeric);
            this.PlacingGroup.Controls.Add(this.label1);
            this.PlacingGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlacingGroup.Location = new System.Drawing.Point(680, 25);
            this.PlacingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.PlacingGroup.Name = "PlacingGroup";
            this.PlacingGroup.Padding = new System.Windows.Forms.Padding(4);
            this.PlacingGroup.Size = new System.Drawing.Size(405, 137);
            this.PlacingGroup.TabIndex = 39;
            this.PlacingGroup.TabStop = false;
            this.PlacingGroup.Text = "Yerleştirme / Placing Phase";
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
            // CounterGroup
            // 
            this.CounterGroup.Controls.Add(this.PlayerShipCounter);
            this.CounterGroup.Controls.Add(this.EnemyShipCounter);
            this.CounterGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CounterGroup.Location = new System.Drawing.Point(679, 413);
            this.CounterGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CounterGroup.Name = "CounterGroup";
            this.CounterGroup.Padding = new System.Windows.Forms.Padding(4);
            this.CounterGroup.Size = new System.Drawing.Size(502, 161);
            this.CounterGroup.TabIndex = 38;
            this.CounterGroup.TabStop = false;
            // 
            // PlayerShipCounter
            // 
            this.PlayerShipCounter.Controls.Add(this.PlayerShipCounterText);
            this.PlayerShipCounter.Location = new System.Drawing.Point(7, 24);
            this.PlayerShipCounter.Name = "PlayerShipCounter";
            this.PlayerShipCounter.Size = new System.Drawing.Size(488, 62);
            this.PlayerShipCounter.TabIndex = 17;
            this.PlayerShipCounter.TabStop = false;
            this.PlayerShipCounter.Text = "Gemi Sayınız / Your Ship Counter";
            // 
            // PlayerShipCounterText
            // 
            this.PlayerShipCounterText.Enabled = false;
            this.PlayerShipCounterText.Location = new System.Drawing.Point(201, 30);
            this.PlayerShipCounterText.Name = "PlayerShipCounterText";
            this.PlayerShipCounterText.Size = new System.Drawing.Size(100, 26);
            this.PlayerShipCounterText.TabIndex = 0;
            // 
            // EnemyShipCounter
            // 
            this.EnemyShipCounter.Controls.Add(this.EnemyShipCounterText);
            this.EnemyShipCounter.Location = new System.Drawing.Point(7, 92);
            this.EnemyShipCounter.Name = "EnemyShipCounter";
            this.EnemyShipCounter.Size = new System.Drawing.Size(488, 62);
            this.EnemyShipCounter.TabIndex = 16;
            this.EnemyShipCounter.TabStop = false;
            this.EnemyShipCounter.Text = "Düşman Gemi Sayısı / Opponents Ship Counter";
            // 
            // EnemyShipCounterText
            // 
            this.EnemyShipCounterText.Enabled = false;
            this.EnemyShipCounterText.Location = new System.Drawing.Point(201, 30);
            this.EnemyShipCounterText.Name = "EnemyShipCounterText";
            this.EnemyShipCounterText.Size = new System.Drawing.Size(100, 26);
            this.EnemyShipCounterText.TabIndex = 0;
            // 
            // EnemyShootResultLabel
            // 
            this.EnemyShootResultLabel.AutoSize = true;
            this.EnemyShootResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnemyShootResultLabel.Location = new System.Drawing.Point(954, 284);
            this.EnemyShootResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyShootResultLabel.Name = "EnemyShootResultLabel";
            this.EnemyShootResultLabel.Size = new System.Drawing.Size(328, 18);
            this.EnemyShootResultLabel.TabIndex = 37;
            this.EnemyShootResultLabel.Text = "Düşmanın vuruş sonucu / Opponent\'s fire result";
            // 
            // PlayerShootResultLabel
            // 
            this.PlayerShootResultLabel.AutoSize = true;
            this.PlayerShootResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayerShootResultLabel.Location = new System.Drawing.Point(954, 256);
            this.PlayerShootResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerShootResultLabel.Name = "PlayerShootResultLabel";
            this.PlayerShootResultLabel.Size = new System.Drawing.Size(319, 18);
            this.PlayerShootResultLabel.TabIndex = 36;
            this.PlayerShootResultLabel.Text = "Oyuncunun vuruş Sonucu / Player\'s fire Result";
            // 
            // GameBoardGroup
            // 
            this.GameBoardGroup.BackColor = System.Drawing.SystemColors.Highlight;
            this.GameBoardGroup.Controls.Add(this.GameAreaTable);
            this.GameBoardGroup.Location = new System.Drawing.Point(12, 12);
            this.GameBoardGroup.Name = "GameBoardGroup";
            this.GameBoardGroup.Size = new System.Drawing.Size(661, 769);
            this.GameBoardGroup.TabIndex = 35;
            this.GameBoardGroup.TabStop = false;
            this.GameBoardGroup.Text = "Oyun Alanı - Game Board";
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
            this.MainMenuButton.TabIndex = 34;
            this.MainMenuButton.Text = "Ana Menü / Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WinnerLabel.Location = new System.Drawing.Point(954, 231);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(130, 18);
            this.WinnerLabel.TabIndex = 32;
            this.WinnerLabel.Text = "Kazanan / Winner";
            // 
            // CoinFlipGroup
            // 
            this.CoinFlipGroup.Controls.Add(this.TailsCheck);
            this.CoinFlipGroup.Controls.Add(this.HeadsCheck);
            this.CoinFlipGroup.Controls.Add(this.CoinFlipButton);
            this.CoinFlipGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CoinFlipGroup.Location = new System.Drawing.Point(680, 170);
            this.CoinFlipGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CoinFlipGroup.Name = "CoinFlipGroup";
            this.CoinFlipGroup.Padding = new System.Windows.Forms.Padding(4);
            this.CoinFlipGroup.Size = new System.Drawing.Size(266, 235);
            this.CoinFlipGroup.TabIndex = 33;
            this.CoinFlipGroup.TabStop = false;
            this.CoinFlipGroup.Text = "Yazı-Tura / Coin";
            this.CoinFlipGroup.Visible = false;
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
            // MidArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 801);
            this.Controls.Add(this.PlacingGroup);
            this.Controls.Add(this.CounterGroup);
            this.Controls.Add(this.EnemyShootResultLabel);
            this.Controls.Add(this.PlayerShootResultLabel);
            this.Controls.Add(this.GameBoardGroup);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.CoinFlipGroup);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MidArea";
            this.Text = "Amiral Battı / BattleShips";
            this.Load += new System.EventHandler(this.MidArea_Load);
            this.PlacingGroup.ResumeLayout(false);
            this.PlacingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonumNumeric)).EndInit();
            this.CounterGroup.ResumeLayout(false);
            this.PlayerShipCounter.ResumeLayout(false);
            this.PlayerShipCounter.PerformLayout();
            this.EnemyShipCounter.ResumeLayout(false);
            this.EnemyShipCounter.PerformLayout();
            this.GameBoardGroup.ResumeLayout(false);
            this.CoinFlipGroup.ResumeLayout(false);
            this.CoinFlipGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PlacingGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ShipCounterLabel;
        private System.Windows.Forms.NumericUpDown KonumNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CounterGroup;
        private System.Windows.Forms.GroupBox PlayerShipCounter;
        private System.Windows.Forms.TextBox PlayerShipCounterText;
        private System.Windows.Forms.GroupBox EnemyShipCounter;
        private System.Windows.Forms.TextBox EnemyShipCounterText;
        private System.Windows.Forms.Label EnemyShootResultLabel;
        private System.Windows.Forms.Label PlayerShootResultLabel;
        private System.Windows.Forms.GroupBox GameBoardGroup;
        private System.Windows.Forms.TableLayoutPanel GameAreaTable;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.GroupBox CoinFlipGroup;
        private System.Windows.Forms.CheckBox TailsCheck;
        private System.Windows.Forms.CheckBox HeadsCheck;
        private System.Windows.Forms.Button CoinFlipButton;
    }
}