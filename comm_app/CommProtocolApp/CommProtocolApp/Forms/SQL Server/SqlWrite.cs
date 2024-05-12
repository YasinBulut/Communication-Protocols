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
    public partial class SqlWrite : Form
    {
        public SqlWrite()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btndatawrite_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Update Data set DataValue=@p1 where DataId=1", bgl.baglanti());
            SqlCommand cmd2 = new SqlCommand("Update Data set DataValue=@p1 where DataId=2", bgl.baglanti());
            SqlCommand cmd3 = new SqlCommand("Update Data set DataValue=@p1 where DataId=3", bgl.baglanti());
            SqlCommand cmd4 = new SqlCommand("Update Data set DataValue=@p1 where DataId=4", bgl.baglanti());
            SqlCommand cmd5 = new SqlCommand("Update Data set DataValue=@p1 where DataId=5", bgl.baglanti());
            SqlCommand cmd6 = new SqlCommand("Update Data set DataValue=@p1 where DataId=6", bgl.baglanti());
            SqlCommand cmd7 = new SqlCommand("Update Data set DataValue=@p1 where DataId=7", bgl.baglanti());
            SqlCommand cmd8 = new SqlCommand("Update Data set DataValue=@p1 where DataId=8", bgl.baglanti());
            SqlCommand cmd9 = new SqlCommand("Update Data set DataValue=@p1 where DataId=9", bgl.baglanti());
            SqlCommand cmd10 = new SqlCommand("Update Data set DataValue=@p1 where DataId=10", bgl.baglanti());
            SqlCommand cmd11 = new SqlCommand("Update Data set DataValue=@p1 where DataId=11", bgl.baglanti());
            SqlCommand cmd12 = new SqlCommand("Update Data set DataValue=@p1 where DataId=12", bgl.baglanti());
            SqlCommand cmd13 = new SqlCommand("Update Data set DataValue=@p1 where DataId=13", bgl.baglanti());
            SqlCommand cmd14 = new SqlCommand("Update Data set DataValue=@p1 where DataId=14", bgl.baglanti());
            SqlCommand cmd15 = new SqlCommand("Update Data set DataValue=@p1 where DataId=15", bgl.baglanti());
            SqlCommand cmd16 = new SqlCommand("Update Data set DataValue=@p1 where DataId=16", bgl.baglanti());
            SqlCommand cmd17 = new SqlCommand("Update Data set DataValue=@p1 where DataId=17", bgl.baglanti());
            SqlCommand cmd18 = new SqlCommand("Update Data set DataValue=@p1 where DataId=18", bgl.baglanti());
            SqlCommand cmd19 = new SqlCommand("Update Data set DataValue=@p1 where DataId=19", bgl.baglanti());
            SqlCommand cmd20 = new SqlCommand("Update Data set DataValue=@p1 where DataId=20", bgl.baglanti());
            SqlCommand cmd21 = new SqlCommand("Update Data set DataValue=@p1 where DataId=21", bgl.baglanti());
            SqlCommand cmd22 = new SqlCommand("Update Data set DataValue=@p1 where DataId=22", bgl.baglanti());
            SqlCommand cmd23 = new SqlCommand("Update Data set DataValue=@p1 where DataId=23", bgl.baglanti());
            SqlCommand cmd24 = new SqlCommand("Update Data set DataValue=@p1 where DataId=24", bgl.baglanti());
            SqlCommand cmd25 = new SqlCommand("Update Data set DataValue=@p1 where DataId=25", bgl.baglanti());
            SqlCommand cmd26 = new SqlCommand("Update Data set DataValue=@p1 where DataId=26", bgl.baglanti());
            SqlCommand cmd27 = new SqlCommand("Update Data set DataValue=@p1 where DataId=27", bgl.baglanti());
            SqlCommand cmd28 = new SqlCommand("Update Data set DataValue=@p1 where DataId=28", bgl.baglanti());
            SqlCommand cmd29 = new SqlCommand("Update Data set DataValue=@p1 where DataId=29", bgl.baglanti());
            SqlCommand cmd30 = new SqlCommand("Update Data set DataValue=@p1 where DataId=30", bgl.baglanti());
            SqlCommand cmd31 = new SqlCommand("Update Data set DataValue=@p1 where DataId=31", bgl.baglanti());
            SqlCommand cmd32 = new SqlCommand("Update Data set DataValue=@p1 where DataId=32", bgl.baglanti());
            SqlCommand cmd33 = new SqlCommand("Update Data set DataValue=@p1 where DataId=33", bgl.baglanti());
            SqlCommand cmd34 = new SqlCommand("Update Data set DataValue=@p1 where DataId=34", bgl.baglanti());
            SqlCommand cmd35 = new SqlCommand("Update Data set DataValue=@p1 where DataId=35", bgl.baglanti());
            SqlCommand cmd36 = new SqlCommand("Update Data set DataValue=@p1 where DataId=36", bgl.baglanti());
            //Word
            cmd1.Parameters.AddWithValue("@p1",write1.Text);  
            cmd2.Parameters.AddWithValue("@p1",write2.Text);
            cmd3.Parameters.AddWithValue("@p1",write3.Text);
            cmd4.Parameters.AddWithValue("@p1",write4.Text);
            cmd5.Parameters.AddWithValue("@p1",write5.Text);
            cmd6.Parameters.AddWithValue("@p1",write6.Text);
            cmd7.Parameters.AddWithValue("@p1",write7.Text);
            cmd8.Parameters.AddWithValue("@p1",write8.Text);
            cmd9.Parameters.AddWithValue("@p1",write9.Text);
            cmd10.Parameters.AddWithValue("@p1",write10.Text);
            cmd11.Parameters.AddWithValue("@p1",write11.Text);
            cmd12.Parameters.AddWithValue("@p1",write12.Text);
            cmd13.Parameters.AddWithValue("@p1",write13.Text);
            cmd14.Parameters.AddWithValue("@p1",write14.Text);
            cmd15.Parameters.AddWithValue("@p1",write15.Text);
            cmd16.Parameters.AddWithValue("@p1",write16.Text);
            cmd17.Parameters.AddWithValue("@p1",write17.Text);
            cmd18.Parameters.AddWithValue("@p1",write18.Text);
            cmd19.Parameters.AddWithValue("@p1",write19.Text);
            cmd20.Parameters.AddWithValue("@p1",write20.Text);
            cmd21.Parameters.AddWithValue("@p1",write21.Text);
            cmd22.Parameters.AddWithValue("@p1",write22.Text);
            cmd23.Parameters.AddWithValue("@p1",write23.Text);
            cmd24.Parameters.AddWithValue("@p1",write24.Text);
            cmd25.Parameters.AddWithValue("@p1",write25.Text);
            cmd26.Parameters.AddWithValue("@p1",write26.Text);
            cmd27.Parameters.AddWithValue("@p1",write27.Text);
            cmd28.Parameters.AddWithValue("@p1",write28.Text);
            cmd29.Parameters.AddWithValue("@p1",write29.Text);
            cmd30.Parameters.AddWithValue("@p1",write30.Text);
            cmd31.Parameters.AddWithValue("@p1",write31.Text);
            cmd32.Parameters.AddWithValue("@p1",write32.Text);
            cmd33.Parameters.AddWithValue("@p1",write33.Text);
            cmd34.Parameters.AddWithValue("@p1",write34.Text);
            cmd35.Parameters.AddWithValue("@p1",write35.Text);
            cmd36.Parameters.AddWithValue("@p1",write36.Text);
            
            cmd1.ExecuteNonQuery(); cmd13.ExecuteNonQuery(); cmd25.ExecuteNonQuery();
            cmd2.ExecuteNonQuery(); cmd14.ExecuteNonQuery(); cmd26.ExecuteNonQuery();
            cmd3.ExecuteNonQuery(); cmd15.ExecuteNonQuery(); cmd27.ExecuteNonQuery();
            cmd4.ExecuteNonQuery(); cmd16.ExecuteNonQuery(); cmd28.ExecuteNonQuery();
            cmd5.ExecuteNonQuery(); cmd17.ExecuteNonQuery(); cmd29.ExecuteNonQuery();
            cmd6.ExecuteNonQuery(); cmd18.ExecuteNonQuery(); cmd30.ExecuteNonQuery();
            cmd7.ExecuteNonQuery(); cmd19.ExecuteNonQuery(); cmd31.ExecuteNonQuery();
            cmd8.ExecuteNonQuery(); cmd20.ExecuteNonQuery(); cmd32.ExecuteNonQuery();
            cmd9.ExecuteNonQuery(); cmd21.ExecuteNonQuery(); cmd33.ExecuteNonQuery();
            cmd10.ExecuteNonQuery(); cmd22.ExecuteNonQuery(); cmd34.ExecuteNonQuery();
            cmd11.ExecuteNonQuery(); cmd23.ExecuteNonQuery(); cmd35.ExecuteNonQuery();
            cmd12.ExecuteNonQuery(); cmd24.ExecuteNonQuery(); cmd36.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Data was successfully sent to SQL Server!!");

        }

        private void btndataread_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8N9D;Initial Catalog=DBCONN;Integrated Security=True;MultipleActiveResultSets=True");

            baglan.Open();
            SqlCommand select1 = new SqlCommand("Select (DataValue) From Data where DataId=1", baglan);
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
                write1.Text = reads1["DataValue"].ToString();

            }
            SqlDataReader reads2 = select2.ExecuteReader();
            while (reads2.Read())
            {
                write2.Text = reads2["DataValue"].ToString();

            }
            SqlDataReader reads3 = select3.ExecuteReader();
            while (reads3.Read())
            {
                write3.Text = reads3["DataValue"].ToString();

            }
            SqlDataReader reads4 = select4.ExecuteReader();
            while (reads4.Read())
            {
                write4.Text = reads4["DataValue"].ToString();

            }
            SqlDataReader reads5 = select5.ExecuteReader();
            while (reads5.Read())
            {
                write5.Text = reads5["DataValue"].ToString();

            }
            SqlDataReader reads6 = select6.ExecuteReader();
            while (reads6.Read())
            {
                write6.Text = reads6["DataValue"].ToString();

            }
            SqlDataReader reads7 = select7.ExecuteReader();
            while (reads7.Read())
            {
                write7.Text = reads7["DataValue"].ToString();

            }
            SqlDataReader reads8 = select8.ExecuteReader();
            while (reads8.Read())
            {
                write8.Text = reads8["DataValue"].ToString();

            }
            SqlDataReader reads9 = select9.ExecuteReader();
            while (reads9.Read())
            {
                write9.Text = reads9["DataValue"].ToString();

            }
            SqlDataReader reads10 = select10.ExecuteReader();
            while (reads10.Read())
            {
                write10.Text = reads10["DataValue"].ToString();

            }
            SqlDataReader reads11 = select11.ExecuteReader();
            while (reads11.Read())
            {
                write11.Text = reads11["DataValue"].ToString();

            }
            SqlDataReader reads12 = select12.ExecuteReader();
            while (reads12.Read())
            {
                write12.Text = reads12["DataValue"].ToString();

            }
            SqlDataReader reads13 = select13.ExecuteReader();
            while (reads13.Read())
            {
                write13.Text = reads13["DataValue"].ToString();

            }
            SqlDataReader reads14 = select14.ExecuteReader();
            while (reads14.Read())
            {
                write14.Text = reads14["DataValue"].ToString();

            }
            SqlDataReader reads15 = select15.ExecuteReader();
            while (reads15.Read())
            {
                write15.Text = reads15["DataValue"].ToString();

            }
            SqlDataReader reads16 = select16.ExecuteReader();
            while (reads16.Read())
            {
                write16.Text = reads16["DataValue"].ToString();

            }
            SqlDataReader reads17 = select17.ExecuteReader();
            while (reads17.Read())
            {
                write17.Text = reads17["DataValue"].ToString();

            }
            SqlDataReader reads18 = select18.ExecuteReader();
            while (reads18.Read())
            {
                write18.Text = reads18["DataValue"].ToString();

            }
            SqlDataReader reads19 = select19.ExecuteReader();
            while (reads19.Read())
            {
                write19.Text = reads19["DataValue"].ToString();

            }
            SqlDataReader reads20 = select20.ExecuteReader();
            while (reads20.Read())
            {
                write20.Text = reads20["DataValue"].ToString();

            }
            SqlDataReader reads21 = select21.ExecuteReader();
            while (reads21.Read())
            {
                write21.Text = reads21["DataValue"].ToString();

            }
            SqlDataReader reads22 = select22.ExecuteReader();
            while (reads22.Read())
            {
                write22.Text = reads22["DataValue"].ToString();

            }
            SqlDataReader reads23 = select23.ExecuteReader();
            while (reads23.Read())
            {
                write23.Text = reads23["DataValue"].ToString();

            }
            SqlDataReader reads24 = select24.ExecuteReader();
            while (reads24.Read())
            {
                write24.Text = reads24["DataValue"].ToString();

            }
            SqlDataReader reads25 = select25.ExecuteReader();
            while (reads25.Read())
            {
                write25.Text = reads25["DataValue"].ToString();

            }
            SqlDataReader reads26 = select26.ExecuteReader();
            while (reads26.Read())
            {
                write26.Text = reads26["DataValue"].ToString();

            }
            SqlDataReader reads27 = select27.ExecuteReader();
            while (reads27.Read())
            {
                write27.Text = reads27["DataValue"].ToString();

            }
            SqlDataReader reads28 = select28.ExecuteReader();
            while (reads28.Read())
            {
                write28.Text = reads28["DataValue"].ToString();

            }
            SqlDataReader reads29 = select29.ExecuteReader();
            while (reads29.Read())
            {
                write29.Text = reads29["DataValue"].ToString();

            }
            SqlDataReader reads30 = select30.ExecuteReader();
            while (reads30.Read())
            {
                write30.Text = reads30["DataValue"].ToString();

            }
            SqlDataReader reads31 = select31.ExecuteReader();
            while (reads31.Read())
            {
                write31.Text = reads31["DataValue"].ToString();

            }
            SqlDataReader reads32 = select32.ExecuteReader();
            while (reads32.Read())
            {
                write32.Text = reads32["DataValue"].ToString();

            }
            SqlDataReader reads33 = select33.ExecuteReader();
            while (reads33.Read())
            {
                write33.Text = reads33["DataValue"].ToString();

            }
            SqlDataReader reads34 = select34.ExecuteReader();
            while (reads34.Read())
            {
                write34.Text = reads34["DataValue"].ToString();

            }
            SqlDataReader reads35 = select35.ExecuteReader();
            while (reads35.Read())
            {
                write35.Text = reads35["DataValue"].ToString();

            }
            SqlDataReader reads36 = select36.ExecuteReader();
            while (reads36.Read())
            {
                write36.Text = reads36["DataValue"].ToString();

            }

            baglan.Close();
        }

        private void SqlWrite_Load(object sender, EventArgs e)
        {

        }
    }
}
