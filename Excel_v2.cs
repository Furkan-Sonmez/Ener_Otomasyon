using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace Ener_Otomasyon
{
    public partial class Excel_v2 : Form
    {
        public Excel_v2()
        {
            InitializeComponent();
        }
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
        }
        DataTableCollection tableCollection;

        private void btn_file_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_file.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTableCollection tables;
            DataTable dt = tables[comboBox1.SelectedItem.ToString()];
            if (dt != null)
            {
                List<Urunler> list = new List<Urunler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Urunler obj = new Urunler();
                    obj.URUNAD = dt.Rows[i]["URUNAD"].ToString();
                    obj.URUNNO = dt.Rows[i]["URUNNO"].ToString();
                    obj.MARKA = dt.Rows[i]["MARKA"].ToString();
                    obj.MARKA = dt.Rows[i]["MARKA"].ToString();
                    obj.ADET = dt.Rows[i]["ADET"].ToString();
                    obj.OZELLIKLER = dt.Rows[i]["OZELLIKLER"].ToString();
                    obj.NOTLAR = dt.Rows[i]["NOTLAR"].ToString();
                  
                    list.Add(obj);
                }
                 tBLURUNBindingSource.DataSource = list;
            }
        }

        private void Excel_v2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enerDataSet.TBL_URUN' table. You can move, or remove it, as needed.
            this.tBL_URUNTableAdapter.Fill(this.enerDataSet.TBL_URUN);

        }
    }
}
