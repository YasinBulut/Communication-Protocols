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
    public partial class WriteModbus : Form
    {
        private ModbusClient modbusClient;
        public WriteModbus()
        {
            InitializeComponent();
        }

        private void WriteModbus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ModbusTimer.Enabled = true;
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


        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (modbusClient.Connected == true)
                {
                    ModbusTimer.Enabled = true;

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


                        writeb1.Text = readCoils[0].ToString();
                        writeb2.Text = readCoils[1].ToString();
                        writeb3.Text = readCoils[2].ToString();
                        writeb4.Text = readCoils[3].ToString();
                        writeb5.Text = readCoils[4].ToString();
                        writeb6.Text = readCoils[5].ToString();
                        writeb7.Text = readCoils[6].ToString();
                        writeb8.Text = readCoils[7].ToString();
                        writeb9.Text = readCoils[8].ToString();
                        writeb10.Text = readCoils[9].ToString();
                        writeb11.Text = readCoils[10].ToString();
                        writeb12.Text = readCoils[11].ToString();
                        writeb13.Text = readCoils[12].ToString();
                        writeb14.Text = readCoils[13].ToString();
                        writeb15.Text = readCoils[14].ToString();
                        writeb16.Text = readCoils[15].ToString();
                        writeb17.Text = readCoils[16].ToString();
                        writeb18.Text = readCoils[17].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please Select Test Type!!");
                    }
                    ModbusTimer.Enabled = false;
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
                ModbusTimer.Enabled = true;
                if (cmbtur.Text == "HoldingRegister")
                {
                    int[] writeRegister = { Convert.ToInt32(txt40001.Text),
                                    Convert.ToInt32(txt40002.Text),
                                    Convert.ToInt32(txt40003.Text),
                                    Convert.ToInt32(txt40004.Text),
                                    Convert.ToInt32(txt40005.Text),
                                    Convert.ToInt32(txt40006.Text),
                                    Convert.ToInt32(txt40007.Text),
                                    Convert.ToInt32(txt40008.Text),
                                    Convert.ToInt32(txt40009.Text),
                                    Convert.ToInt32(txt40010.Text),
                                    Convert.ToInt32(txt40011.Text),
                                    Convert.ToInt32(txt40012.Text),
                                    Convert.ToInt32(txt40013.Text),
                                    Convert.ToInt32(txt40014.Text),
                                    Convert.ToInt32(txt40015.Text),
                                    Convert.ToInt32(txt40016.Text),
                                    Convert.ToInt32(txt40017.Text),
                                    Convert.ToInt32(txt40018.Text),

            };

                    modbusClient.WriteMultipleRegisters(Convert.ToInt32(txtstartingr.Text), writeRegister);


                }
                else if (cmbtur.Text == "Boolean")
                {
                    bool[] writeCoils = { Convert.ToBoolean(writeb1.Text),
                                    Convert.ToBoolean(writeb2.Checked),
                                    Convert.ToBoolean(writeb3.Checked),
                                    Convert.ToBoolean(writeb4.Checked),
                                    Convert.ToBoolean(writeb5.Checked),
                                    Convert.ToBoolean(writeb6.Checked),
                                    Convert.ToBoolean(writeb7.Checked),
                                    Convert.ToBoolean(writeb8.Checked),
                                    Convert.ToBoolean(writeb9.Checked),
                                    Convert.ToBoolean(writeb10.Checked),
                                    Convert.ToBoolean(writeb11.Checked),
                                    Convert.ToBoolean(writeb12.Checked),
                                    Convert.ToBoolean(writeb13.Checked),
                                    Convert.ToBoolean(writeb14.Checked),
                                    Convert.ToBoolean(writeb15.Checked),
                                    Convert.ToBoolean(writeb16.Checked),
                                    Convert.ToBoolean(writeb17.Checked),
                                    Convert.ToBoolean(writeb18.Checked),

            };

                    modbusClient.WriteMultipleCoils(Convert.ToInt32(txtstartingr.Text), writeCoils);

                }
                else
                {
                    MessageBox.Show("Lütfen Test Türünü Seçiniz!!");
                }

                ModbusTimer.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

