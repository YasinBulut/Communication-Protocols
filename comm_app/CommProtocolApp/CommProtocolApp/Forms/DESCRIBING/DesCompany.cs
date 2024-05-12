using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommProtocolApp.Entity;
using DevExpress.XtraEditors;

namespace CommProtocolApp.Forms.DESCRIBING
{
    public partial class DesCompany : Form
    {
        public DesCompany()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        private void DesCompany_Load(object sender, EventArgs e)
        {
            db.TblFirma.Load();
            bindingSource1.DataSource = db.TblFirma.Local;

            //var status = (from x in db.TblFirma
            //              select new
            //              {
            //                  x.FirmaAd,
            //                  x.FirmaSehir,
            //                  x.FirmaMail
            //              });
            //gridControl1.DataSource = status.ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {   
                XtraMessageBox.Show("PLEASE CHECK THE VALUES!!","WARNING",MessageBoxButtons.OK);
            }
           
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
