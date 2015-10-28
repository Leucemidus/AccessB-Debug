using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessB_Debug
{
    public partial class Form1 : Form
    {
        AccessB AccB = new AccessB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadSFR_Click(object sender, EventArgs e)
        {
            string SFR_1, SFR_2, SFR_3, SFR_4, SFR_5, SFR_6, SFR_7, SFR_8, SFR_9, SFR_10;
            SFR_1 = cmbSFR_1.Text.Substring(cmbSFR_1.Text.Length - 2, 2);
            SFR_2 = cmbSFR_2.Text.Substring(cmbSFR_2.Text.Length - 2, 2);
            SFR_3 = cmbSFR_3.Text.Substring(cmbSFR_3.Text.Length - 2, 2);
            SFR_4 = cmbSFR_4.Text.Substring(cmbSFR_4.Text.Length - 2, 2);
            SFR_5 = cmbSFR_5.Text.Substring(cmbSFR_5.Text.Length - 2, 2);
            SFR_6 = cmbSFR_6.Text.Substring(cmbSFR_6.Text.Length - 2, 2);
            SFR_7 = cmbSFR_7.Text.Substring(cmbSFR_7.Text.Length - 2, 2);
            SFR_8 = cmbSFR_8.Text.Substring(cmbSFR_8.Text.Length - 2, 2);
            SFR_9 = cmbSFR_9.Text.Substring(cmbSFR_9.Text.Length - 2, 2);
            SFR_10 = cmbSFR_10.Text.Substring(cmbSFR_10.Text.Length - 2, 2);


            txtbSFR_1.Text = AccB.SFRValue(UInt32.Parse(SFR_1, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_2.Text = AccB.SFRValue(UInt32.Parse(SFR_2, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_3.Text = AccB.SFRValue(UInt32.Parse(SFR_3, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_4.Text = AccB.SFRValue(UInt32.Parse(SFR_4, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_5.Text = AccB.SFRValue(UInt32.Parse(SFR_5, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_6.Text = AccB.SFRValue(UInt32.Parse(SFR_6, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_7.Text = AccB.SFRValue(UInt32.Parse(SFR_7, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_8.Text = AccB.SFRValue(UInt32.Parse(SFR_8, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_9.Text = AccB.SFRValue(UInt32.Parse(SFR_9, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
            txtbSFR_10.Text = AccB.SFRValue(UInt32.Parse(SFR_10, System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();

        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            //AccB.PID = 0x003F;
            //AccB.VID = 0x04d8;
            if (AccB.FindDevHID() == true)
            {
                lblStatus.Text = "Se encontró la tarjeta";
            }
            else
            {
                lblStatus.Text = "No se encotró la tarjeta";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSFR_1.SelectedIndex = 0;
            cmbSFR_2.SelectedIndex = 0;
            cmbSFR_3.SelectedIndex = 0;
            cmbSFR_4.SelectedIndex = 0;
            cmbSFR_5.SelectedIndex = 0;
            cmbSFR_6.SelectedIndex = 0;
            cmbSFR_7.SelectedIndex = 0;
            cmbSFR_8.SelectedIndex = 0;
            cmbSFR_9.SelectedIndex = 0;
            cmbSFR_10.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccB.TRISBbits_TRISB0 == 1)
            {
                AccB.TRISBbits_TRISB0 = 0;
            }
            else
            {
                AccB.TRISBbits_TRISB0 = 1;
            }
        }



        //private void btnConfigura_Click(object sender, EventArgs e)
        //{
        //    AccB.I2C_CFG(AccB.CFG_I2C_AS_MASTER_400kHz);
        //}

        //private void btnEnciendeI2C_Click(object sender, EventArgs e)
        //{
        //    AccB.I2C_Enable(true);
        //}

        //private void btnI2Coff_Click(object sender, EventArgs e)
        //{
        //    AccB.I2C_Enable(false);
        //}

        //private void btnEnvia_Click(object sender, EventArgs e)
        //{
        //    ushort SlaveAdd = 0x50;
        //    byte[] txdata = new byte[2]; //Address to tx
        //    byte[] Rxdata = new byte[2]; //Data to be received
        //    UInt32 address = Convert.ToUInt32(txbAdd.Text);
        //    txdata[0] = Convert.ToByte((address >> 8) & 0xFF);
        //    txdata[1] = Convert.ToByte(address & 0xFF);
        //    Rxdata = AccB.I2C_Transfer(SlaveAdd, 7, AccB.I2C_Write, 2, 2, txdata, AccB.I2C_Repeated_Read);
        //    txbValue.Text = Rxdata[0].ToString() + ", " + Rxdata[1].ToString();
        //}

        //private void btnEscribe_Click(object sender, EventArgs e)
        //{
        //    ushort SlaveAdd = 0x50;
        //    byte[] txdata = new byte[3]; //Address to tx
        //    byte[] Rxdata = new byte[0]; //Data to be received
        //    UInt32 address = Convert.ToUInt32(txbAdd.Text);
        //    txdata[0] = Convert.ToByte((address >> 8) & 0xFF);//Address High
        //    txdata[1] = Convert.ToByte(address & 0xFF);//Address Low
        //    txdata[2] = Convert.ToByte(txbValue.Text); //Data
        //    Rxdata = AccB.I2C_Transfer(SlaveAdd, 7, AccB.I2C_Write, 3, 0, txdata, AccB.I2C_No_Repeat);
        //}

    }
}
