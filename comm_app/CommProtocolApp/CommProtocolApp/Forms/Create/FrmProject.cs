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
    public partial class FrmProject : Form
    {
        public FrmProject()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        public int id;
        private void FrmProject_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            var prj = repop.Find(x =>x.ProjeId == id);
            if (id != 0)
            {
                txtname.Text = prj.ProjeAd;
                //txteng.Text = prj.ProjeMuh;
                //txtcity.Text = prj.ProjeSehir;
                txtexpl.Text = prj.ProjeAciklama;
            }


            lkprotocol.Properties.DataSource = (from x in db.TBLDep
                                                 select new
                                                 {
                                                     x.DepartmentID,
                                                     x.DepartmentAd
                                                 });           
        }
        Repository<TBLProje> repop = new Repository<TBLProje>();

        private void btncreate_Click(object sender, EventArgs e)
        {
            TBLProje p = new TBLProje();
            p.ProjeAd = txtname.Text;
            //p.ProjeMuh =  Convert.ToInt16(txteng.Text); //linked data address
            //p.ProjeSehir = Convert.ToInt16(txteng.Text);  // linked data address
            p.TBLProtokol.ProtokAd = lkprotocol.Text;
            p.ProjeDurum = "TRUE";
            repop.TAdd(p);
            XtraMessageBox.Show("Project added successfully");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var value = repop.Find(x => x.ProjeId == id);
            value.ProjeAd = txtname.Text;
            //value.ProjeMuh = txteng.Text;  //linked data address
            //value.ProjeSehir = txtcity.Text; //linked data address
            value.ProjeAciklama = txtexpl.Text;
            repop.TUpdate(value);
            XtraMessageBox.Show("Project updated successfully");
        }
    }
}
