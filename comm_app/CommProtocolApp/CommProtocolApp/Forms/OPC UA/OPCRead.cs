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
    public partial class OPCRead : Form
    {
        public OPCRead()
        {
            InitializeComponent();
        }

        private void OPCRead_Load(object sender, EventArgs e)
        {


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

            read1.Text = value1.ToString(); read10.Text = value10.ToString(); read19.Text = value19.ToString(); read28.Text = value28.ToString();
            read2.Text = value2.ToString(); read11.Text = value11.ToString(); read20.Text = value20.ToString(); read29.Text = value29.ToString();
            read3.Text = value3.ToString(); read12.Text = value12.ToString(); read21.Text = value21.ToString(); read30.Text = value30.ToString();
            read4.Text = value4.ToString(); read13.Text = value13.ToString(); read22.Text = value22.ToString(); read31.Text = value31.ToString();
            read5.Text = value5.ToString(); read14.Text = value14.ToString(); read23.Text = value23.ToString(); read32.Text = value32.ToString();
            read6.Text = value6.ToString(); read15.Text = value15.ToString(); read24.Text = value24.ToString(); read33.Text = value33.ToString();
            read7.Text = value7.ToString(); read16.Text = value16.ToString(); read25.Text = value25.ToString(); read34.Text = value34.ToString();
            read8.Text = value8.ToString(); read17.Text = value17.ToString(); read26.Text = value26.ToString(); read35.Text = value35.ToString();
            read9.Text = value9.ToString(); read18.Text = value18.ToString(); read27.Text = value27.ToString(); read36.Text = value36.ToString();

            client.Disconnect();
        }


    }
}
