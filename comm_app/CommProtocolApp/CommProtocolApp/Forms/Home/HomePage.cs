using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommProtocolApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Create.FrmProject frp = new Forms.Create.FrmProject(); 
            frp.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Create.FrmEngineer fre = new Forms.Create.FrmEngineer();
            fre.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Forms.Home hm = new Forms.Home();
            hm.MdiParent = this;
            hm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesCompany cmp = new Forms.DESCRIBING.DesCompany();
            cmp.Show();

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesCountry cnt = new Forms.DESCRIBING.DesCountry();
            cnt.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesDepartment dpt = new Forms.DESCRIBING.DesDepartment();
            dpt.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesCustomer cus = new Forms.DESCRIBING.DesCustomer();
            cus.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesProject phn = new Forms.DESCRIBING.DesProject();
            phn.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DESCRIBING.DesProtocol prt = new Forms.DESCRIBING.DesProtocol();
            prt.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.List.ListEngineer eng = new Forms.List.ListEngineer();
            eng.MdiParent = this;
            eng.Show();
        }

   

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.List.ListProject prj = new Forms.List.ListProject();
            prj.MdiParent = this;
            prj.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Create.FrmProject prj = new Forms.Create.FrmProject();
            prj.Show();
        }

        private void btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BTNCALCULATOR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnexcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnrate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Settings.Rates rts = new Forms.Settings.Rates();
            rts.MdiParent = this;
            rts.Show();
        }

        private void btnyoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Settings.Youtube yt = new Forms.Settings.Youtube();
            yt.MdiParent = this;
            yt.Show();
        }

        private void btngoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Settings.Google go = new Forms.Settings.Google();
            go.MdiParent = this;
            go.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Profinet.InfoProfinet prf = new Forms.Profinet.InfoProfinet();
            prf.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Modbus.InfoMod mod = new Forms.Modbus.InfoMod();
            mod.Show();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.OPC_UA.InfoOPCUA opc = new Forms.OPC_UA.InfoOPCUA();   
            opc.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SQL_Server.InfoMssql sql = new Forms.SQL_Server.InfoMssql();
            sql.Show();
        }


        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Profinet.ReadProfinet prf = new Forms.Profinet.ReadProfinet();
            prf.MdiParent = this;
            prf.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Profinet.WriteProfinet prf = new Forms.Profinet.WriteProfinet();
            prf.MdiParent = this;
            prf.Show();
        }


        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Modbus.ReadModbus mod = new Forms.Modbus.ReadModbus();
            mod.MdiParent = this;
            mod.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Modbus.WriteModbus mod = new Forms.Modbus.WriteModbus();
            mod.MdiParent = this;
            mod.Show();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.OPC_UA.OPCRead opc = new Forms.OPC_UA.OPCRead();
            opc.MdiParent = this;
            opc.Show();
        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.OPC_UA.OPCWrite opc = new Forms.OPC_UA.OPCWrite();
            opc.MdiParent = this;
            opc.Show();
        }


        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SQL_Server.SqlRead sql = new Forms.SQL_Server.SqlRead();
            sql.MdiParent = this;
            sql.Show();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SQL_Server.SqlWrite sql = new Forms.SQL_Server.SqlWrite();
            sql.MdiParent = this;
            sql.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Home hme = new Forms.Home();
            hme.MdiParent = this;
            hme.Show();
        }
    }
}
