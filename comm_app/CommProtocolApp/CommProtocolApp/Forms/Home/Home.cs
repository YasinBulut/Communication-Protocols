using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommProtocolApp.Entity;

namespace CommProtocolApp.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        private void Home_Load(object sender, EventArgs e)
        {
            //Porject List
            gridControl1.DataSource = (from x in db.TBLProje
                                       select new
                                       {
                                           x.ProjeAd,
                                           x.TBLSehir.SehirAd,
                                           x.TBLProtokol.ProtokAd
                                       }).ToList();

            //Project - Engineer
            gridControl4.DataSource = (from x in db.TBLProje
                                       select new
                                       {
                                           x.ProjeAd,
                                           x.TBLMuh.MuhAdSoyad
                                       }).ToList();

            //Engineer List
            gridControl3.DataSource = (from x in db.TBLMuhSet
                                       select new
                                       {
                                           x.MuhAdSoyad,
                                           x.MuhDurum
                                       }).ToList();
            //gridView2.Columns["MuhDurum"].Visible = false;

            //Protocol List
            gridControl2.DataSource = (from x in db.TBLProtokol
                                       select new
                                       {
                                           x.ProtokAd
                                       }).ToList();

            //Ürün-Stok Grafiği
            //var values = db.TBLProje.ToList();
            //foreach (var x in values)
            //{
            //    chartControl1.Series["Project-Protocol"].Points.AddPoint(x.ProjeAd, double.Parse(x.TBLProtokol.ProtokAd));
            //}


        }

    }
}
