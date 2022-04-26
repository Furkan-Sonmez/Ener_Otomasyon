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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONEL", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        private void groupControlislemler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into TBL_PERSONEL (AD , SOYAD, TEL1 , TEL2 , MAIL , ADRES , TC , SIFRE , PUAN, NOTLAR , MALZEME) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@P11)", bgl.baglanti());

            kaydet.Parameters.AddWithValue("@p1", txt_AD.Text);
            kaydet.Parameters.AddWithValue("@p2", txt_SOYAD.Text);
            kaydet.Parameters.AddWithValue("@p3", txt_TEL1.Text);
            kaydet.Parameters.AddWithValue("@p4", txt_TEL2.Text);
            kaydet.Parameters.AddWithValue("@p5", txt_MAIL.Text);
            kaydet.Parameters.AddWithValue("@p6", richTextBox_ADRES.Text);
            kaydet.Parameters.AddWithValue("@p7", txt_TC.Text);
            kaydet.Parameters.AddWithValue("@p8", txt_SIFRE.Text);
            kaydet.Parameters.AddWithValue("@p9", richTextBox_PUAN.Text);
            kaydet.Parameters.AddWithValue("@p10", richTextBox_NOTLAR.Text);
            kaydet.Parameters.AddWithValue("@p11", richTextBox_MALZEMELERI.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From TBL_PERSONEL where FIRMA=@p1 ", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txt_AD.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_URUN set AD=@p1 , SOYAD=@p2, TEL1=@p3 , TEL2=@p4 , MAIL=@p5 , ADRES=@p6 , TC=@p7 , SIFRE=@p8 , PUAN=@p9 , NOTLAR=@p10, MALZEMELER=@p11    where AD=@p12 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txt_AD.Text);
            guncelle.Parameters.AddWithValue("@p2", txt_SOYAD.Text);
            guncelle.Parameters.AddWithValue("@p3", txt_TEL1.Text);
            guncelle.Parameters.AddWithValue("@p4", txt_TEL2.Text);
            guncelle.Parameters.AddWithValue("@p5", txt_MAIL.Text);
            guncelle.Parameters.AddWithValue("@p6", richTextBox_ADRES.Text);
            guncelle.Parameters.AddWithValue("@p7", txt_TC.Text);
            guncelle.Parameters.AddWithValue("@p8", txt_SIFRE.Text);
            guncelle.Parameters.AddWithValue("@p9", richTextBox_PUAN.Text);
            guncelle.Parameters.AddWithValue("@p10", richTextBox_NOTLAR.Text);
            guncelle.Parameters.AddWithValue("@p11", richTextBox_MALZEMELERI.Text);
            guncelle.Parameters.AddWithValue("@p12", txt_AD.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                mail.mail = dr["MAIL"].ToString();
            }
            mail.Show();
        }
    }
}
