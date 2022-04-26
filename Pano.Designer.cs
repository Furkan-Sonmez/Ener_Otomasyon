namespace Ener_Otomasyon
{
    partial class Pano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pano));
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_MODEL = new DevExpress.XtraEditors.LabelControl();
            this.lbl_MARKA = new DevExpress.XtraEditors.LabelControl();
            this.lbl_URUNNO = new DevExpress.XtraEditors.LabelControl();
            this.txt_PANOTIP = new System.Windows.Forms.TextBox();
            this.lbl_URUNAD = new DevExpress.XtraEditors.LabelControl();
            this.groupControlislemler = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richTextBox_PANOOZELLIKLER = new System.Windows.Forms.RichTextBox();
            this.txt_PANOID = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox_PANOSARF = new System.Windows.Forms.RichTextBox();
            this.txt_PANOOLCU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlislemler)).BeginInit();
            this.groupControlislemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(209, 459);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(89, 37);
            this.btn_Guncelle.TabIndex = 25;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(107, 459);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(96, 37);
            this.btn_Sil.TabIndex = 24;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.ImageOptions.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(5, 459);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(96, 37);
            this.btn_Kaydet.TabIndex = 23;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lbl_MODEL
            // 
            this.lbl_MODEL.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_MODEL.Location = new System.Drawing.Point(11, 265);
            this.lbl_MODEL.Name = "lbl_MODEL";
            this.lbl_MODEL.Size = new System.Drawing.Size(71, 13);
            this.lbl_MODEL.TabIndex = 15;
            this.lbl_MODEL.Text = "Pano Özellikleri";
            // 
            // lbl_MARKA
            // 
            this.lbl_MARKA.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_MARKA.Location = new System.Drawing.Point(11, 238);
            this.lbl_MARKA.Name = "lbl_MARKA";
            this.lbl_MARKA.Size = new System.Drawing.Size(62, 13);
            this.lbl_MARKA.TabIndex = 13;
            this.lbl_MARKA.Text = "Pano Ölçüleri";
            // 
            // lbl_URUNNO
            // 
            this.lbl_URUNNO.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_URUNNO.Location = new System.Drawing.Point(11, 90);
            this.lbl_URUNNO.Name = "lbl_URUNNO";
            this.lbl_URUNNO.Size = new System.Drawing.Size(48, 13);
            this.lbl_URUNNO.TabIndex = 11;
            this.lbl_URUNNO.Text = "Pano Sarf";
            // 
            // txt_PANOTIP
            // 
            this.txt_PANOTIP.Location = new System.Drawing.Point(88, 63);
            this.txt_PANOTIP.Name = "txt_PANOTIP";
            this.txt_PANOTIP.Size = new System.Drawing.Size(210, 21);
            this.txt_PANOTIP.TabIndex = 10;
            // 
            // lbl_URUNAD
            // 
            this.lbl_URUNAD.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_URUNAD.Location = new System.Drawing.Point(11, 63);
            this.lbl_URUNAD.Name = "lbl_URUNAD";
            this.lbl_URUNAD.Size = new System.Drawing.Size(46, 13);
            this.lbl_URUNAD.TabIndex = 1;
            this.lbl_URUNAD.Text = "Pano Tipi ";
            // 
            // groupControlislemler
            // 
            this.groupControlislemler.Controls.Add(this.richTextBox_PANOSARF);
            this.groupControlislemler.Controls.Add(this.txt_PANOID);
            this.groupControlislemler.Controls.Add(this.labelControl1);
            this.groupControlislemler.Controls.Add(this.richTextBox_PANOOZELLIKLER);
            this.groupControlislemler.Controls.Add(this.btn_Guncelle);
            this.groupControlislemler.Controls.Add(this.btn_Sil);
            this.groupControlislemler.Controls.Add(this.btn_Kaydet);
            this.groupControlislemler.Controls.Add(this.lbl_MODEL);
            this.groupControlislemler.Controls.Add(this.txt_PANOOLCU);
            this.groupControlislemler.Controls.Add(this.lbl_MARKA);
            this.groupControlislemler.Controls.Add(this.lbl_URUNNO);
            this.groupControlislemler.Controls.Add(this.txt_PANOTIP);
            this.groupControlislemler.Controls.Add(this.lbl_URUNAD);
            this.groupControlislemler.Location = new System.Drawing.Point(939, 0);
            this.groupControlislemler.Name = "groupControlislemler";
            this.groupControlislemler.Size = new System.Drawing.Size(303, 508);
            this.groupControlislemler.TabIndex = 7;
            this.groupControlislemler.Text = "İşlemler";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(932, 508);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // richTextBox_PANOOZELLIKLER
            // 
            this.richTextBox_PANOOZELLIKLER.Location = new System.Drawing.Point(88, 262);
            this.richTextBox_PANOOZELLIKLER.Name = "richTextBox_PANOOZELLIKLER";
            this.richTextBox_PANOOZELLIKLER.Size = new System.Drawing.Size(210, 191);
            this.richTextBox_PANOOZELLIKLER.TabIndex = 26;
            this.richTextBox_PANOOZELLIKLER.Text = "";
            // 
            // txt_PANOID
            // 
            this.txt_PANOID.Location = new System.Drawing.Point(88, 36);
            this.txt_PANOID.Name = "txt_PANOID";
            this.txt_PANOID.Size = new System.Drawing.Size(210, 21);
            this.txt_PANOID.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.labelControl1.Location = new System.Drawing.Point(11, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Pano ID";
            // 
            // richTextBox_PANOSARF
            // 
            this.richTextBox_PANOSARF.Location = new System.Drawing.Point(88, 90);
            this.richTextBox_PANOSARF.Name = "richTextBox_PANOSARF";
            this.richTextBox_PANOSARF.Size = new System.Drawing.Size(210, 139);
            this.richTextBox_PANOSARF.TabIndex = 29;
            this.richTextBox_PANOSARF.Text = "";
            // 
            // txt_PANOOLCU
            // 
            this.txt_PANOOLCU.Location = new System.Drawing.Point(88, 235);
            this.txt_PANOOLCU.Name = "txt_PANOOLCU";
            this.txt_PANOOLCU.Size = new System.Drawing.Size(210, 21);
            this.txt_PANOOLCU.TabIndex = 14;
            // 
            // Pano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 508);
            this.Controls.Add(this.groupControlislemler);
            this.Controls.Add(this.gridControl1);
            this.Name = "Pano";
            this.Text = "Pano";
            this.Load += new System.EventHandler(this.Pano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlislemler)).EndInit();
            this.groupControlislemler.ResumeLayout(false);
            this.groupControlislemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.LabelControl lbl_MODEL;
        private DevExpress.XtraEditors.LabelControl lbl_MARKA;
        private DevExpress.XtraEditors.LabelControl lbl_URUNNO;
        private System.Windows.Forms.TextBox txt_PANOTIP;
        private DevExpress.XtraEditors.LabelControl lbl_URUNAD;
        private DevExpress.XtraEditors.GroupControl groupControlislemler;
        private System.Windows.Forms.RichTextBox richTextBox_PANOOZELLIKLER;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txt_PANOID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richTextBox_PANOSARF;
        private System.Windows.Forms.TextBox txt_PANOOLCU;
    }
}