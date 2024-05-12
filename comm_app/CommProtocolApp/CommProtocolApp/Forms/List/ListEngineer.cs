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

namespace CommProtocolApp.Forms.List
{
    public partial class ListEngineer : Form
    {
        public ListEngineer()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        private void ListEngineer_Load(object sender, EventArgs e)
        {
           
            db.TBLMuhSet.Load();
            bindingSource1.DataSource = db.TBLMuhSet.Local;

            //var value = (from x in db.TBLMuh
            //             select new
            //             {
            //                 x.MuhAdSoyad,
            //                 x.MuhMail,
            //                 x.MuhDepartment,
            //                 x.MuhPhone,
            //                 x.MuhAciklama,
            //                 x.MuhDurum
            //             });
            //gridControl1.DataSource = value.ToList();

        }
       
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Create.FrmEngineer fre = new Create.FrmEngineer();
            fre.id =int.Parse(gridView1.GetFocusedRowCellValue("MuhId").ToString());  
            fre.Show();
        }
    }
}
