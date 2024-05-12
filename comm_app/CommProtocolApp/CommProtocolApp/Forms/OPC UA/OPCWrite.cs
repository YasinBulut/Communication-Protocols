using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;

namespace CommProtocolApp.Forms.OPC_UA
{
    public partial class OPCWrite : Form
    {
        public OPCWrite()
        {
            InitializeComponent();
        }

        private void OPCWrite_Load(object sender, EventArgs e)
        {

        }

        private void btndatawrite_Click(object sender, EventArgs e)
        {
            string opcURL = "opc.tcp://195.168.0.1:4840";
            var data1 = "ns=4;i=30"; var data10 = "ns=4;i=39"; var data19 = "ns=4;i=48"; var data28 = "ns=4;i=57";
            var data2 = "ns=4;i=31"; var data11 = "ns=4;i=40"; var data20 = "ns=4;i=49"; var data29 = "ns=4;i=58";
            var data3 = "ns=4;i=32"; var data12 = "ns=4;i=41"; var data21 = "ns=4;i=50"; var data30 = "ns=4;i=59";
            var data4 = "ns=4;i=33"; var data13 = "ns=4;i=42"; var data22 = "ns=4;i=51"; var data31 = "ns=4;i=60";
            var data5 = "ns=4;i=34"; var data14 = "ns=4;i=43"; var data23 = "ns=4;i=52"; var data32 = "ns=4;i=61";
            var data6 = "ns=4;i=35"; var data15 = "ns=4;i=44"; var data24 = "ns=4;i=53"; var data33 = "ns=4;i=62";
            var data7 = "ns=4;i=36"; var data16 = "ns=4;i=45"; var data25 = "ns=4;i=54"; var data34 = "ns=4;i=63";
            var data8 = "ns=4;i=37"; var data17 = "ns=4;i=46"; var data26 = "ns=4;i=55"; var data35 = "ns=4;i=64";
            var data9 = "ns=4;i=38"; var data18 = "ns=4;i=47"; var data27 = "ns=4;i=56"; var data36 = "ns=4;i=65";
            var client = new OpcClient(opcURL);
            client.Connect();
            var value1 = write1.Text; var value10 = write10.Text; var value19 = write19.Text; var value28 = write28.Text;
            var value2 = write2.Text; var value11 = write11.Text; var value20 = write20.Text; var value29 = write29.Text;
            var value3 = write3.Text; var value12 = write12.Text; var value21 = write21.Text; var value30 = write30.Text;
            var value4 = write4.Text; var value13 = write13.Text; var value22 = write22.Text; var value31 = write31.Text;
            var value5 = write5.Text; var value14 = write14.Text; var value23 = write23.Text; var value32 = write32.Text;
            var value6 = write6.Text; var value15 = write15.Text; var value24 = write24.Text; var value33 = write33.Text;
            var value7 = write7.Text; var value16 = write16.Text; var value25 = write25.Text; var value34 = write34.Text;
            var value8 = write8.Text; var value17 = write17.Text; var value26 = write26.Text; var value35 = write35.Text;
            var value9 = write9.Text; var value18 = write18.Text; var value27 = write27.Text; var value36 = write36.Text;


            client.WriteNode(data1, Convert.ToInt16(value1)); client.WriteNode(data10, Convert.ToInt16(value10));
            client.WriteNode(data2, Convert.ToInt16(value2)); client.WriteNode(data11, Convert.ToInt16(value11));
            client.WriteNode(data3, Convert.ToInt16(value3)); client.WriteNode(data12, Convert.ToInt16(value12));
            client.WriteNode(data4, Convert.ToInt16(value4)); client.WriteNode(data13, Convert.ToInt16(value13));
            client.WriteNode(data5, Convert.ToInt16(value5)); client.WriteNode(data14, Convert.ToInt16(value14));
            client.WriteNode(data6, Convert.ToInt16(value6)); client.WriteNode(data15, Convert.ToInt16(value15));
            client.WriteNode(data7, Convert.ToInt16(value7)); client.WriteNode(data16, Convert.ToInt16(value16));
            client.WriteNode(data8, Convert.ToInt16(value8)); client.WriteNode(data17, Convert.ToInt16(value17));
            client.WriteNode(data9, Convert.ToInt16(value9)); client.WriteNode(data18, Convert.ToInt16(value18));

            client.WriteNode(data19, Convert.ToInt16(value19)); client.WriteNode(data28, Convert.ToBoolean(value28));
            client.WriteNode(data20, Convert.ToInt16(value20)); client.WriteNode(data29, Convert.ToBoolean(value29));
            client.WriteNode(data21, Convert.ToInt16(value21)); client.WriteNode(data30, Convert.ToBoolean(value30));
            client.WriteNode(data22, Convert.ToInt16(value22)); client.WriteNode(data31, Convert.ToBoolean(value31));
            client.WriteNode(data23, Convert.ToInt16(value23)); client.WriteNode(data32, Convert.ToBoolean(value32));
            client.WriteNode(data24, Convert.ToInt16(value24)); client.WriteNode(data33, Convert.ToBoolean(value33));
            client.WriteNode(data25, Convert.ToInt16(value25)); client.WriteNode(data34, Convert.ToBoolean(value34));
            client.WriteNode(data26, Convert.ToInt16(value26)); client.WriteNode(data35, Convert.ToBoolean(value35));
            client.WriteNode(data27, Convert.ToInt16(value27)); client.WriteNode(data36, Convert.ToBoolean(value36));
            client.Disconnect();
        }

        private void btndataread_Click(object sender, EventArgs e)
        {
            string opcURL = "opc.tcp://195.168.0.1:4840";
            var data1 = "ns=4;i=30"; var data10 = "ns=4;i=39"; var data19 = "ns=4;i=48"; var data28 = "ns=4;i=57";
            var data2 = "ns=4;i=31"; var data11 = "ns=4;i=40"; var data20 = "ns=4;i=49"; var data29 = "ns=4;i=58";
            var data3 = "ns=4;i=32"; var data12 = "ns=4;i=41"; var data21 = "ns=4;i=50"; var data30 = "ns=4;i=59";
            var data4 = "ns=4;i=33"; var data13 = "ns=4;i=42"; var data22 = "ns=4;i=51"; var data31 = "ns=4;i=60";
            var data5 = "ns=4;i=34"; var data14 = "ns=4;i=43"; var data23 = "ns=4;i=52"; var data32 = "ns=4;i=61";
            var data6 = "ns=4;i=35"; var data15 = "ns=4;i=44"; var data24 = "ns=4;i=53"; var data33 = "ns=4;i=62";
            var data7 = "ns=4;i=36"; var data16 = "ns=4;i=45"; var data25 = "ns=4;i=54"; var data34 = "ns=4;i=63";
            var data8 = "ns=4;i=37"; var data17 = "ns=4;i=46"; var data26 = "ns=4;i=55"; var data35 = "ns=4;i=64";
            var data9 = "ns=4;i=38"; var data18 = "ns=4;i=47"; var data27 = "ns=4;i=56"; var data36 = "ns=4;i=65";
            var client = new OpcClient(opcURL);
            client.Connect();
            var value1 = client.ReadNode(data1); var value10 = client.ReadNode(data10); var value19 = client.ReadNode(data19); var value28 = client.ReadNode(data28);
            var value2 = client.ReadNode(data2); var value11 = client.ReadNode(data11); var value20 = client.ReadNode(data20); var value29 = client.ReadNode(data29);
            var value3 = client.ReadNode(data3); var value12 = client.ReadNode(data12); var value21 = client.ReadNode(data21); var value30 = client.ReadNode(data30);
            var value4 = client.ReadNode(data4); var value13 = client.ReadNode(data13); var value22 = client.ReadNode(data22); var value31 = client.ReadNode(data31);
            var value5 = client.ReadNode(data5); var value14 = client.ReadNode(data14); var value23 = client.ReadNode(data23); var value32 = client.ReadNode(data32);
            var value6 = client.ReadNode(data6); var value15 = client.ReadNode(data15); var value24 = client.ReadNode(data24); var value33 = client.ReadNode(data33);
            var value7 = client.ReadNode(data7); var value16 = client.ReadNode(data16); var value25 = client.ReadNode(data25); var value34 = client.ReadNode(data34);
            var value8 = client.ReadNode(data8); var value17 = client.ReadNode(data17); var value26 = client.ReadNode(data26); var value35 = client.ReadNode(data35);
            var value9 = client.ReadNode(data9); var value18 = client.ReadNode(data18); var value27 = client.ReadNode(data27); var value36 = client.ReadNode(data36);

            write1.Text = value1.ToString(); write10.Text = value10.ToString(); write19.Text = value19.ToString(); write28.Text = value28.ToString();
            write2.Text = value2.ToString(); write11.Text = value11.ToString(); write20.Text = value20.ToString(); write29.Text = value29.ToString();
            write3.Text = value3.ToString(); write12.Text = value12.ToString(); write21.Text = value21.ToString(); write30.Text = value30.ToString();
            write4.Text = value4.ToString(); write13.Text = value13.ToString(); write22.Text = value22.ToString(); write31.Text = value31.ToString();
            write5.Text = value5.ToString(); write14.Text = value14.ToString(); write23.Text = value23.ToString(); write32.Text = value32.ToString();
            write6.Text = value6.ToString(); write15.Text = value15.ToString(); write24.Text = value24.ToString(); write33.Text = value33.ToString();
            write7.Text = value7.ToString(); write16.Text = value16.ToString(); write25.Text = value25.ToString(); write34.Text = value34.ToString();
            write8.Text = value8.ToString(); write17.Text = value17.ToString(); write26.Text = value26.ToString(); write35.Text = value35.ToString();
            write9.Text = value9.ToString(); write18.Text = value18.ToString(); write27.Text = value27.ToString(); write36.Text = value36.ToString();
            client.Disconnect();
        }
    }
}
