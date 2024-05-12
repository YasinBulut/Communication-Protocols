using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;

namespace CommProtocolApp.Forms.Profinet
{
    public partial class WriteProfinet : Form
    {
        public WriteProfinet()
        {
            InitializeComponent();
        }
        private Plc plc = null;
        private void WriteProfinet_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcpu.DataSource = Enum.GetNames(typeof(CpuType));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), Convert.ToString(cmbcpu.SelectedValue));
                plc = new Plc(cpu, txtip.Text, Convert.ToInt16(cmbrock.SelectedValue), Convert.ToInt16(cmbslot.SelectedValue));
                plc.Open();
                if (plc.IsConnected)
                {
                    profinetbglno.Visible = false;
                    profinetbglyes.Visible = true;
                    bglvar.Visible = true;
                    bglyok.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (plc.IsConnected==true)
            {
                object okunandeger1 = plc.Read("DB100.DBW0");
                object okunandeger2 = plc.Read("DB100.DBW2");
                object okunandeger3 = plc.Read("DB100.DBW4");
                object okunandeger4 = plc.Read("DB100.DBW6");
                object okunandeger5 = plc.Read("DB100.DBW8");
                object okunandeger6 = plc.Read("DB100.DBW10");
                object okunandeger7 = plc.Read("DB100.DBW12");
                object okunandeger8 = plc.Read("DB100.DBW14");
                object okunandeger9 = plc.Read("DB100.DBW16");
                object okunandeger10 = plc.Read("DB100.DBW18");
                object okunandeger11 = plc.Read("DB100.DBW20");
                object okunandeger12 = plc.Read("DB100.DBW22");
                object okunandeger13 = plc.Read("DB100.DBW24");
                object okunandeger14 = plc.Read("DB100.DBW26");
                object okunandeger15 = plc.Read("DB100.DBW28");
                object okunandeger16 = plc.Read("DB100.DBW30");
                object okunandeger17 = plc.Read("DB100.DBW32");
                object okunandeger18 = plc.Read("DB100.DBW34");
                var okunandeger19 = (uint)plc.Read("DB100.DBD36.0");
                var okunandeger20 = (uint)plc.Read("DB100.DBD40.0");
                var okunandeger21 = (uint)plc.Read("DB100.DBD44.0");
                var okunandeger22 = (uint)plc.Read("DB100.DBD48.0");
                var okunandeger23 = (uint)plc.Read("DB100.DBD52.0");
                var okunandeger24 = (uint)plc.Read("DB100.DBD56.0");
                var okunandeger25 = (uint)plc.Read("DB100.DBD60.0");
                var okunandeger26 = (uint)plc.Read("DB100.DBD64.0");
                var okunandeger27 = (uint)plc.Read("DB100.DBD68.0");
                object okunandeger28 = plc.Read("DB100.DBX72.0");
                object okunandeger29 = plc.Read("DB100.DBX72.1");
                object okunandeger30 = plc.Read("DB100.DBX72.2");
                object okunandeger31 = plc.Read("DB100.DBX72.3");
                object okunandeger32 = plc.Read("DB100.DBX72.4");
                object okunandeger33 = plc.Read("DB100.DBX72.5");
                object okunandeger34 = plc.Read("DB100.DBX72.6");
                object okunandeger35 = plc.Read("DB100.DBX72.7");
                object okunandeger36 = plc.Read("DB100.DBX73.0");

                writew1.Text = okunandeger1.ToString();
                writew2.Text = okunandeger2.ToString();
                writew3.Text = okunandeger3.ToString();
                writew4.Text = okunandeger4.ToString();
                writew5.Text = okunandeger5.ToString();
                writew6.Text = okunandeger6.ToString();
                writew7.Text = okunandeger7.ToString();
                writew8.Text = okunandeger8.ToString();
                writew9.Text = okunandeger9.ToString();
                writei1.Text = okunandeger10.ToString();
                writei2.Text = okunandeger11.ToString();
                writei3.Text = okunandeger12.ToString();
                writei4.Text = okunandeger13.ToString();
                writei5.Text = okunandeger14.ToString();
                writei6.Text = okunandeger15.ToString();
                writei7.Text = okunandeger16.ToString();
                writei8.Text = okunandeger17.ToString();
                writei9.Text = okunandeger18.ToString();
                writer1.Text = okunandeger19.ToString();
                writer2.Text = okunandeger20.ToString();
                writer3.Text = okunandeger21.ToString();
                writer4.Text = okunandeger22.ToString();
                writer5.Text = okunandeger23.ToString();
                writer6.Text = okunandeger24.ToString();
                writer7.Text = okunandeger25.ToString();
                writer8.Text = okunandeger26.ToString();
                writer9.Text = okunandeger27.ToString();
                writeb1.Text = okunandeger28.ToString();
                writeb2.Text = okunandeger29.ToString();
                writeb3.Text = okunandeger30.ToString();
                writeb4.Text = okunandeger31.ToString();
                writeb5.Text = okunandeger32.ToString();
                writeb6.Text = okunandeger33.ToString();
                writeb7.Text = okunandeger34.ToString();
                writeb8.Text = okunandeger35.ToString();
                writeb9.Text = okunandeger36.ToString();
                writeb1.Checked = Convert.ToBoolean(okunandeger28.ToString());
                writeb2.Checked = Convert.ToBoolean(okunandeger29.ToString());
                writeb3.Checked = Convert.ToBoolean(okunandeger30.ToString());
                writeb4.Checked = Convert.ToBoolean(okunandeger31.ToString());
                writeb5.Checked = Convert.ToBoolean(okunandeger32.ToString());
                writeb6.Checked = Convert.ToBoolean(okunandeger33.ToString());
                writeb7.Checked = Convert.ToBoolean(okunandeger34.ToString());
                writeb8.Checked = Convert.ToBoolean(okunandeger35.ToString());
                writeb9.Checked = Convert.ToBoolean(okunandeger36.ToString());


            }
        }

        private void readb1_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc.IsConnected)
                {
                    plc.Close();
                    profinetbglno.Visible = true;
                    profinetbglyes.Visible = false;
                    bglvar.Visible = false;
                    bglyok.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndataread_Click(object sender, EventArgs e)
        {
            try
            {
                object yazılandeğer1 = Convert.ToUInt16(writew1.Text);
                object yazılandeğer2 = Convert.ToUInt16(writew2.Text);
                object yazılandeğer3 = Convert.ToUInt16(writew3.Text);
                object yazılandeğer4 = Convert.ToUInt16(writew4.Text);
                object yazılandeğer5 = Convert.ToUInt16(writew5.Text);
                object yazılandeğer6 = Convert.ToUInt16(writew6.Text);
                object yazılandeğer7 = Convert.ToUInt16(writew7.Text);
                object yazılandeğer8 = Convert.ToUInt16(writew8.Text);
                object yazılandeğer9 = Convert.ToUInt16(writew9.Text);
                object yazılandeğer10 = Convert.ToInt16(writei1.Text);
                object yazılandeğer11 = Convert.ToInt16(writei2.Text);
                object yazılandeğer12 = Convert.ToInt16(writei3.Text);
                object yazılandeğer13 = Convert.ToInt16(writei4.Text);
                object yazılandeğer14 = Convert.ToInt16(writei5.Text);
                object yazılandeğer15 = Convert.ToInt16(writei6.Text);
                object yazılandeğer16 = Convert.ToInt16(writei7.Text);
                object yazılandeğer17 = Convert.ToInt16(writei8.Text);
                object yazılandeğer18 = Convert.ToInt16(writei9.Text);
                object yazılandeğer19 = Convert.ToSingle(writer1.Text);
                object yazılandeğer20 = Convert.ToSingle(writer2.Text);
                object yazılandeğer21 = Convert.ToSingle(writer3.Text);
                object yazılandeğer22 = Convert.ToSingle(writer4.Text);
                object yazılandeğer23 = Convert.ToSingle(writer5.Text);
                object yazılandeğer24 = Convert.ToSingle(writer6.Text);
                object yazılandeğer25 = Convert.ToSingle(writer7.Text);
                object yazılandeğer26 = Convert.ToSingle(writer8.Text);
                object yazılandeğer27 = Convert.ToSingle(writer9.Text);
                object yazılandeğer28 = Convert.ToBoolean(writeb1.Checked);
                object yazılandeğer29 = Convert.ToBoolean(writeb2.Checked);
                object yazılandeğer30 = Convert.ToBoolean(writeb3.Checked);
                object yazılandeğer31 = Convert.ToBoolean(writeb4.Checked);
                object yazılandeğer32 = Convert.ToBoolean(writeb5.Checked);
                object yazılandeğer33 = Convert.ToBoolean(writeb6.Checked);
                object yazılandeğer34 = Convert.ToBoolean(writeb7.Checked);
                object yazılandeğer35 = Convert.ToBoolean(writeb8.Checked);
                object yazılandeğer36 = Convert.ToBoolean(writeb9.Checked);


                plc.Write("DB100.DBW0", yazılandeğer1);
                plc.Write("DB100.DBW2", yazılandeğer2);
                plc.Write("DB100.DBW4", yazılandeğer3);
                plc.Write("DB100.DBW6", yazılandeğer4);
                plc.Write("DB100.DBW8", yazılandeğer5);
                plc.Write("DB100.DBW10", yazılandeğer6);
                plc.Write("DB100.DBW12", yazılandeğer7);
                plc.Write("DB100.DBW14", yazılandeğer8);
                plc.Write("DB100.DBW16", yazılandeğer9);
                plc.Write("DB100.DBW18", yazılandeğer10);
                plc.Write("DB100.DBW20", yazılandeğer11);
                plc.Write("DB100.DBW22", yazılandeğer12);
                plc.Write("DB100.DBW24", yazılandeğer13);
                plc.Write("DB100.DBW26", yazılandeğer14);
                plc.Write("DB100.DBW28", yazılandeğer15);
                plc.Write("DB100.DBW30", yazılandeğer16);
                plc.Write("DB100.DBW32", yazılandeğer17);
                plc.Write("DB100.DBW34", yazılandeğer18);
                plc.Write("DB100.DBW36", yazılandeğer19);
                plc.Write("DB100.DBW40", yazılandeğer20);
                plc.Write("DB100.DBW44", yazılandeğer21);
                plc.Write("DB100.DBW48", yazılandeğer22);
                plc.Write("DB100.DBW52", yazılandeğer23);
                plc.Write("DB100.DBW56", yazılandeğer24);
                plc.Write("DB100.DBW60", yazılandeğer25);
                plc.Write("DB100.DBW64", yazılandeğer26);
                plc.Write("DB100.DBW68", yazılandeğer27);
                plc.Write("DB100.DBX72.0", yazılandeğer28);
                plc.Write("DB100.DBX72.1", yazılandeğer29);
                plc.Write("DB100.DBX72.2", yazılandeğer30);
                plc.Write("DB100.DBX72.3", yazılandeğer31);
                plc.Write("DB100.DBX72.4", yazılandeğer32);
                plc.Write("DB100.DBX72.5", yazılandeğer33);
                plc.Write("DB100.DBX72.6", yazılandeğer34);
                plc.Write("DB100.DBX72.7", yazılandeğer35);
                plc.Write("DB100.DBX73.1", yazılandeğer36);


            }
            catch (Exception)
            {

                throw;
            }
           

           
        }

    }
}

