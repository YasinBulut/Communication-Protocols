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
    public partial class ReadProfinet : Form
    {
        private Plc plc = null;
        public ReadProfinet()
        {
            InitializeComponent();
        }
        //string wordadres1 = "DB100.DBW0"; string wordadres2 = "DB100.DBW2"; string wordadres3 = "DB100.DBW4"; string wordadres4 = "DB100.DBW6"; string wordadres5 = "DB100.DBW8";
        //string wordadres6 = "DB100.DBW10"; string wordadres7 = "DB100.DBW12"; string wordadres8 = "DB100.DBW14"; string wordadres9 = "DB100.DBW16";
        //string intadres1 = "DB100.DBW18"; string intadres2 = "DB100.DBW20"; string intadres3 = "DB100.DBW22"; string intadres4 = "DB100.DBW24"; string intadres5 = "DB100.DBW26";
        //string intadres6 = "DB100.DBW28"; string intadres7 = "DB100.DBW30"; string intadres8 = "DB100.DBW32"; string intadres9 = "DB100.DBW34";
        ////string realadres1= "DB100.DBD20";
        ////string realadres2 = "DB100.DBD24"; string realadres3 = "DB100.DBD28"; string realadres4 = "DB100.DBD32";
        ////string realadres5 = "DB100.DBD36"; string realadres6 = "DB100.DBD40"; string realadres7 = "DB100.DBD44"; string realadres8 = "DB100.DBD48"; string realadres9 = "DB100.DBD52"; string realadres10 = "DB100.DBD56";
        //string booladres1 = "DB100.DBX60.0"; string booladres2 = "DB100.DBX60.1"; string booladres3 = "DB100.DBX60.2"; string booladres4 = "DB100.DBX60.3"; string booladres5 = "DB100.DBX60.4"; string booladres6 = "DB100.DBX60.5"; string booladres7 = "DB100.DBX60.6"; string booladres8 = "DB100.DBX60.7";

        private void button4_Click(object sender, EventArgs e)
        {
            try
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



                readw1.Text = okunandeger1.ToString();
                readw2.Text = okunandeger2.ToString();
                readw3.Text = okunandeger3.ToString();
                readw4.Text = okunandeger4.ToString();
                readw5.Text = okunandeger5.ToString();
                readw6.Text = okunandeger6.ToString();
                readw7.Text = okunandeger7.ToString();
                readw8.Text = okunandeger8.ToString();
                readw9.Text = okunandeger9.ToString();
                readi1.Text = okunandeger10.ToString();
                readi2.Text = okunandeger11.ToString();
                readi3.Text = okunandeger12.ToString();
                readi4.Text = okunandeger13.ToString();
                readi5.Text = okunandeger14.ToString();
                readi6.Text = okunandeger15.ToString();
                readi7.Text = okunandeger16.ToString();
                readi8.Text = okunandeger17.ToString();
                readi9.Text = okunandeger18.ToString();
                readr1.Text = okunandeger19.ToString();
                readr2.Text = okunandeger20.ToString();
                readr3.Text = okunandeger21.ToString();
                readr4.Text = okunandeger22.ToString();
                readr5.Text = okunandeger23.ToString();
                readr6.Text = okunandeger24.ToString();
                readr7.Text = okunandeger25.ToString();
                readr8.Text = okunandeger26.ToString();
                readr9.Text = okunandeger27.ToString();
                readb1.Text = Convert.ToBoolean(okunandeger28).ToString();
                readb2.Text = Convert.ToBoolean(okunandeger29).ToString();
                readb3.Text = Convert.ToBoolean(okunandeger30).ToString();
                readb4.Text = Convert.ToBoolean(okunandeger31).ToString();
                readb5.Text = Convert.ToBoolean(okunandeger32).ToString();
                readb6.Text = Convert.ToBoolean(okunandeger33).ToString();
                readb7.Text = Convert.ToBoolean(okunandeger34).ToString();
                readb8.Text = Convert.ToBoolean(okunandeger35).ToString();
                readb9.Text = Convert.ToBoolean(okunandeger36).ToString();
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
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void ReadProfinet_Load(object sender, EventArgs e)
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
    }

}

