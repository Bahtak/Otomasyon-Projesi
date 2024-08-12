namespace satışotomasyonu
{
    partial class AuthorizedMainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_kategoriler = new System.Windows.Forms.GroupBox();
            this.groupBox_alaşımkategorileri = new System.Windows.Forms.GroupBox();
            this.button_lehim = new System.Windows.Forms.Button();
            this.button_pirinç = new System.Windows.Forms.Button();
            this.button_tunç = new System.Windows.Forms.Button();
            this.groupBox_vidakategorileri = new System.Windows.Forms.GroupBox();
            this.button_yuvarlakvida = new System.Windows.Forms.Button();
            this.button_testerevida = new System.Windows.Forms.Button();
            this.button_karevida = new System.Windows.Forms.Button();
            this.button_trapezvida = new System.Windows.Forms.Button();
            this.button_üçgenvida = new System.Windows.Forms.Button();
            this.groupBox_metalkategorileri = new System.Windows.Forms.GroupBox();
            this.button_karedoludemirler = new System.Windows.Forms.Button();
            this.button_inşaatdemirleri = new System.Windows.Forms.Button();
            this.button_tprofildemirleri = new System.Windows.Forms.Button();
            this.button_lamademirleri = new System.Windows.Forms.Button();
            this.button_silmedemirleri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ürünpdfgörüntüle = new System.Windows.Forms.Button();
            this.onay_ver = new System.Windows.Forms.Button();
            this.reddet = new System.Windows.Forms.Button();
            this.detay_görüntüle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müşteriadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşterisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailadresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparişnumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onaydurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkilionaybekleyensiparişlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisotomaosyonuDataSet4 = new satışotomasyonu.satisotomaosyonuDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.satisotomaosyonuDataSet1 = new satışotomasyonu.satisotomaosyonuDataSet1();
            this.kullaniciidgirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanici_id_girisTableAdapter = new satışotomasyonu.satisotomaosyonuDataSet1TableAdapters.kullanici_id_girisTableAdapter();
            this.ürünlerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünler_TablosuTableAdapter = new satışotomasyonu.satisotomaosyonuDataSet1TableAdapters.Ürünler_TablosuTableAdapter();
            this.yetkilionaybekleyensiparişlerTableAdapter = new satışotomasyonu.satisotomaosyonuDataSet4TableAdapters.yetkilionaybekleyensiparişlerTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.satisotomaosyonuDataSet5 = new satışotomasyonu.satisotomaosyonuDataSet5();
            this.waitingOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_OrdersTableAdapter = new satışotomasyonu.satisotomaosyonuDataSet5TableAdapters.Waiting_OrdersTableAdapter();
            this.groupBox_kategoriler.SuspendLayout();
            this.groupBox_alaşımkategorileri.SuspendLayout();
            this.groupBox_vidakategorileri.SuspendLayout();
            this.groupBox_metalkategorileri.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilionaybekleyensiparişlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciidgirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_kategoriler
            // 
            this.groupBox_kategoriler.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_kategoriler.Controls.Add(this.groupBox_alaşımkategorileri);
            this.groupBox_kategoriler.Controls.Add(this.groupBox_vidakategorileri);
            this.groupBox_kategoriler.Controls.Add(this.groupBox_metalkategorileri);
            this.groupBox_kategoriler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_kategoriler.Location = new System.Drawing.Point(28, 12);
            this.groupBox_kategoriler.Name = "groupBox_kategoriler";
            this.groupBox_kategoriler.Size = new System.Drawing.Size(953, 672);
            this.groupBox_kategoriler.TabIndex = 0;
            this.groupBox_kategoriler.TabStop = false;
            this.groupBox_kategoriler.Text = "Kategoriler";
            this.groupBox_kategoriler.Enter += new System.EventHandler(this.groupBox_kategoriler_Enter);
            // 
            // groupBox_alaşımkategorileri
            // 
            this.groupBox_alaşımkategorileri.Controls.Add(this.button_lehim);
            this.groupBox_alaşımkategorileri.Controls.Add(this.button_pirinç);
            this.groupBox_alaşımkategorileri.Controls.Add(this.button_tunç);
            this.groupBox_alaşımkategorileri.Location = new System.Drawing.Point(658, 39);
            this.groupBox_alaşımkategorileri.Name = "groupBox_alaşımkategorileri";
            this.groupBox_alaşımkategorileri.Size = new System.Drawing.Size(260, 600);
            this.groupBox_alaşımkategorileri.TabIndex = 2;
            this.groupBox_alaşımkategorileri.TabStop = false;
            this.groupBox_alaşımkategorileri.Text = "Alaşım Kategorileri";
            // 
            // button_lehim
            // 
            this.button_lehim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_lehim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_lehim.Location = new System.Drawing.Point(0, 264);
            this.button_lehim.Name = "button_lehim";
            this.button_lehim.Size = new System.Drawing.Size(260, 60);
            this.button_lehim.TabIndex = 2;
            this.button_lehim.Text = "Lehim (Kalay-Kurşun)";
            this.button_lehim.UseVisualStyleBackColor = true;
            this.button_lehim.Click += new System.EventHandler(this.button_lehim_Click);
            // 
            // button_pirinç
            // 
            this.button_pirinç.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_pirinç.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_pirinç.Location = new System.Drawing.Point(0, 157);
            this.button_pirinç.Name = "button_pirinç";
            this.button_pirinç.Size = new System.Drawing.Size(260, 60);
            this.button_pirinç.TabIndex = 1;
            this.button_pirinç.Text = "Pirinç (Bakır-Çinko)";
            this.button_pirinç.UseVisualStyleBackColor = true;
            this.button_pirinç.Click += new System.EventHandler(this.button_pirinç_Click);
            // 
            // button_tunç
            // 
            this.button_tunç.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tunç.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_tunç.Location = new System.Drawing.Point(0, 66);
            this.button_tunç.Name = "button_tunç";
            this.button_tunç.Size = new System.Drawing.Size(260, 60);
            this.button_tunç.TabIndex = 0;
            this.button_tunç.Text = "Tunç (Bakır-Kalay)";
            this.button_tunç.UseVisualStyleBackColor = true;
            this.button_tunç.Click += new System.EventHandler(this.button_tunç_Click);
            // 
            // groupBox_vidakategorileri
            // 
            this.groupBox_vidakategorileri.Controls.Add(this.button_yuvarlakvida);
            this.groupBox_vidakategorileri.Controls.Add(this.button_testerevida);
            this.groupBox_vidakategorileri.Controls.Add(this.button_karevida);
            this.groupBox_vidakategorileri.Controls.Add(this.button_trapezvida);
            this.groupBox_vidakategorileri.Controls.Add(this.button_üçgenvida);
            this.groupBox_vidakategorileri.Location = new System.Drawing.Point(341, 39);
            this.groupBox_vidakategorileri.Name = "groupBox_vidakategorileri";
            this.groupBox_vidakategorileri.Size = new System.Drawing.Size(260, 600);
            this.groupBox_vidakategorileri.TabIndex = 1;
            this.groupBox_vidakategorileri.TabStop = false;
            this.groupBox_vidakategorileri.Text = "Vida Kategorileri";
            // 
            // button_yuvarlakvida
            // 
            this.button_yuvarlakvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yuvarlakvida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_yuvarlakvida.Location = new System.Drawing.Point(0, 157);
            this.button_yuvarlakvida.Name = "button_yuvarlakvida";
            this.button_yuvarlakvida.Size = new System.Drawing.Size(260, 60);
            this.button_yuvarlakvida.TabIndex = 5;
            this.button_yuvarlakvida.Text = "Yuvarlak Vida";
            this.button_yuvarlakvida.UseVisualStyleBackColor = true;
            this.button_yuvarlakvida.Click += new System.EventHandler(this.button_yuvarlakvida_Click);
            // 
            // button_testerevida
            // 
            this.button_testerevida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_testerevida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_testerevida.Location = new System.Drawing.Point(0, 451);
            this.button_testerevida.Name = "button_testerevida";
            this.button_testerevida.Size = new System.Drawing.Size(260, 60);
            this.button_testerevida.TabIndex = 4;
            this.button_testerevida.Text = "Testere Vida";
            this.button_testerevida.UseVisualStyleBackColor = true;
            this.button_testerevida.Click += new System.EventHandler(this.button_testerevida_Click);
            // 
            // button_karevida
            // 
            this.button_karevida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_karevida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_karevida.Location = new System.Drawing.Point(0, 358);
            this.button_karevida.Name = "button_karevida";
            this.button_karevida.Size = new System.Drawing.Size(260, 60);
            this.button_karevida.TabIndex = 3;
            this.button_karevida.Text = "Kare Vida";
            this.button_karevida.UseVisualStyleBackColor = true;
            this.button_karevida.Click += new System.EventHandler(this.button_karevida_Click);
            // 
            // button_trapezvida
            // 
            this.button_trapezvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trapezvida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_trapezvida.Location = new System.Drawing.Point(0, 264);
            this.button_trapezvida.Name = "button_trapezvida";
            this.button_trapezvida.Size = new System.Drawing.Size(260, 60);
            this.button_trapezvida.TabIndex = 2;
            this.button_trapezvida.Text = "Trapez Vida";
            this.button_trapezvida.UseVisualStyleBackColor = true;
            this.button_trapezvida.Click += new System.EventHandler(this.button_trapezvida_Click);
            // 
            // button_üçgenvida
            // 
            this.button_üçgenvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_üçgenvida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_üçgenvida.Location = new System.Drawing.Point(0, 66);
            this.button_üçgenvida.Name = "button_üçgenvida";
            this.button_üçgenvida.Size = new System.Drawing.Size(260, 60);
            this.button_üçgenvida.TabIndex = 0;
            this.button_üçgenvida.Text = "Üçgen Vida";
            this.button_üçgenvida.UseVisualStyleBackColor = true;
            this.button_üçgenvida.Click += new System.EventHandler(this.button_üçgenvida_Click);
            // 
            // groupBox_metalkategorileri
            // 
            this.groupBox_metalkategorileri.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_metalkategorileri.Controls.Add(this.button_karedoludemirler);
            this.groupBox_metalkategorileri.Controls.Add(this.button_inşaatdemirleri);
            this.groupBox_metalkategorileri.Controls.Add(this.button_tprofildemirleri);
            this.groupBox_metalkategorileri.Controls.Add(this.button_lamademirleri);
            this.groupBox_metalkategorileri.Controls.Add(this.button_silmedemirleri);
            this.groupBox_metalkategorileri.Location = new System.Drawing.Point(50, 39);
            this.groupBox_metalkategorileri.Name = "groupBox_metalkategorileri";
            this.groupBox_metalkategorileri.Size = new System.Drawing.Size(260, 600);
            this.groupBox_metalkategorileri.TabIndex = 0;
            this.groupBox_metalkategorileri.TabStop = false;
            this.groupBox_metalkategorileri.Text = "Demir Kategorileri";
            // 
            // button_karedoludemirler
            // 
            this.button_karedoludemirler.BackColor = System.Drawing.Color.Transparent;
            this.button_karedoludemirler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_karedoludemirler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_karedoludemirler.Location = new System.Drawing.Point(0, 358);
            this.button_karedoludemirler.Name = "button_karedoludemirler";
            this.button_karedoludemirler.Size = new System.Drawing.Size(260, 60);
            this.button_karedoludemirler.TabIndex = 4;
            this.button_karedoludemirler.Text = "Kare  Dolu Demirler";
            this.button_karedoludemirler.UseVisualStyleBackColor = false;
            this.button_karedoludemirler.Click += new System.EventHandler(this.button_karedoludemirler_Click);
            // 
            // button_inşaatdemirleri
            // 
            this.button_inşaatdemirleri.BackColor = System.Drawing.Color.Transparent;
            this.button_inşaatdemirleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_inşaatdemirleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_inşaatdemirleri.Location = new System.Drawing.Point(0, 451);
            this.button_inşaatdemirleri.Name = "button_inşaatdemirleri";
            this.button_inşaatdemirleri.Size = new System.Drawing.Size(260, 60);
            this.button_inşaatdemirleri.TabIndex = 3;
            this.button_inşaatdemirleri.Text = "İnşaat Demirleri";
            this.button_inşaatdemirleri.UseVisualStyleBackColor = false;
            this.button_inşaatdemirleri.Click += new System.EventHandler(this.button_inşaatdemirleri_Click);
            // 
            // button_tprofildemirleri
            // 
            this.button_tprofildemirleri.BackColor = System.Drawing.Color.Transparent;
            this.button_tprofildemirleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tprofildemirleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_tprofildemirleri.Location = new System.Drawing.Point(0, 264);
            this.button_tprofildemirleri.Name = "button_tprofildemirleri";
            this.button_tprofildemirleri.Size = new System.Drawing.Size(260, 60);
            this.button_tprofildemirleri.TabIndex = 2;
            this.button_tprofildemirleri.Text = "T Profil Demirler";
            this.button_tprofildemirleri.UseVisualStyleBackColor = false;
            this.button_tprofildemirleri.Click += new System.EventHandler(this.button_tprofildemirleri_Click);
            // 
            // button_lamademirleri
            // 
            this.button_lamademirleri.BackColor = System.Drawing.Color.Transparent;
            this.button_lamademirleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_lamademirleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_lamademirleri.Location = new System.Drawing.Point(0, 157);
            this.button_lamademirleri.Name = "button_lamademirleri";
            this.button_lamademirleri.Size = new System.Drawing.Size(260, 60);
            this.button_lamademirleri.TabIndex = 1;
            this.button_lamademirleri.Text = "Lama Demirleri";
            this.button_lamademirleri.UseVisualStyleBackColor = false;
            this.button_lamademirleri.Click += new System.EventHandler(this.button_lamademirleri_Click);
            // 
            // button_silmedemirleri
            // 
            this.button_silmedemirleri.BackColor = System.Drawing.Color.Transparent;
            this.button_silmedemirleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_silmedemirleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_silmedemirleri.Location = new System.Drawing.Point(0, 66);
            this.button_silmedemirleri.Name = "button_silmedemirleri";
            this.button_silmedemirleri.Size = new System.Drawing.Size(260, 60);
            this.button_silmedemirleri.TabIndex = 0;
            this.button_silmedemirleri.Text = "Silme Demirleri";
            this.button_silmedemirleri.UseVisualStyleBackColor = false;
            this.button_silmedemirleri.Click += new System.EventHandler(this.button_silmedemirleri_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ürünpdfgörüntüle);
            this.panel1.Controls.Add(this.onay_ver);
            this.panel1.Controls.Add(this.reddet);
            this.panel1.Controls.Add(this.detay_görüntüle);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1027, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 633);
            this.panel1.TabIndex = 1;
            // 
            // ürünpdfgörüntüle
            // 
            this.ürünpdfgörüntüle.Location = new System.Drawing.Point(8, 578);
            this.ürünpdfgörüntüle.Name = "ürünpdfgörüntüle";
            this.ürünpdfgörüntüle.Size = new System.Drawing.Size(114, 40);
            this.ürünpdfgörüntüle.TabIndex = 1;
            this.ürünpdfgörüntüle.Text = "Fatura Görüntüle";
            this.ürünpdfgörüntüle.UseVisualStyleBackColor = true;
            this.ürünpdfgörüntüle.Click += new System.EventHandler(this.ürünpdfgörüntüle_Click);
            // 
            // onay_ver
            // 
            this.onay_ver.Location = new System.Drawing.Point(557, 532);
            this.onay_ver.Name = "onay_ver";
            this.onay_ver.Size = new System.Drawing.Size(122, 40);
            this.onay_ver.TabIndex = 1;
            this.onay_ver.Text = "Onay Ver";
            this.onay_ver.UseVisualStyleBackColor = true;
            this.onay_ver.Click += new System.EventHandler(this.button1_Click);
            // 
            // reddet
            // 
            this.reddet.Location = new System.Drawing.Point(557, 578);
            this.reddet.Name = "reddet";
            this.reddet.Size = new System.Drawing.Size(122, 40);
            this.reddet.TabIndex = 1;
            this.reddet.Text = "Reddet";
            this.reddet.UseVisualStyleBackColor = true;
            this.reddet.Click += new System.EventHandler(this.reddet_Click);
            // 
            // detay_görüntüle
            // 
            this.detay_görüntüle.Location = new System.Drawing.Point(8, 532);
            this.detay_görüntüle.Name = "detay_görüntüle";
            this.detay_görüntüle.Size = new System.Drawing.Size(114, 40);
            this.detay_görüntüle.TabIndex = 1;
            this.detay_görüntüle.Text = "Detay Görüntüle";
            this.detay_görüntüle.UseVisualStyleBackColor = true;
            this.detay_görüntüle.Click += new System.EventHandler(this.onay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.müşteriadiDataGridViewTextBoxColumn,
            this.müşterisoyadiDataGridViewTextBoxColumn,
            this.mailadresiDataGridViewTextBoxColumn,
            this.siparişnumarasiDataGridViewTextBoxColumn,
            this.onaydurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.waitingOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 511);
            this.dataGridView1.TabIndex = 0;
            // 
            // müşteriadiDataGridViewTextBoxColumn
            // 
            this.müşteriadiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.müşteriadiDataGridViewTextBoxColumn.DataPropertyName = "müşteriadi";
            this.müşteriadiDataGridViewTextBoxColumn.HeaderText = "müşteriadi";
            this.müşteriadiDataGridViewTextBoxColumn.Name = "müşteriadiDataGridViewTextBoxColumn";
            // 
            // müşterisoyadiDataGridViewTextBoxColumn
            // 
            this.müşterisoyadiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.müşterisoyadiDataGridViewTextBoxColumn.DataPropertyName = "müşterisoyadi";
            this.müşterisoyadiDataGridViewTextBoxColumn.HeaderText = "müşterisoyadi";
            this.müşterisoyadiDataGridViewTextBoxColumn.Name = "müşterisoyadiDataGridViewTextBoxColumn";
            // 
            // mailadresiDataGridViewTextBoxColumn
            // 
            this.mailadresiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailadresiDataGridViewTextBoxColumn.DataPropertyName = "mailadresi";
            this.mailadresiDataGridViewTextBoxColumn.HeaderText = "mailadresi";
            this.mailadresiDataGridViewTextBoxColumn.Name = "mailadresiDataGridViewTextBoxColumn";
            // 
            // siparişnumarasiDataGridViewTextBoxColumn
            // 
            this.siparişnumarasiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siparişnumarasiDataGridViewTextBoxColumn.DataPropertyName = "siparişnumarasi";
            this.siparişnumarasiDataGridViewTextBoxColumn.HeaderText = "siparişnumarasi";
            this.siparişnumarasiDataGridViewTextBoxColumn.Name = "siparişnumarasiDataGridViewTextBoxColumn";
            // 
            // onaydurumuDataGridViewTextBoxColumn
            // 
            this.onaydurumuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.onaydurumuDataGridViewTextBoxColumn.DataPropertyName = "onaydurumu";
            this.onaydurumuDataGridViewTextBoxColumn.HeaderText = "onaydurumu";
            this.onaydurumuDataGridViewTextBoxColumn.Name = "onaydurumuDataGridViewTextBoxColumn";
            // 
            // yetkilionaybekleyensiparişlerBindingSource
            // 
            this.yetkilionaybekleyensiparişlerBindingSource.DataMember = "yetkilionaybekleyensiparişler";
            this.yetkilionaybekleyensiparişlerBindingSource.DataSource = this.satisotomaosyonuDataSet4;
            // 
            // satisotomaosyonuDataSet4
            // 
            this.satisotomaosyonuDataSet4.DataSetName = "satisotomaosyonuDataSet4";
            this.satisotomaosyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1023, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siparişler ";
            // 
            // satisotomaosyonuDataSet1
            // 
            this.satisotomaosyonuDataSet1.DataSetName = "satisotomaosyonuDataSet1";
            this.satisotomaosyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanici_id_girisTableAdapter
            // 
            this.kullanici_id_girisTableAdapter.ClearBeforeFill = true;
            // 
            // ürünler_TablosuTableAdapter
            // 
            this.ürünler_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // yetkilionaybekleyensiparişlerTableAdapter
            // 
            this.yetkilionaybekleyensiparişlerTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // satisotomaosyonuDataSet5
            // 
            this.satisotomaosyonuDataSet5.DataSetName = "satisotomaosyonuDataSet5";
            this.satisotomaosyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingOrdersBindingSource
            // 
            this.waitingOrdersBindingSource.DataMember = "Waiting_Orders";
            this.waitingOrdersBindingSource.DataSource = this.satisotomaosyonuDataSet5;
            // 
            // waiting_OrdersTableAdapter
            // 
            this.waiting_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorizedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1749, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_kategoriler);
            this.Name = "AuthorizedMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili ";
            this.Load += new System.EventHandler(this.yetkiliformu_Load);
            this.groupBox_kategoriler.ResumeLayout(false);
            this.groupBox_alaşımkategorileri.ResumeLayout(false);
            this.groupBox_vidakategorileri.ResumeLayout(false);
            this.groupBox_metalkategorileri.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilionaybekleyensiparişlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciidgirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_kategoriler;
        private System.Windows.Forms.GroupBox groupBox_alaşımkategorileri;
        private System.Windows.Forms.GroupBox groupBox_vidakategorileri;
        private System.Windows.Forms.GroupBox groupBox_metalkategorileri;
        private System.Windows.Forms.Button button_inşaatdemirleri;
        private System.Windows.Forms.Button button_tprofildemirleri;
        private System.Windows.Forms.Button button_lamademirleri;
        private System.Windows.Forms.Button button_silmedemirleri;
        private System.Windows.Forms.Button button_karedoludemirler;
        private System.Windows.Forms.Button button_testerevida;
        private System.Windows.Forms.Button button_karevida;
        private System.Windows.Forms.Button button_trapezvida;
        private System.Windows.Forms.Button button_üçgenvida;
        private System.Windows.Forms.Button button_yuvarlakvida;
        private System.Windows.Forms.Button button_lehim;
        private System.Windows.Forms.Button button_pirinç;
        private System.Windows.Forms.Button button_tunç;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private satisotomaosyonuDataSet1 satisotomaosyonuDataSet1;
        private System.Windows.Forms.BindingSource kullaniciidgirisBindingSource;
        private satisotomaosyonuDataSet1TableAdapters.kullanici_id_girisTableAdapter kullanici_id_girisTableAdapter;
        private System.Windows.Forms.BindingSource ürünlerTablosuBindingSource;
        private satisotomaosyonuDataSet1TableAdapters.Ürünler_TablosuTableAdapter ürünler_TablosuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private satisotomaosyonuDataSet4 satisotomaosyonuDataSet4;
        private System.Windows.Forms.BindingSource yetkilionaybekleyensiparişlerBindingSource;
        private satisotomaosyonuDataSet4TableAdapters.yetkilionaybekleyensiparişlerTableAdapter yetkilionaybekleyensiparişlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşterisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailadresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparişnumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onaydurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reddet;
        private System.Windows.Forms.Button detay_görüntüle;
        private System.Windows.Forms.Button ürünpdfgörüntüle;
        private System.Windows.Forms.Button onay_ver;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private satisotomaosyonuDataSet5 satisotomaosyonuDataSet5;
        private System.Windows.Forms.BindingSource waitingOrdersBindingSource;
        private satisotomaosyonuDataSet5TableAdapters.Waiting_OrdersTableAdapter waiting_OrdersTableAdapter;
    }
}