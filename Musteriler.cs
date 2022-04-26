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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        
        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
 

  
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into TBL_FIRMALAR (FIRMA , YETKILI, TEL1 , TEL2 , MAIL , ADRES , PANOTIP , PANOID , TESLIM, PANOSARF) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());

            kaydet.Parameters.AddWithValue("@p1", txt_FIRMA.Text);
            kaydet.Parameters.AddWithValue("@p2", txt_YETKILIAD.Text);
            kaydet.Parameters.AddWithValue("@p3", txt_TEL1.Text);
            kaydet.Parameters.AddWithValue("@p4", txt_TEL2.Text);
            kaydet.Parameters.AddWithValue("@p5", txt_MAIL.Text);
            kaydet.Parameters.AddWithValue("@p6", richTextBox_ADRES.Text);
            kaydet.Parameters.AddWithValue("@p7", txt_PANOTIP.Text);
            kaydet.Parameters.AddWithValue("@p8", txt_PANOID.Text);
            kaydet.Parameters.AddWithValue("@p9", txt_TESLİM.Text);
            kaydet.Parameters.AddWithValue("@p10", richTextBox_PANOSARF.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
            

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From TBL_FIRMALAR where FIRMA=@p1 ", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txt_FIRMA.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_URUN set FIRMA=@p1 , YETKILI=@p2, TEL1=@p3 , TEL2=@p4 , MAIL=@p5 , ADRES=@p6 , PANOTIP=@p7 , PANOID=@p8 , TESLIM=@p9 , PANOSARF=@p10  where FIRMA=@p11 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txt_FIRMA.Text);
            guncelle.Parameters.AddWithValue("@p2", txt_YETKILIAD.Text);
            guncelle.Parameters.AddWithValue("@p3", txt_TEL1.Text);
            guncelle.Parameters.AddWithValue("@p4", txt_TEL2.Text);
            guncelle.Parameters.AddWithValue("@p5", txt_MAIL.Text);
            guncelle.Parameters.AddWithValue("@p6", richTextBox_ADRES.Text);
            guncelle.Parameters.AddWithValue("@p7", txt_PANOTIP.Text);
            guncelle.Parameters.AddWithValue("@p8", txt_PANOID.Text);
            guncelle.Parameters.AddWithValue("@p9", txt_TESLİM.Text);
            guncelle.Parameters.AddWithValue("@p10", richTextBox_PANOSARF.Text);
            guncelle.Parameters.AddWithValue("@p11", txt_FIRMA.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

    }
}
