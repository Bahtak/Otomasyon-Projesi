namespace satışotomasyonu
{
    partial class AuthorizedSalesForm
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
            this.yetkilionaydatagridview = new System.Windows.Forms.DataGridView();
            this.siparişlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparişler = new satışotomasyonu.siparişler();
            this.siparişlerTableAdapter = new satışotomasyonu.siparişlerTableAdapters.siparişlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.satisotomaosyonuDataSet5 = new satışotomasyonu.satisotomaosyonuDataSet5();
            this.waitingOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_OrdersTableAdapter = new satışotomasyonu.satisotomaosyonuDataSet5TableAdapters.Waiting_OrdersTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kjh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maliyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgfb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilionaydatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // yetkilionaydatagridview
            // 
            this.yetkilionaydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yetkilionaydatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column13,
            this.Column3,
            this.Column4,
            this.kjh,
            this.Column5,
            this.Column6,
            this.Maliyet,
            this.Column7,
            this.Column8,
            this.bgfb,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.yetkilionaydatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yetkilionaydatagridview.Location = new System.Drawing.Point(0, 0);
            this.yetkilionaydatagridview.Name = "yetkilionaydatagridview";
            this.yetkilionaydatagridview.Size = new System.Drawing.Size(1833, 801);
            this.yetkilionaydatagridview.TabIndex = 0;
            this.yetkilionaydatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yetkilionaydatagridview_CellContentClick);
            // 
            // siparişlerBindingSource
            // 
            this.siparişlerBindingSource.DataMember = "siparişler";
            this.siparişlerBindingSource.DataSource = this.siparişler;
            // 
            // siparişler
            // 
            this.siparişler.DataSetName = "siparişler";
            this.siparişler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparişlerTableAdapter
            // 
            this.siparişlerTableAdapter.ClearBeforeFill = true;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Kullanıcı ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Kullanıcı Adı";
            this.Column2.Name = "Column2";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Kullanıcı Soyad";
            this.Column13.Name = "Column13";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Mail Adresi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Alışveriş ID";
            this.Column4.Name = "Column4";
            // 
            // kjh
            // 
            this.kjh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kjh.HeaderText = "Ürün ID";
            this.kjh.Name = "kjh";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Ürün Adı";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Adet ";
            this.Column6.Name = "Column6";
            // 
            // Maliyet
            // 
            this.Maliyet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Maliyet.HeaderText = "Maliyet";
            this.Maliyet.Name = "Maliyet";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Kdv Oranı";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Kdv Tutarı";
            this.Column8.Name = "Column8";
            // 
            // bgfb
            // 
            this.bgfb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgfb.HeaderText = "Kdv\'li Toplam Tutar";
            this.bgfb.Name = "bgfb";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Fatura Onay";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Sipariş Numarası";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Sipari Tarihi/Saati";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Mail Gönderim Durumu";
            this.Column12.Name = "Column12";
            // 
            // AuthorizedSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 801);
            this.Controls.Add(this.yetkilionaydatagridview);
            this.Name = "AuthorizedSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yetkilisatışonayformu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.yetkilisatışonayformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yetkilionaydatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisotomaosyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView yetkilionaydatagridview;
        private siparişler siparişler;
        private System.Windows.Forms.BindingSource siparişlerBindingSource;
        private siparişlerTableAdapters.siparişlerTableAdapter siparişlerTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private satisotomaosyonuDataSet5 satisotomaosyonuDataSet5;
        private System.Windows.Forms.BindingSource waitingOrdersBindingSource;
        private satisotomaosyonuDataSet5TableAdapters.Waiting_OrdersTableAdapter waiting_OrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn kjh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maliyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}