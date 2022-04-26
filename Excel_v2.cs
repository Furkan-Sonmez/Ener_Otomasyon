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
        public void Insert(List<urunler> list)
        {
            DapperPlusManager.Entity<urunler>().Table("Customers");
            using (IDbConnection db = new SqlConnection("Server=.;Database=dbtest;User Id=sa;Password=123@qaz;"))
            {
                db.BulkInsert(list);
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Insert(tBLURUNBindingSource.DataSource as List<Customer>);
                MessageBox.Show("Finished !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void Excel_v2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enerDataSet.TBL_URUN' table. You can move, or remove it, as needed.
            this.tBL_URUNTableAdapter.Fill(this.enerDataSet.TBL_URUN);

        }
    }
}
