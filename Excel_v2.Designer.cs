namespace Ener_Otomasyon
{
    partial class Excel_v2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.Dosya = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.enerDataSet = new Ener_Otomasyon.EnerDataSet();
            this.enerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLURUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_URUNTableAdapter = new Ener_Otomasyon.EnerDataSetTableAdapters.TBL_URUNTableAdapter();
            this.uRUNADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oZELLIKLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTLARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uRUNADDataGridViewTextBoxColumn,
            this.uRUNNODataGridViewTextBoxColumn,
            this.mARKADataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.aDETDataGridViewTextBoxColumn,
            this.oZELLIKLERDataGridViewTextBoxColumn,
            this.nOTLARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLURUNBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(218, 365);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "....";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(31, 362);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(121, 22);
            this.txt_file.TabIndex = 3;
            // 
            // Dosya
            // 
            this.Dosya.AutoSize = true;
            this.Dosya.Location = new System.Drawing.Point(158, 365);
            this.Dosya.Name = "Dosya";
            this.Dosya.Size = new System.Drawing.Size(47, 16);
            this.Dosya.TabIndex = 4;
            this.Dosya.Text = "Dosya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sayfa";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(218, 391);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // enerDataSet
            // 
            this.enerDataSet.DataSetName = "EnerDataSet";
            this.enerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enerDataSetBindingSource
            // 
            this.enerDataSetBindingSource.DataSource = this.enerDataSet;
            this.enerDataSetBindingSource.Position = 0;
            // 
            // tBLURUNBindingSource
            // 
            this.tBLURUNBindingSource.DataMember = "TBL_URUN";
            this.tBLURUNBindingSource.DataSource = this.enerDataSet;
            // 
            // tBL_URUNTableAdapter
            // 
            this.tBL_URUNTableAdapter.ClearBeforeFill = true;
            // 
            // uRUNADDataGridViewTextBoxColumn
            // 
            this.uRUNADDataGridViewTextBoxColumn.DataPropertyName = "URUNAD";
            this.uRUNADDataGridViewTextBoxColumn.HeaderText = "URUNAD";
            this.uRUNADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRUNADDataGridViewTextBoxColumn.Name = "uRUNADDataGridViewTextBoxColumn";
            this.uRUNADDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRUNNODataGridViewTextBoxColumn
            // 
            this.uRUNNODataGridViewTextBoxColumn.DataPropertyName = "URUNNO";
            this.uRUNNODataGridViewTextBoxColumn.HeaderText = "URUNNO";
            this.uRUNNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRUNNODataGridViewTextBoxColumn.Name = "uRUNNODataGridViewTextBoxColumn";
            this.uRUNNODataGridViewTextBoxColumn.Width = 125;
            // 
            // mARKADataGridViewTextBoxColumn
            // 
            this.mARKADataGridViewTextBoxColumn.DataPropertyName = "MARKA";
            this.mARKADataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.mARKADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mARKADataGridViewTextBoxColumn.Name = "mARKADataGridViewTextBoxColumn";
            this.mARKADataGridViewTextBoxColumn.Width = 125;
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            this.mODELDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDETDataGridViewTextBoxColumn
            // 
            this.aDETDataGridViewTextBoxColumn.DataPropertyName = "ADET";
            this.aDETDataGridViewTextBoxColumn.HeaderText = "ADET";
            this.aDETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDETDataGridViewTextBoxColumn.Name = "aDETDataGridViewTextBoxColumn";
            this.aDETDataGridViewTextBoxColumn.Width = 125;
            // 
            // oZELLIKLERDataGridViewTextBoxColumn
            // 
            this.oZELLIKLERDataGridViewTextBoxColumn.DataPropertyName = "OZELLIKLER";
            this.oZELLIKLERDataGridViewTextBoxColumn.HeaderText = "OZELLIKLER";
            this.oZELLIKLERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oZELLIKLERDataGridViewTextBoxColumn.Name = "oZELLIKLERDataGridViewTextBoxColumn";
            this.oZELLIKLERDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOTLARDataGridViewTextBoxColumn
            // 
            this.nOTLARDataGridViewTextBoxColumn.DataPropertyName = "NOTLAR";
            this.nOTLARDataGridViewTextBoxColumn.HeaderText = "NOTLAR";
            this.nOTLARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOTLARDataGridViewTextBoxColumn.Name = "nOTLARDataGridViewTextBoxColumn";
            this.nOTLARDataGridViewTextBoxColumn.Width = 125;
            // 
            // Excel_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dosya);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Excel_v2";
            this.Text = "Excel_v2";
            this.Load += new System.EventHandler(this.Excel_v2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label Dosya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.BindingSource enerDataSetBindingSource;
        private EnerDataSet enerDataSet;
        private System.Windows.Forms.BindingSource tBLURUNBindingSource;
        private EnerDataSetTableAdapters.TBL_URUNTableAdapter tBL_URUNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oZELLIKLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTLARDataGridViewTextBoxColumn;
    }
}