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
    public partial class Malzemeler : Form
    {
        public Malzemeler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti(); 
        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUN",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Malzemeler_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        { 
            SqlCommand kaydet = new SqlCommand("insert into TBL_URUN (URUNAD , URUNNO, MARKA , MODEL , ADET , OZELLIKLER , NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());

            kaydet.Parameters.AddWithValue("@p1",txt_URUNAD.Text);
            kaydet.Parameters.AddWithValue("@p2",txt_URUNNO.Text);
            kaydet.Parameters.AddWithValue("@p3",txt_MARKA.Text);
            kaydet.Parameters.AddWithValue("@p4",txt_MODEL.Text);
            kaydet.Parameters.AddWithValue("@p5",int.Parse(txt_ADET.Text));
            kaydet.Parameters.AddWithValue("@p6",richTextBox_OZELLIKLER.Text);
            kaydet.Parameters.AddWithValue("@p7",richTextBox_NOT.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
            txt_URUNAD.Text = "";
            txt_URUNNO.Text = "";
            txt_MARKA.Text = "";
            txt_MODEL.Text = "";
            txt_ADET.Text = "";
            richTextBox_OZELLIKLER.Text = "";
            richTextBox_NOT.Text = "";

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From TBL_URUN where URUNNO=@p1 ", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txt_URUNNO.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
            txt_URUNAD.Text = "";
            txt_URUNNO.Text = "";
            txt_MARKA.Text = "";
            txt_MODEL.Text = "";
            txt_ADET.Text = "";
            richTextBox_OZELLIKLER.Text = "";
            richTextBox_NOT.Text = "";
        }
     
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_URUN set URUNAD=@p1 , URUNNO=@p2, MARKA=@p3 , MODEL=@p4 , ADET=@p5 , OZELLIKLER=@p6 , NOTLAR=@p7 where URUNNO=@p8 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txt_URUNAD.Text);
            guncelle.Parameters.AddWithValue("@p2", txt_URUNNO.Text);
            guncelle.Parameters.AddWithValue("@p3", txt_MARKA.Text);
            guncelle.Parameters.AddWithValue("@p4", txt_MODEL.Text);
            guncelle.Parameters.AddWithValue("@p5", int.Parse(txt_ADET.Text));
            guncelle.Parameters.AddWithValue("@p6", richTextBox_OZELLIKLER.Text);
            guncelle.Parameters.AddWithValue("@p7", richTextBox_NOT.Text);
            guncelle.Parameters.AddWithValue("@p8", txt_URUNNO.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
            txt_URUNAD.Text = "";
            txt_URUNNO.Text = "";
            txt_MARKA.Text = "";
            txt_MODEL.Text = "";
            txt_ADET.Text = "";
            richTextBox_OZELLIKLER.Text = "";
            richTextBox_NOT.Text = "";
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txt_URUNAD.Text = dr["URUNAD"].ToString();
                txt_URUNNO.Text = dr["URUNNO"].ToString();
                txt_MARKA.Text = dr["MARKA"].ToString();
                txt_MODEL.Text = dr["MODEL"].ToString();
                txt_ADET.Text = dr["ADET"].ToString();
                richTextBox_OZELLIKLER.Text = dr["OZELLIKLER"].ToString();
                richTextBox_NOT.Text = dr["NOTLAR"].ToString();
                labelControl2.Text = "girdi ";
            }

        }
    }
}
