
namespace Hastane_Sistemi2
{
    partial class hasta_giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hasta_giriş));
            this.label1 = new System.Windows.Forms.Label();
            this.LBLŞİFRE = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.linkÜYEOL = new System.Windows.Forms.LinkLabel();
            this.maskTCKİMLİKNO = new System.Windows.Forms.MaskedTextBox();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.btnGİRİŞ = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // LBLŞİFRE
            // 
            this.LBLŞİFRE.AutoSize = true;
            this.LBLŞİFRE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLŞİFRE.Location = new System.Drawing.Point(283, 162);
            this.LBLŞİFRE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLŞİFRE.Name = "LBLŞİFRE";
            this.LBLŞİFRE.Size = new System.Drawing.Size(52, 23);
            this.LBLŞİFRE.TabIndex = 1;
            this.LBLŞİFRE.Text = "ŞİFRE";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(220, 107);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(115, 23);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "TC KİMLİK NO";
            // 
            // linkÜYEOL
            // 
            this.linkÜYEOL.AutoSize = true;
            this.linkÜYEOL.Location = new System.Drawing.Point(247, 268);
            this.linkÜYEOL.Name = "linkÜYEOL";
            this.linkÜYEOL.Size = new System.Drawing.Size(276, 19);
            this.linkÜYEOL.TabIndex = 4;
            this.linkÜYEOL.TabStop = true;
            this.linkÜYEOL.Text = "HASTANEMİZE ÜYE OLMAK İSTERMİSİNİZ";
            this.linkÜYEOL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkÜYEOL_LinkClicked);
            // 
            // maskTCKİMLİKNO
            // 
            this.maskTCKİMLİKNO.Location = new System.Drawing.Point(342, 103);
            this.maskTCKİMLİKNO.Mask = "00000000000";
            this.maskTCKİMLİKNO.Name = "maskTCKİMLİKNO";
            this.maskTCKİMLİKNO.Size = new System.Drawing.Size(123, 27);
            this.maskTCKİMLİKNO.TabIndex = 1;
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(343, 162);
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(123, 27);
            this.txtŞİFRE.TabIndex = 2;
            this.txtŞİFRE.TextChanged += new System.EventHandler(this.txtŞİFRE_TextChanged);
            // 
            // btnGİRİŞ
            // 
            this.btnGİRİŞ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGİRİŞ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGİRİŞ.Location = new System.Drawing.Point(343, 211);
            this.btnGİRİŞ.Name = "btnGİRİŞ";
            this.btnGİRİŞ.Size = new System.Drawing.Size(104, 31);
            this.btnGİRİŞ.TabIndex = 3;
            this.btnGİRİŞ.Text = "GİRİŞ YAP";
            this.btnGİRİŞ.UseVisualStyleBackColor = false;
            this.btnGİRİŞ.Click += new System.EventHandler(this.btnGİRİŞ_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(482, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // hasta_giriş
            // 
            this.AcceptButton = this.btnGİRİŞ;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGİRİŞ);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.maskTCKİMLİKNO);
            this.Controls.Add(this.linkÜYEOL);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.LBLŞİFRE);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "hasta_giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA GİRİŞ";
            this.Load += new System.EventHandler(this.hasta_giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLŞİFRE;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.LinkLabel linkÜYEOL;
        private System.Windows.Forms.Button btnGİRİŞ;
        public System.Windows.Forms.MaskedTextBox maskTCKİMLİKNO;
        public System.Windows.Forms.TextBox txtŞİFRE;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}