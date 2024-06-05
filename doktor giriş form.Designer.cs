
namespace Hastane_Sistemi2
{
    partial class doktor_giriş_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktor_giriş_form));
            this.btnGİRİŞ = new System.Windows.Forms.Button();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.maskTCKİMLİKNO = new System.Windows.Forms.MaskedTextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.LBLŞİFRE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGİRİŞ
            // 
            this.btnGİRİŞ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGİRİŞ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGİRİŞ.Location = new System.Drawing.Point(361, 191);
            this.btnGİRİŞ.Name = "btnGİRİŞ";
            this.btnGİRİŞ.Size = new System.Drawing.Size(121, 31);
            this.btnGİRİŞ.TabIndex = 3;
            this.btnGİRİŞ.Text = "GİRİŞ YAP";
            this.btnGİRİŞ.UseVisualStyleBackColor = false;
            this.btnGİRİŞ.Click += new System.EventHandler(this.btnGİRİŞ_Click_1);
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(349, 148);
            this.txtŞİFRE.Multiline = true;
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(147, 27);
            this.txtŞİFRE.TabIndex = 2;
            // 
            // maskTCKİMLİKNO
            // 
            this.maskTCKİMLİKNO.Location = new System.Drawing.Point(349, 98);
            this.maskTCKİMLİKNO.Mask = "00000000000";
            this.maskTCKİMLİKNO.Name = "maskTCKİMLİKNO";
            this.maskTCKİMLİKNO.Size = new System.Drawing.Size(147, 20);
            this.maskTCKİMLİKNO.TabIndex = 1;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(227, 98);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(115, 23);
            this.lblTC.TabIndex = 9;
            this.lblTC.Text = "TC KİMLİK NO";
            // 
            // LBLŞİFRE
            // 
            this.LBLŞİFRE.AutoSize = true;
            this.LBLŞİFRE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLŞİFRE.Location = new System.Drawing.Point(290, 148);
            this.LBLŞİFRE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLŞİFRE.Name = "LBLŞİFRE";
            this.LBLŞİFRE.Size = new System.Drawing.Size(52, 23);
            this.LBLŞİFRE.TabIndex = 8;
            this.LBLŞİFRE.Text = "ŞİFRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(361, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "GİRİŞ PANELİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // doktor_giriş_form
            // 
            this.AcceptButton = this.btnGİRİŞ;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(642, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGİRİŞ);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.maskTCKİMLİKNO);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.LBLŞİFRE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "doktor_giriş_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTOR GİRİŞ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGİRİŞ;
        private System.Windows.Forms.TextBox txtŞİFRE;
        private System.Windows.Forms.MaskedTextBox maskTCKİMLİKNO;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label LBLŞİFRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}