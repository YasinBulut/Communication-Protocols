using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace CommProtocolApp.Forms.SQL_Server
{
    public partial class SqlRead : Form
    {
        
        public SqlRead()
        {
            InitializeComponent();
        }
        private void SqlRead_Load(object sender, EventArgs e)
        {
           
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8N9D;Initial Catalog=DBCONN;Integrated Security=True;MultipleActiveResultSets=True");
        private void btndataread_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand select1 = new SqlCommand("Select (DataValue) From Data where DataId=1",baglan);
            SqlCommand select2 = new SqlCommand("Select (DataValue) From Data where DataId=2", baglan);
            SqlCommand select3 = new SqlCommand("Select (DataValue) From Data where DataId=3", baglan);
            SqlCommand select4 = new SqlCommand("Select (DataValue) From Data where DataId=4", baglan);
            SqlCommand select5 = new SqlCommand("Select (DataValue) From Data where DataId=5", baglan);
            SqlCommand select6 = new SqlCommand("Select (DataValue) From Data where DataId=6", baglan);
            SqlCommand select7 = new SqlCommand("Select (DataValue) From Data where DataId=7", baglan);
            SqlCommand select8 = new SqlCommand("Select (DataValue) From Data where DataId=8", baglan);
            SqlCommand select9 = new SqlCommand("Select (DataValue) From Data where DataId=9", baglan);
            SqlCommand select10 = new SqlCommand("Select (DataValue) From Data where DataId=10", baglan);
            SqlCommand select11 = new SqlCommand("Select (DataValue) From Data where DataId=11", baglan);
            SqlCommand select12 = new SqlCommand("Select (DataValue) From Data where DataId=12", baglan);
            SqlCommand select13 = new SqlCommand("Select (DataValue) From Data where DataId=13", baglan);
            SqlCommand select14 = new SqlCommand("Select (DataValue) From Data where DataId=14", baglan);
            SqlCommand select15 = new SqlCommand("Select (DataValue) From Data where DataId=15", baglan);
            SqlCommand select16 = new SqlCommand("Select (DataValue) From Data where DataId=16", baglan);
            SqlCommand select17 = new SqlCommand("Select (DataValue) From Data where DataId=17", baglan);
            SqlCommand select18 = new SqlCommand("Select (DataValue) From Data where DataId=18", baglan);
            SqlCommand select19 = new SqlCommand("Select (DataValue) From Data where DataId=19", baglan);
            SqlCommand select20 = new SqlCommand("Select (DataValue) From Data where DataId=20", baglan);
            SqlCommand select21 = new SqlCommand("Select (DataValue) From Data where DataId=21", baglan);
            SqlCommand select22 = new SqlCommand("Select (DataValue) From Data where DataId=22", baglan);
            SqlCommand select23 = new SqlCommand("Select (DataValue) From Data where DataId=23", baglan);
            SqlCommand select24 = new SqlCommand("Select (DataValue) From Data where DataId=24", baglan);
            SqlCommand select25 = new SqlCommand("Select (DataValue) From Data where DataId=25", baglan);
            SqlCommand select26 = new SqlCommand("Select (DataValue) From Data where DataId=26", baglan);
            SqlCommand select27 = new SqlCommand("Select (DataValue) From Data where DataId=27", baglan);
            SqlCommand select28 = new SqlCommand("Select (DataValue) From Data where DataId=28", baglan);
            SqlCommand select29 = new SqlCommand("Select (DataValue) From Data where DataId=29", baglan);
            SqlCommand select30 = new SqlCommand("Select (DataValue) From Data where DataId=30", baglan);
            SqlCommand select31 = new SqlCommand("Select (DataValue) From Data where DataId=31", baglan);
            SqlCommand select32 = new SqlCommand("Select (DataValue) From Data where DataId=32", baglan);
            SqlCommand select33 = new SqlCommand("Select (DataValue) From Data where DataId=33", baglan);
            SqlCommand select34 = new SqlCommand("Select (DataValue) From Data where DataId=34", baglan);
            SqlCommand select35 = new SqlCommand("Select (DataValue) From Data where DataId=35", baglan);
            SqlCommand select36 = new SqlCommand("Select (DataValue) From Data where DataId=36", baglan);

            SqlDataReader reads1 = select1.ExecuteReader();
            while (reads1.Read())
            {
                read1.Text = reads1["DataValue"].ToString();

            }
            SqlDataReader reads2 = select2.ExecuteReader();
            while (reads2.Read())
            {
                read2.Text = reads2["DataValue"].ToString();

            }
            SqlDataReader reads3 = select3.ExecuteReader();
            while (reads3.Read())
            {
                read3.Text = reads3["DataValue"].ToString();

            }
            SqlDataReader reads4 = select4.ExecuteReader();
            while (reads4.Read())
            {
                read4.Text = reads4["DataValue"].ToString();

            }
            SqlDataReader reads5 = select5.ExecuteReader();
            while (reads5.Read())
            {
                read5.Text = reads5["DataValue"].ToString();

            }
            SqlDataReader reads6 = select6.ExecuteReader();
            while (reads6.Read())
            {
                read6.Text = reads6["DataValue"].ToString();

            }
            SqlDataReader reads7 = select7.ExecuteReader();
            while (reads7.Read())
            {
                read7.Text = reads7["DataValue"].ToString();

            }
            SqlDataReader reads8 = select8.ExecuteReader();
            while (reads8.Read())
            {
                read8.Text = reads8["DataValue"].ToString();

            }
            SqlDataReader reads9 = select9.ExecuteReader();
            while (reads9.Read())
            {
                read9.Text = reads9["DataValue"].ToString();

            }
            SqlDataReader reads10 = select10.ExecuteReader();
            while (reads10.Read())
            {
                read10.Text = reads10["DataValue"].ToString();

            }
            SqlDataReader reads11 = select11.ExecuteReader();
            while (reads11.Read())
            {
                read11.Text = reads11["DataValue"].ToString();

            }
            SqlDataReader reads12 = select12.ExecuteReader();
            while (reads12.Read())
            {
                read12.Text = reads12["DataValue"].ToString();

            }
            SqlDataReader reads13 = select13.ExecuteReader();
            while (reads13.Read())
            {
                read13.Text = reads13["DataValue"].ToString();

            }
            SqlDataReader reads14 = select14.ExecuteReader();
            while (reads14.Read())
            {
                read14.Text = reads14["DataValue"].ToString();

            }
            SqlDataReader reads15 = select15.ExecuteReader();
            while (reads15.Read())
            {
                read15.Text = reads15["DataValue"].ToString();

            }
            SqlDataReader reads16 = select16.ExecuteReader();
            while (reads16.Read())
            {
                read16.Text = reads16["DataValue"].ToString();

            }
            SqlDataReader reads17 = select17.ExecuteReader();
            while (reads17.Read())
            {
                read17.Text = reads17["DataValue"].ToString();

            }
            SqlDataReader reads18 = select18.ExecuteReader();
            while (reads18.Read())
            {
                read18.Text = reads18["DataValue"].ToString();

            }
            SqlDataReader reads19 = select19.ExecuteReader();
            while (reads19.Read())
            {
                read19.Text = reads19["DataValue"].ToString();

            }
            SqlDataReader reads20 = select20.ExecuteReader();
            while (reads20.Read())
            {
                read20.Text = reads20["DataValue"].ToString();

            }
            SqlDataReader reads21 = select21.ExecuteReader();
            while (reads21.Read())
            {
                read21.Text = reads21["DataValue"].ToString();

            }
            SqlDataReader reads22 = select22.ExecuteReader();
            while (reads22.Read())
            {
                read22.Text = reads22["DataValue"].ToString();

            }
            SqlDataReader reads23 = select23.ExecuteReader();
            while (reads23.Read())
            {
                read23.Text = reads23["DataValue"].ToString();

            }
            SqlDataReader reads24 = select24.ExecuteReader();
            while (reads24.Read())
            {
                read24.Text = reads24["DataValue"].ToString();

            }
            SqlDataReader reads25 = select25.ExecuteReader();
            while (reads25.Read())
            {
                read25.Text = reads25["DataValue"].ToString();

            }
            SqlDataReader reads26 = select26.ExecuteReader();
            while (reads26.Read())
            {
                read26.Text = reads26["DataValue"].ToString();

            }
            SqlDataReader reads27 = select27.ExecuteReader();
            while (reads27.Read())
            {
                read27.Text = reads27["DataValue"].ToString();

            }
            SqlDataReader reads28 = select28.ExecuteReader();
            while (reads28.Read())
            {
                read28.Text = reads28["DataValue"].ToString();

            }
            SqlDataReader reads29 = select29.ExecuteReader();
            while (reads29.Read())
            {
                read29.Text = reads29["DataValue"].ToString();

            }
            SqlDataReader reads30 = select30.ExecuteReader();
            while (reads30.Read())
            {
                read30.Text = reads30["DataValue"].ToString();

            }
            SqlDataReader reads31 = select31.ExecuteReader();
            while (reads31.Read())
            {
                read31.Text = reads31["DataValue"].ToString();

            }
            SqlDataReader reads32 = select32.ExecuteReader();
            while (reads32.Read())
            {
                read32.Text = reads32["DataValue"].ToString();

            }
            SqlDataReader reads33 = select33.ExecuteReader();
            while (reads33.Read())
            {
                read33.Text = reads33["DataValue"].ToString();

            }
            SqlDataReader reads34 = select34.ExecuteReader();
            while (reads34.Read())
            {
                read34.Text = reads34["DataValue"].ToString();

            }
            SqlDataReader reads35 = select35.ExecuteReader();
            while (reads35.Read())
            {
                read35.Text = reads35["DataValue"].ToString();

            }
            SqlDataReader reads36 = select36.ExecuteReader();
            while (reads36.Read())
            {
                read36.Text = reads36["DataValue"].ToString();

            }

            baglan.Close();
        }
    }
}
