namespace WinFormKOS
{
    partial class FormEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltreleOkuyucu = new System.Windows.Forms.TextBox();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblGecikmeBedeli = new System.Windows.Forms.Label();
            this.pictureProfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiltreleKitap = new System.Windows.Forms.TextBox();
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKayitNo = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmanetEt = new System.Windows.Forms.Button();
            this.btnSureUzat = new System.Windows.Forms.Button();
            this.btnDusumYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltreleOkuyucu);
            this.groupBox1.Controls.Add(this.dgOkuyucular);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okuyucu Seç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Filtrele:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFiltreleOkuyucu
            // 
            this.txtFiltreleOkuyucu.Location = new System.Drawing.Point(646, 162);
            this.txtFiltreleOkuyucu.Name = "txtFiltreleOkuyucu";
            this.txtFiltreleOkuyucu.Size = new System.Drawing.Size(152, 20);
            this.txtFiltreleOkuyucu.TabIndex = 2;
            this.txtFiltreleOkuyucu.TextChanged += new System.EventHandler(this.txtFiltreleOkuyucu_TextChanged);
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToDeleteRows = false;
            this.dgOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.Location = new System.Drawing.Point(286, 19);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersVisible = false;
            this.dgOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucular.Size = new System.Drawing.Size(513, 137);
            this.dgOkuyucular.TabIndex = 1;
            this.dgOkuyucular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOkuyucular_CellClick);
            this.dgOkuyucular.Click += new System.EventHandler(this.dgOkuyucular_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureProfil, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblAdSoyad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSinif, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOkulNo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGecikmeBedeli, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 104);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 6);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSinif
            // 
            this.lblSinif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(3, 32);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(27, 13);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(3, 58);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(46, 13);
            this.lblOkulNo.TabIndex = 2;
            this.lblOkulNo.Text = "Okul No";
            // 
            // lblGecikmeBedeli
            // 
            this.lblGecikmeBedeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGecikmeBedeli.AutoSize = true;
            this.lblGecikmeBedeli.Location = new System.Drawing.Point(3, 84);
            this.lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            this.lblGecikmeBedeli.Size = new System.Drawing.Size(81, 13);
            this.lblGecikmeBedeli.TabIndex = 3;
            this.lblGecikmeBedeli.Text = "Gecikme Bedeli";
            // 
            // pictureProfil
            // 
            this.pictureProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfil.Image")));
            this.pictureProfil.Location = new System.Drawing.Point(3, 3);
            this.pictureProfil.Name = "pictureProfil";
            this.pictureProfil.Size = new System.Drawing.Size(74, 104);
            this.pictureProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfil.TabIndex = 1;
            this.pictureProfil.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFiltreleKitap);
            this.groupBox2.Controls.Add(this.dgKitaplar);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Filtrele:";
            // 
            // txtFiltreleKitap
            // 
            this.txtFiltreleKitap.Location = new System.Drawing.Point(646, 162);
            this.txtFiltreleKitap.Name = "txtFiltreleKitap";
            this.txtFiltreleKitap.Size = new System.Drawing.Size(152, 20);
            this.txtFiltreleKitap.TabIndex = 4;
            this.txtFiltreleKitap.TextChanged += new System.EventHandler(this.txtFiltreleKitap_TextChanged);
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AllowUserToAddRows = false;
            this.dgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Location = new System.Drawing.Point(277, 19);
            this.dgKitaplar.MultiSelect = false;
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.ReadOnly = true;
            this.dgKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKitaplar.Size = new System.Drawing.Size(521, 137);
            this.dgKitaplar.TabIndex = 2;
            this.dgKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKitaplar_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblKayitNo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKitapAdi, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblYazarAdi, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 110);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblKayitNo
            // 
            this.lblKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKayitNo.AutoSize = true;
            this.lblKayitNo.Location = new System.Drawing.Point(3, 11);
            this.lblKayitNo.Name = "lblKayitNo";
            this.lblKayitNo.Size = new System.Drawing.Size(47, 13);
            this.lblKayitNo.TabIndex = 0;
            this.lblKayitNo.Text = "Kayıt No";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(3, 47);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(57, 13);
            this.lblKitapAdi.TabIndex = 1;
            this.lblKitapAdi.Text = "Kitabın Adı";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(3, 84);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(52, 13);
            this.lblYazarAdi.TabIndex = 2;
            this.lblYazarAdi.Text = "Yazar Adı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "...";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "...";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEmanetEt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSureUzat, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDusumYap, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(572, 419);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnEmanetEt
            // 
            this.btnEmanetEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmanetEt.Location = new System.Drawing.Point(3, 3);
            this.btnEmanetEt.Name = "btnEmanetEt";
            this.btnEmanetEt.Size = new System.Drawing.Size(77, 24);
            this.btnEmanetEt.TabIndex = 0;
            this.btnEmanetEt.Text = "Emanet Et";
            this.btnEmanetEt.UseVisualStyleBackColor = true;
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSureUzat.Location = new System.Drawing.Point(86, 3);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(77, 24);
            this.btnSureUzat.TabIndex = 1;
            this.btnSureUzat.Text = "Süre Uzat";
            this.btnSureUzat.UseVisualStyleBackColor = true;
            // 
            // btnDusumYap
            // 
            this.btnDusumYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDusumYap.Location = new System.Drawing.Point(169, 3);
            this.btnDusumYap.Name = "btnDusumYap";
            this.btnDusumYap.Size = new System.Drawing.Size(78, 24);
            this.btnDusumYap.TabIndex = 2;
            this.btnDusumYap.Text = "Düşüm Yap";
            this.btnDusumYap.UseVisualStyleBackColor = true;
            // 
            // FormEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.FormEmanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltreleOkuyucu;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblGecikmeBedeli;
        private System.Windows.Forms.PictureBox pictureProfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltreleKitap;
        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblKayitNo;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEmanetEt;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Button btnDusumYap;
    }
}