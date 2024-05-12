using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace CommProtocolApp.Forms.Modbus
{
    public partial class ReadModbus : Form
    {
        private ModbusClient modbusClient;
        public ReadModbus()
        {
            InitializeComponent();
        }

        private void ReadModbus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(txtip.Text, Convert.ToInt32(txtport.Text));
                modbusClient.Connect();
                bglvar.Visible = true;
                bglyok.Visible = false;
                modbusbglyes.Visible = true;
                modbusbglno.Visible = false;

                ModbusTimer.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bglvar.Visible = false;
                bglyok.Visible = true;
                modbusbglyes.Visible = false;
                modbusbglno.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient.Disconnect();
                bglvar.Visible = false;
                bglyok.Visible = true;
                modbusbglyes.Visible = false;
                modbusbglno.Visible = true;
                ModbusTimer.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndataread_Click(object sender, EventArgs e)
        {
            ModbusTimer.Enabled = false;
            try
            {
                if (cmbtur.Text == "HoldingRegister")
                {
                    int x = Convert.ToInt32(txtstartingr.Text);
                    int[] readHoldingRegister = modbusClient.ReadHoldingRegisters(x, 18);
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                    txt40001.Text = Convert.ToInt32(readHoldingRegister[0]).ToString();
                    txt40002.Text = Convert.ToInt32(readHoldingRegister[1]).ToString();
                    txt40003.Text = Convert.ToInt32(readHoldingRegister[2]).ToString();
                    txt40004.Text = Convert.ToInt32(readHoldingRegister[3]).ToString();
                    txt40005.Text = Convert.ToInt32(readHoldingRegister[4]).ToString();
                    txt40006.Text = Convert.ToInt32(readHoldingRegister[5]).ToString();
                    txt40007.Text = Convert.ToInt32(readHoldingRegister[6]).ToString();
                    txt40008.Text = Convert.ToInt32(readHoldingRegister[7]).ToString();
                    txt40009.Text = Convert.ToInt32(readHoldingRegister[8]).ToString();
                    txt40010.Text = Convert.ToInt32(readHoldingRegister[9]).ToString();
                    txt40011.Text = Convert.ToInt32(readHoldingRegister[10]).ToString();
                    txt40012.Text = Convert.ToInt32(readHoldingRegister[11]).ToString();
                    txt40013.Text = Convert.ToInt32(readHoldingRegister[12]).ToString();
                    txt40014.Text = Convert.ToInt32(readHoldingRegister[13]).ToString();
                    txt40015.Text = Convert.ToInt32(readHoldingRegister[14]).ToString();
                    txt40016.Text = Convert.ToInt32(readHoldingRegister[15]).ToString();
                    txt40017.Text = Convert.ToInt32(readHoldingRegister[16]).ToString();
                    txt40018.Text = Convert.ToInt32(readHoldingRegister[17]).ToString();



                }
                else if (cmbtur.Text == "Boolean")
                {
                    int x = Convert.ToInt32(txtstartingr.Text);
                    bool[] readCoils = modbusClient.ReadCoils(x, 18);

                    readb1.Text = readCoils[x].ToString();
                    readb2.Text = readCoils[x + 1].ToString();
                    readb3.Text = readCoils[x + 2].ToString();
                    readb4.Text = readCoils[x + 3].ToString();
                    readb5.Text = readCoils[x + 4].ToString();
                    readb6.Text = readCoils[x + 5].ToString();
                    readb7.Text = readCoils[x + 6].ToString();
                    readb8.Text = readCoils[x + 7].ToString();
                    readb9.Text = readCoils[x + 8].ToString();
                    readb10.Text = readCoils[x + 9].ToString();
                    readb11.Text = readCoils[x + 10].ToString();
                    readb12.Text = readCoils[x + 11].ToString();
                    readb13.Text = readCoils[x + 12].ToString();
                    readb14.Text = readCoils[x + 13].ToString();
                    readb15.Text = readCoils[x + 14].ToString();
                    readb16.Text = readCoils[x + 15].ToString();
                    readb17.Text = readCoils[x + 16].ToString();
                    readb18.Text = readCoils[x + 17].ToString();

                }
                else
                {
                    MessageBox.Show("Please Select Test Type!!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            ModbusTimer.Enabled = true;



        }
    }

}

