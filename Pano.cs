using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ener_Otomasyon
{
    public partial class Pano : Form
    {
        public Pano()
        {
            InitializeComponent();
        }
        
        sqlBaglanti bgl = new sqlBaglanti();
        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PANO", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into TBL_PANO (PANOID , PANOTIP, PANOSARF , PANOOLCU ,PANOOZELLIKLER ) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            kaydet.Parameters.AddWithValue("@p1", txt_PANOID.Text);
            kaydet.Parameters.AddWithValue("@p2", txt_PANOTIP.Text);
            kaydet.Parameters.AddWithValue("@p3", richTextBox_PANOSARF.Text);
            kaydet.Parameters.AddWithValue("@p4", txt_PANOOLCU.Text);
            kaydet.Parameters.AddWithValue("@p5", richTextBox_PANOOZELLIKLER.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void Pano_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From TBL_PANO where URUNNO=@p1 ", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txt_PANOID.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_PANO set PANOID=@p1 , PANOTIP=@p2, PANOSARF=@p3 , PANOOLCU=@p4 , PANOOZELLIKLER=@p5  where PANOID=@p8 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txt_PANOID.Text);
            guncelle.Parameters.AddWithValue("@p2", txt_PANOTIP.Text);
            guncelle.Parameters.AddWithValue("@p3", richTextBox_PANOSARF.Text);
            guncelle.Parameters.AddWithValue("@p4", txt_PANOOLCU.Text);
            guncelle.Parameters.AddWithValue("@p5", richTextBox_PANOOZELLIKLER.Text);
            guncelle.Parameters.AddWithValue("@p8", txt_PANOID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
    }
}
