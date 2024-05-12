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
    public partial class ListProject : Form
    {
        public ListProject()
        {
            InitializeComponent();
        }
        DBCONNEntities db = new DBCONNEntities();
        private void ListProject_Load(object sender, EventArgs e)
        {
            db.TBLProje.Load();
            bindingSource1.DataSource = db.TBLProje.Local;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Create.FrmProject frp = new Create.FrmProject();
            frp.id = int.Parse(gridView1.GetFocusedRowCellValue("ProjeId").ToString());
            frp.Show();
        }
    }
}
