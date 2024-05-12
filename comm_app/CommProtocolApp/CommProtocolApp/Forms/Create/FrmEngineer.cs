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
using CommProtocolApp.Repositories;
using DevExpress.XtraEditors;

namespace CommProtocolApp.Forms.Create
{
    public partial class FrmEngineer : Form
    {
        public FrmEngineer()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        public int id;
        private void FrmEngineer_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            var Muh = repo.Find(x=>x.MuhId==id);
            if (id != 0)
            {
                txtname.Text = Muh.MuhAdSoyad;
                txtmail.Text = Muh.MuhMail;
                txtphone.Text = Muh.MuhPhone;
                txtadress.Text = Muh.MuhAdres;
            }

     
            lookUpEdit2.Properties.DataSource = (from x in db.TBLDep
                                                 select new
                                                 {
                                                     x.DepartmentID,
                                                     x.DepartmentAd
                                                 });


        }
        Repository<TBLMuh> repo = new Repository<TBLMuh>();
        private void btncreate_Click(object sender, EventArgs e)
        { 
            TBLMuh t = new TBLMuh();
            t.MuhAdSoyad = txtname.Text;
            t.MuhMail = txtmail.Text;
            //t.MuhSifre = txtsifre.Texxt;
            t.MuhPhone = txtphone.Text;
            t.MuhAciklama = txtadress.Text;
            t.MuhAciklama = txxtdesc.Text;
            t.MuhDurum = "TRUE";
            repo.TAdd(t);
            XtraMessageBox.Show("Engineer added successfully");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var value = repo.Find(x=>x.MuhId==id);
            value.MuhAdSoyad = txtname.Text;
            value.MuhMail = txtmail.Text;
            //value.MuhSifre = txtsifre.Texxt;
            value.MuhPhone = txtphone.Text;
            //value.MuhAciklama = txtadress.Text;
            //value.MuhAciklama = txxtdesc.Text;
            //value.MuhDurum = "TRUE";
            repo.TUpdate(value);
            XtraMessageBox.Show("Engineer updated successfully");
        }
    }
}
