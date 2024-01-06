namespace AmiralBatti
{
    partial class MainMenu
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
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.MultiPlayerButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SmallAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.MidAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.LargeAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.Location = new System.Drawing.Point(250, 50);
            this.SinglePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(401, 66);
            this.SinglePlayerButton.TabIndex = 0;
            this.SinglePlayerButton.Text = "Bilgisayara Karşı / Single Player";
            this.SinglePlayerButton.UseVisualStyleBackColor = true;
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // MultiPlayerButton
            // 
            this.MultiPlayerButton.Location = new System.Drawing.Point(300, 251);
            this.MultiPlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiPlayerButton.Name = "MultiPlayerButton";
            this.MultiPlayerButton.Size = new System.Drawing.Size(401, 66);
            this.MultiPlayerButton.TabIndex = 2;
            this.MultiPlayerButton.Text = "İki Oyunculu / Multi Player";
            this.MultiPlayerButton.UseVisualStyleBackColor = true;
            this.MultiPlayerButton.Click += new System.EventHandler(this.MultiPlayerButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(300, 388);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(401, 66);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Çıkış / Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(392, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amiral Battı";
            // 
            // SmallAreaCheckBox
            // 
            this.SmallAreaCheckBox.AutoSize = true;
            this.SmallAreaCheckBox.Location = new System.Drawing.Point(6, 36);
            this.SmallAreaCheckBox.Name = "SmallAreaCheckBox";
            this.SmallAreaCheckBox.Size = new System.Drawing.Size(149, 22);
            this.SmallAreaCheckBox.TabIndex = 7;
            this.SmallAreaCheckBox.Text = "3x3 Alan / 2 Gemi";
            this.SmallAreaCheckBox.UseVisualStyleBackColor = true;
            this.SmallAreaCheckBox.CheckedChanged += new System.EventHandler(this.SmallAreaCheckBox_CheckedChanged);
            // 
            // MidAreaCheckBox
            // 
            this.MidAreaCheckBox.AutoSize = true;
            this.MidAreaCheckBox.Location = new System.Drawing.Point(6, 64);
            this.MidAreaCheckBox.Name = "MidAreaCheckBox";
            this.MidAreaCheckBox.Size = new System.Drawing.Size(149, 22);
            this.MidAreaCheckBox.TabIndex = 8;
            this.MidAreaCheckBox.Text = "6x6 Alan / 8 Gemi";
            this.MidAreaCheckBox.UseVisualStyleBackColor = true;
            this.MidAreaCheckBox.CheckedChanged += new System.EventHandler(this.MidAreaCheckBox_CheckedChanged);
            // 
            // LargeAreaCheckBox
            // 
            this.LargeAreaCheckBox.AutoSize = true;
            this.LargeAreaCheckBox.Location = new System.Drawing.Point(6, 92);
            this.LargeAreaCheckBox.Name = "LargeAreaCheckBox";
            this.LargeAreaCheckBox.Size = new System.Drawing.Size(176, 22);
            this.LargeAreaCheckBox.TabIndex = 9;
            this.LargeAreaCheckBox.Text = "10x10 Alan / 24 Gemi";
            this.LargeAreaCheckBox.UseVisualStyleBackColor = true;
            this.LargeAreaCheckBox.CheckedChanged += new System.EventHandler(this.LargeAreaCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MidAreaCheckBox);
            this.groupBox1.Controls.Add(this.LargeAreaCheckBox);
            this.groupBox1.Controls.Add(this.SmallAreaCheckBox);
            this.groupBox1.Controls.Add(this.SinglePlayerButton);
            this.groupBox1.Location = new System.Drawing.Point(50, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alan Boyutu / Gemi Sayısı";
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MultiPlayerButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaMenü";
            this.Text = "AnaMenü / Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayerButton;
        private System.Windows.Forms.Button MultiPlayerButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SmallAreaCheckBox;
        private System.Windows.Forms.CheckBox MidAreaCheckBox;
        private System.Windows.Forms.CheckBox LargeAreaCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}