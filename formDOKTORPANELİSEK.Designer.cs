
namespace Hastane_Sistemi2
{
    partial class formDOKTORPANELİSEK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDOKTORPANELİSEK));
            this.butonGÜNCELLE = new System.Windows.Forms.Button();
            this.butonSİL = new System.Windows.Forms.Button();
            this.butonEKLE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorlar1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneyönetimDataSet6 = new Hastane_Sistemi2.hastaneyönetimDataSet6();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.lblSOYAD = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.txtŞİFRE = new System.Windows.Forms.TextBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxBRANŞ = new System.Windows.Forms.ComboBox();
            this.doktorlar1TableAdapter = new Hastane_Sistemi2.hastaneyönetimDataSet6TableAdapters.doktorlar1TableAdapter();
            this.lblDOKTORAD = new System.Windows.Forms.Label();
            this.lbldoktorsoyad = new System.Windows.Forms.Label();
            this.lblBRANŞ = new System.Windows.Forms.Label();
            this.lblDOKTORTC = new System.Windows.Forms.Label();
            this.lblDOKTORŞİFRE = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlar1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneyönetimDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // butonGÜNCELLE
            // 
            this.butonGÜNCELLE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butonGÜNCELLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonGÜNCELLE.Location = new System.Drawing.Point(289, 318);
            this.butonGÜNCELLE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butonGÜNCELLE.Name = "butonGÜNCELLE";
            this.butonGÜNCELLE.Size = new System.Drawing.Size(122, 47);
            this.butonGÜNCELLE.TabIndex = 52;
            this.butonGÜNCELLE.Text = "GÜNCELLE";
            this.butonGÜNCELLE.UseVisualStyleBackColor = false;
            this.butonGÜNCELLE.Click += new System.EventHandler(this.butonGÜNCELLE_Click);
            // 
            // butonSİL
            // 
            this.butonSİL.BackColor = System.Drawing.Color.Pink;
            this.butonSİL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonSİL.Location = new System.Drawing.Point(157, 318);
            this.butonSİL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butonSİL.Name = "butonSİL";
            this.butonSİL.Size = new System.Drawing.Size(122, 47);
            this.butonSİL.TabIndex = 51;
            this.butonSİL.Text = "SİL";
            this.butonSİL.UseVisualStyleBackColor = false;
            this.butonSİL.Click += new System.EventHandler(this.butonSİL_Click);
            // 
            // butonEKLE
            // 
            this.butonEKLE.BackColor = System.Drawing.Color.Red;
            this.butonEKLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonEKLE.Location = new System.Drawing.Point(25, 318);
            this.butonEKLE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butonEKLE.Name = "butonEKLE";
            this.butonEKLE.Size = new System.Drawing.Size(122, 47);
            this.butonEKLE.TabIndex = 50;
            this.butonEKLE.Text = "EKLE";
            this.butonEKLE.UseVisualStyleBackColor = false;
            this.butonEKLE.Click += new System.EventHandler(this.butonEKLE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 353);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // doktorlar1BindingSource
            // 
            this.doktorlar1BindingSource.DataMember = "doktorlar1";
            this.doktorlar1BindingSource.DataSource = this.hastaneyönetimDataSet6;
            // 
            // hastaneyönetimDataSet6
            // 
            this.hastaneyönetimDataSet6.DataSetName = "hastaneyönetimDataSet6";
            this.hastaneyönetimDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(163, 112);
            this.txtSOYAD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(199, 26);
            this.txtSOYAD.TabIndex = 3;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(163, 60);
            this.txtAD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(199, 26);
            this.txtAD.TabIndex = 2;
            // 
            // lblSOYAD
            // 
            this.lblSOYAD.AutoSize = true;
            this.lblSOYAD.Location = new System.Drawing.Point(97, 112);
            this.lblSOYAD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSOYAD.Name = "lblSOYAD";
            this.lblSOYAD.Size = new System.Drawing.Size(50, 18);
            this.lblSOYAD.TabIndex = 54;
            this.lblSOYAD.Tag = "S";
            this.lblSOYAD.Text = "SOYAD";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(111, 68);
            this.lblAD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(29, 18);
            this.lblAD.TabIndex = 53;
            this.lblAD.Text = "AD ";
            // 
            // txtŞİFRE
            // 
            this.txtŞİFRE.Location = new System.Drawing.Point(163, 261);
            this.txtŞİFRE.Name = "txtŞİFRE";
            this.txtŞİFRE.Size = new System.Drawing.Size(195, 26);
            this.txtŞİFRE.TabIndex = 6;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(163, 212);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(195, 26);
            this.maskedTC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "ŞİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "TC NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "BRANŞ";
            // 
            // cmbbxBRANŞ
            // 
            this.cmbbxBRANŞ.FormattingEnabled = true;
            this.cmbbxBRANŞ.Location = new System.Drawing.Point(163, 162);
            this.cmbbxBRANŞ.Name = "cmbbxBRANŞ";
            this.cmbbxBRANŞ.Size = new System.Drawing.Size(195, 26);
            this.cmbbxBRANŞ.TabIndex = 4;
            // 
            // doktorlar1TableAdapter
            // 
            this.doktorlar1TableAdapter.ClearBeforeFill = true;
            // 
            // lblDOKTORAD
            // 
            this.lblDOKTORAD.AutoSize = true;
            this.lblDOKTORAD.BackColor = System.Drawing.Color.White;
            this.lblDOKTORAD.Location = new System.Drawing.Point(571, 138);
            this.lblDOKTORAD.Name = "lblDOKTORAD";
            this.lblDOKTORAD.Size = new System.Drawing.Size(0, 18);
            this.lblDOKTORAD.TabIndex = 64;
            // 
            // lbldoktorsoyad
            // 
            this.lbldoktorsoyad.AutoSize = true;
            this.lbldoktorsoyad.BackColor = System.Drawing.Color.White;
            this.lbldoktorsoyad.Location = new System.Drawing.Point(687, 138);
            this.lbldoktorsoyad.Name = "lbldoktorsoyad";
            this.lbldoktorsoyad.Size = new System.Drawing.Size(0, 18);
            this.lbldoktorsoyad.TabIndex = 65;
            // 
            // lblBRANŞ
            // 
            this.lblBRANŞ.AutoSize = true;
            this.lblBRANŞ.BackColor = System.Drawing.Color.White;
            this.lblBRANŞ.Location = new System.Drawing.Point(787, 138);
            this.lblBRANŞ.Name = "lblBRANŞ";
            this.lblBRANŞ.Size = new System.Drawing.Size(0, 18);
            this.lblBRANŞ.TabIndex = 66;
            // 
            // lblDOKTORTC
            // 
            this.lblDOKTORTC.AutoSize = true;
            this.lblDOKTORTC.BackColor = System.Drawing.Color.White;
            this.lblDOKTORTC.Location = new System.Drawing.Point(884, 138);
            this.lblDOKTORTC.Name = "lblDOKTORTC";
            this.lblDOKTORTC.Size = new System.Drawing.Size(0, 18);
            this.lblDOKTORTC.TabIndex = 67;
            // 
            // lblDOKTORŞİFRE
            // 
            this.lblDOKTORŞİFRE.AutoSize = true;
            this.lblDOKTORŞİFRE.BackColor = System.Drawing.Color.White;
            this.lblDOKTORŞİFRE.Location = new System.Drawing.Point(984, 138);
            this.lblDOKTORŞİFRE.Name = "lblDOKTORŞİFRE";
            this.lblDOKTORŞİFRE.Size = new System.Drawing.Size(0, 18);
            this.lblDOKTORŞİFRE.TabIndex = 68;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(163, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 26);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID";
            // 
            // formDOKTORPANELİSEK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1153, 387);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDOKTORŞİFRE);
            this.Controls.Add(this.lblDOKTORTC);
            this.Controls.Add(this.lblBRANŞ);
            this.Controls.Add(this.lbldoktorsoyad);
            this.Controls.Add(this.lblDOKTORAD);
            this.Controls.Add(this.txtŞİFRE);
            this.Controls.Add(this.maskedTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxBRANŞ);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.lblSOYAD);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.butonGÜNCELLE);
            this.Controls.Add(this.butonSİL);
            this.Controls.Add(this.butonEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formDOKTORPANELİSEK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTOR İŞLEMLERİ";
            this.Load += new System.EventHandler(this.formDOKTORPANELİSEK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlar1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneyönetimDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonGÜNCELLE;
        private System.Windows.Forms.Button butonSİL;
        private System.Windows.Forms.Button butonEKLE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label lblSOYAD;
        public System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.TextBox txtŞİFRE;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxBRANŞ;
        private hastaneyönetimDataSet6 hastaneyönetimDataSet6;
        private System.Windows.Forms.BindingSource doktorlar1BindingSource;
        private hastaneyönetimDataSet6TableAdapters.doktorlar1TableAdapter doktorlar1TableAdapter;
        public System.Windows.Forms.Label lblDOKTORAD;
        public System.Windows.Forms.Label lbldoktorsoyad;
        public System.Windows.Forms.Label lblBRANŞ;
        public System.Windows.Forms.Label lblDOKTORTC;
        public System.Windows.Forms.Label lblDOKTORŞİFRE;
        private System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label label2;
    }
}