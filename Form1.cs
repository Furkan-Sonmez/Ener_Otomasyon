using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ener_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Malzemeler Malzeme; 
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Malzeme = new Malzemeler();
            Malzeme.MdiParent = this;
            Malzeme.Show();
        }
        Excel_v2 Excel; 
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Excel = new Excel_v2();
            Excel.MdiParent = this;
            Excel.Show();

        }
        Musteriler musteriler = new Musteriler();
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musteriler = new Musteriler();
            musteriler.MdiParent = this;    
            musteriler.Show();

        }
        Personel personel = new Personel();
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personel = new Personel();
            personel.MdiParent = this;
            personel.Show();
        }
        Barkod barkod = new Barkod();
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barkod = new Barkod();
            barkod.MdiParent = this;
            barkod.Show();
        }
        Pano pano = new Pano();
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pano = new Pano();
            pano.MdiParent = this;
            pano.Show();
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (barkod.captureDevice.IsRunning)
            {
                barkod.captureDevice.Stop();
            }
            



        }
    }
}
