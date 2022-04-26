namespace Ener_Otomasyon
{
    partial class Malzemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malzemeler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlislemler = new DevExpress.XtraEditors.GroupControl();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox_NOT = new System.Windows.Forms.RichTextBox();
            this.lbl_NOT = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox_OZELLIKLER = new System.Windows.Forms.RichTextBox();
            this.lbl_OZELLIKLER = new DevExpress.XtraEditors.LabelControl();
            this.txt_ADET = new System.Windows.Forms.TextBox();
            this.lbl_ADET = new DevExpress.XtraEditors.LabelControl();
            this.txt_MODEL = new System.Windows.Forms.TextBox();
            this.lbl_MODEL = new DevExpress.XtraEditors.LabelControl();
            this.txt_MARKA = new System.Windows.Forms.TextBox();
            this.lbl_MARKA = new DevExpress.XtraEditors.LabelControl();
            this.txt_URUNNO = new System.Windows.Forms.TextBox();
            this.lbl_URUNNO = new DevExpress.XtraEditors.LabelControl();
            this.txt_URUNAD = new System.Windows.Forms.TextBox();
            this.lbl_URUNAD = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlislemler)).BeginInit();
            this.groupControlislemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1243, 625);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
       
            // 
            // groupControlislemler
            // 
            this.groupControlislemler.Controls.Add(this.labelControl2);
            this.groupControlislemler.Controls.Add(this.btn_Guncelle);
            this.groupControlislemler.Controls.Add(this.btn_Sil);
            this.groupControlislemler.Controls.Add(this.btn_Kaydet);
            this.groupControlislemler.Controls.Add(this.richTextBox_NOT);
            this.groupControlislemler.Controls.Add(this.lbl_NOT);
            this.groupControlislemler.Controls.Add(this.richTextBox_OZELLIKLER);
            this.groupControlislemler.Controls.Add(this.lbl_OZELLIKLER);
            this.groupControlislemler.Controls.Add(this.txt_ADET);
            this.groupControlislemler.Controls.Add(this.lbl_ADET);
            this.groupControlislemler.Controls.Add(this.txt_MODEL);
            this.groupControlislemler.Controls.Add(this.lbl_MODEL);
            this.groupControlislemler.Controls.Add(this.txt_MARKA);
            this.groupControlislemler.Controls.Add(this.lbl_MARKA);
            this.groupControlislemler.Controls.Add(this.txt_URUNNO);
            this.groupControlislemler.Controls.Add(this.lbl_URUNNO);
            this.groupControlislemler.Controls.Add(this.txt_URUNAD);
            this.groupControlislemler.Controls.Add(this.lbl_URUNAD);
            this.groupControlislemler.Location = new System.Drawing.Point(1251, 0);
            this.groupControlislemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControlislemler.Name = "groupControlislemler";
            this.groupControlislemler.Size = new System.Drawing.Size(404, 625);
            this.groupControlislemler.TabIndex = 1;
            this.groupControlislemler.Text = "İşlemler";

            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(279, 548);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(119, 46);
            this.btn_Guncelle.TabIndex = 25;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(143, 548);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(128, 46);
            this.btn_Sil.TabIndex = 24;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.ImageOptions.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(7, 548);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(128, 46);
            this.btn_Kaydet.TabIndex = 23;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // richTextBox_NOT
            // 
            this.richTextBox_NOT.Location = new System.Drawing.Point(68, 380);
            this.richTextBox_NOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_NOT.Name = "richTextBox_NOT";
            this.richTextBox_NOT.Size = new System.Drawing.Size(325, 160);
            this.richTextBox_NOT.TabIndex = 22;
            this.richTextBox_NOT.Text = "";
            // 
            // lbl_NOT
            // 
            this.lbl_NOT.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_NOT.Location = new System.Drawing.Point(7, 410);
            this.lbl_NOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_NOT.Name = "lbl_NOT";
            this.lbl_NOT.Size = new System.Drawing.Size(19, 16);
            this.lbl_NOT.TabIndex = 21;
            this.lbl_NOT.Text = "Not";
            // 
            // richTextBox_OZELLIKLER
            // 
            this.richTextBox_OZELLIKLER.Location = new System.Drawing.Point(68, 212);
            this.richTextBox_OZELLIKLER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_OZELLIKLER.Name = "richTextBox_OZELLIKLER";
            this.richTextBox_OZELLIKLER.Size = new System.Drawing.Size(325, 160);
            this.richTextBox_OZELLIKLER.TabIndex = 20;
            this.richTextBox_OZELLIKLER.Text = "";
            // 
            // lbl_OZELLIKLER
            // 
            this.lbl_OZELLIKLER.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_OZELLIKLER.Location = new System.Drawing.Point(4, 215);
            this.lbl_OZELLIKLER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_OZELLIKLER.Name = "lbl_OZELLIKLER";
            this.lbl_OZELLIKLER.Size = new System.Drawing.Size(52, 16);
            this.lbl_OZELLIKLER.TabIndex = 19;
            this.lbl_OZELLIKLER.Text = "Özellikler";
            // 
            // txt_ADET
            // 
            this.txt_ADET.Location = new System.Drawing.Point(68, 178);
            this.txt_ADET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ADET.Name = "txt_ADET";
            this.txt_ADET.Size = new System.Drawing.Size(183, 23);
            this.txt_ADET.TabIndex = 18;
            // 
            // lbl_ADET
            // 
            this.lbl_ADET.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_ADET.Location = new System.Drawing.Point(7, 182);
            this.lbl_ADET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_ADET.Name = "lbl_ADET";
            this.lbl_ADET.Size = new System.Drawing.Size(26, 16);
            this.lbl_ADET.TabIndex = 17;
            this.lbl_ADET.Text = "Adet";
            // 
            // txt_MODEL
            // 
            this.txt_MODEL.Location = new System.Drawing.Point(68, 145);
            this.txt_MODEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MODEL.Name = "txt_MODEL";
            this.txt_MODEL.Size = new System.Drawing.Size(183, 23);
            this.txt_MODEL.TabIndex = 16;
            // 
            // lbl_MODEL
            // 
            this.lbl_MODEL.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_MODEL.Location = new System.Drawing.Point(7, 149);
            this.lbl_MODEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_MODEL.Name = "lbl_MODEL";
            this.lbl_MODEL.Size = new System.Drawing.Size(34, 16);
            this.lbl_MODEL.TabIndex = 15;
            this.lbl_MODEL.Text = "Model";
            // 
            // txt_MARKA
            // 
            this.txt_MARKA.Location = new System.Drawing.Point(68, 112);
            this.txt_MARKA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MARKA.Name = "txt_MARKA";
            this.txt_MARKA.Size = new System.Drawing.Size(183, 23);
            this.txt_MARKA.TabIndex = 14;
            // 
            // lbl_MARKA
            // 
            this.lbl_MARKA.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_MARKA.Location = new System.Drawing.Point(7, 116);
            this.lbl_MARKA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_MARKA.Name = "lbl_MARKA";
            this.lbl_MARKA.Size = new System.Drawing.Size(35, 16);
            this.lbl_MARKA.TabIndex = 13;
            this.lbl_MARKA.Text = "Marka";
            // 
            // txt_URUNNO
            // 
            this.txt_URUNNO.Location = new System.Drawing.Point(68, 79);
            this.txt_URUNNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_URUNNO.Name = "txt_URUNNO";
            this.txt_URUNNO.Size = new System.Drawing.Size(183, 23);
            this.txt_URUNNO.TabIndex = 12;
            // 
            // lbl_URUNNO
            // 
            this.lbl_URUNNO.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_URUNNO.Location = new System.Drawing.Point(7, 82);
            this.lbl_URUNNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_URUNNO.Name = "lbl_URUNNO";
            this.lbl_URUNNO.Size = new System.Drawing.Size(46, 16);
            this.lbl_URUNNO.TabIndex = 11;
            this.lbl_URUNNO.Text = "Ürün No";
            // 
            // txt_URUNAD
            // 
            this.txt_URUNAD.Location = new System.Drawing.Point(68, 46);
            this.txt_URUNAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_URUNAD.Name = "txt_URUNAD";
            this.txt_URUNAD.Size = new System.Drawing.Size(183, 23);
            this.txt_URUNAD.TabIndex = 10;
            // 
            // lbl_URUNAD
            // 
            this.lbl_URUNAD.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.lbl_URUNAD.Location = new System.Drawing.Point(7, 49);
            this.lbl_URUNAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_URUNAD.Name = "lbl_URUNAD";
            this.lbl_URUNAD.Size = new System.Drawing.Size(49, 16);
            this.lbl_URUNAD.TabIndex = 1;
            this.lbl_URUNAD.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 300);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "labelControl2";
            // 
            // Malzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 625);
            this.Controls.Add(this.groupControlislemler);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Malzemeler";
            this.Text = "Malzemeler";
            this.Load += new System.EventHandler(this.Malzemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlislemler)).EndInit();
            this.groupControlislemler.ResumeLayout(false);
            this.groupControlislemler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlislemler;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.RichTextBox richTextBox_NOT;
        private DevExpress.XtraEditors.LabelControl lbl_NOT;
        private System.Windows.Forms.RichTextBox richTextBox_OZELLIKLER;
        private DevExpress.XtraEditors.LabelControl lbl_OZELLIKLER;
        private System.Windows.Forms.TextBox txt_ADET;
        private DevExpress.XtraEditors.LabelControl lbl_ADET;
        private System.Windows.Forms.TextBox txt_MODEL;
        private DevExpress.XtraEditors.LabelControl lbl_MODEL;
        private System.Windows.Forms.TextBox txt_MARKA;
        private DevExpress.XtraEditors.LabelControl lbl_MARKA;
        private System.Windows.Forms.TextBox txt_URUNNO;
        private DevExpress.XtraEditors.LabelControl lbl_URUNNO;
        private System.Windows.Forms.TextBox txt_URUNAD;
        private DevExpress.XtraEditors.LabelControl lbl_URUNAD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}