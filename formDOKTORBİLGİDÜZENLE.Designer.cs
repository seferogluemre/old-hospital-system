
namespace Hastane_Sistemi2
{
    partial class formDOKTORBİLGİDÜZENLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDOKTORBİLGİDÜZENLE));
            this.btnGÜNCELLE = new System.Windows.Forms.Button();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.cmbBranş = new System.Windows.Forms.ComboBox();
            this.lblbranş = new System.Windows.Forms.Label();
            this.lblŞİFRE = new System.Windows.Forms.Label();
            this.lblTCKİMLİK = new System.Windows.Forms.Label();
            this.lblSOYAD = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGÜNCELLE
            // 
            this.btnGÜNCELLE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGÜNCELLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGÜNCELLE.Location = new System.Drawing.Point(210, 290);
            this.btnGÜNCELLE.Margin = new System.Windows.Forms.Padding(4);
            this.btnGÜNCELLE.Name = "btnGÜNCELLE";
            this.btnGÜNCELLE.Size = new System.Drawing.Size(136, 44);
            this.btnGÜNCELLE.TabIndex = 24;
            this.btnGÜNCELLE.Text = "GÜNCELLE";
            this.btnGÜNCELLE.UseVisualStyleBackColor = false;
            this.btnGÜNCELLE.Click += new System.EventHandler(this.btnGÜNCELLE_Click);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(188, 143);
            this.mskTC.Margin = new System.Windows.Forms.Padding(4);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(199, 27);
            this.mskTC.TabIndex = 22;
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(188, 254);
            this.txtŞİFRE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtŞİFRE.Multiline = true;
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(199, 22);
            this.txtŞİFRE.TabIndex = 21;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(188, 86);
            this.txtSOYAD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(199, 27);
            this.txtSOYAD.TabIndex = 20;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(188, 31);
            this.txtAD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(199, 27);
            this.txtAD.TabIndex = 19;
            // 
            // cmbBranş
            // 
            this.cmbBranş.FormattingEnabled = true;
            this.cmbBranş.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmbBranş.Location = new System.Drawing.Point(188, 193);
            this.cmbBranş.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbBranş.Name = "cmbBranş";
            this.cmbBranş.Size = new System.Drawing.Size(199, 27);
            this.cmbBranş.TabIndex = 18;
            // 
            // lblbranş
            // 
            this.lblbranş.AutoSize = true;
            this.lblbranş.Location = new System.Drawing.Point(121, 201);
            this.lblbranş.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblbranş.Name = "lblbranş";
            this.lblbranş.Size = new System.Drawing.Size(55, 19);
            this.lblbranş.TabIndex = 17;
            this.lblbranş.Text = "BRANŞ";
            // 
            // lblŞİFRE
            // 
            this.lblŞİFRE.AutoSize = true;
            this.lblŞİFRE.Location = new System.Drawing.Point(125, 257);
            this.lblŞİFRE.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblŞİFRE.Name = "lblŞİFRE";
            this.lblŞİFRE.Size = new System.Drawing.Size(44, 19);
            this.lblŞİFRE.TabIndex = 16;
            this.lblŞİFRE.Text = "ŞİFRE";
            // 
            // lblTCKİMLİK
            // 
            this.lblTCKİMLİK.AutoSize = true;
            this.lblTCKİMLİK.Location = new System.Drawing.Point(74, 146);
            this.lblTCKİMLİK.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTCKİMLİK.Name = "lblTCKİMLİK";
            this.lblTCKİMLİK.Size = new System.Drawing.Size(102, 19);
            this.lblTCKİMLİK.TabIndex = 13;
            this.lblTCKİMLİK.Text = "TC KİMLİK NO";
            // 
            // lblSOYAD
            // 
            this.lblSOYAD.AutoSize = true;
            this.lblSOYAD.Location = new System.Drawing.Point(122, 89);
            this.lblSOYAD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSOYAD.Name = "lblSOYAD";
            this.lblSOYAD.Size = new System.Drawing.Size(54, 19);
            this.lblSOYAD.TabIndex = 14;
            this.lblSOYAD.Tag = "S";
            this.lblSOYAD.Text = "SOYAD";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(136, 34);
            this.lblAD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(33, 19);
            this.lblAD.TabIndex = 12;
            this.lblAD.Text = "AD ";
            // 
            // formDOKTORBİLGİDÜZENLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 367);
            this.Controls.Add(this.btnGÜNCELLE);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.cmbBranş);
            this.Controls.Add(this.lblbranş);
            this.Controls.Add(this.lblŞİFRE);
            this.Controls.Add(this.lblTCKİMLİK);
            this.Controls.Add(this.lblSOYAD);
            this.Controls.Add(this.lblAD);
            this.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formDOKTORBİLGİDÜZENLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTORBİLGİDÜZENLE";
            this.Load += new System.EventHandler(this.formDOKTORBİLGİDÜZENLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGÜNCELLE;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtŞİFRE;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.ComboBox cmbBranş;
        private System.Windows.Forms.Label lblbranş;
        private System.Windows.Forms.Label lblŞİFRE;
        private System.Windows.Forms.Label lblTCKİMLİK;
        private System.Windows.Forms.Label lblSOYAD;
        public System.Windows.Forms.Label lblAD;
    }
}