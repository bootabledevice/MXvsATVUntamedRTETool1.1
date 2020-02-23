using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using XRPCLib;
using XDevkitPlusPlus;

namespace RTE_Temp
{
    public partial class Form1 : MetroForm
    {

        XRPC Jtag = new XRPC();

        public Form1()
        {
            InitializeComponent();
        }
        private void ErrorMessage()
        {
            MetroFramework.MetroMessageBox.Show(this, "Failed To Send Command", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XNotiy(string status)
        {
            Jtag.Notify(XRPC.XNotiyLogo.FLASHING_XBOX_CONSOLE, status);
        }

        private void ComboFive(string status)
        {
            comboFiveStatus.Text = (status);
        }

        private void ComboEight(string status)
        {
            comboEightStatus.Text = (status);
        }

        private void ComboTen(string status)
        {
            comboTenStatus.Text = (status);
        }

        private void xbConTar(UInt32 address, UInt32 value)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(address, value);
        }

        //
        //
        //Timer Interval = 100MS(Default)

        private void startComboFiveTimer()
        {
            if (comboFiveTimer.Enabled)
            {
                comboFiveStatus.ForeColor = Color.Red;
                comboFiveTimer.Stop();
                ComboFive("Not Active");
                XNotiy("5x Combo Disabled");
            }
            else
            {
                comboFiveStatus.ForeColor = Color.Green;
                comboFiveTimer.Start();
                ComboFive("Active");
                XNotiy("5x Combo Enabled");
            }
        }

        private void startComboEightTimer()
        {
            if (comboEightTimer.Enabled)
            {
                comboEightStatus.ForeColor = Color.Red;
                comboEightTimer.Stop();
                ComboEight("Not Active");
                XNotiy("8x Combo Disabled");
            }
            else
            {
                comboEightStatus.ForeColor = Color.Green;
                comboEightTimer.Start();
                ComboEight("Active");
                XNotiy("8x Combo Enabled");
            }
        }

        private void startComboTenTimer()
        {
            if (comboTenTimer.Enabled)
            {
                comboTenStatus.ForeColor = Color.Red;
                comboTenTimer.Stop();
                ComboTen("Not Active");
                XNotiy("10x Combo Disabled");
            }
            else
            {
                comboTenStatus.ForeColor = Color.Green;
                comboTenTimer.Start();
                ComboTen("Active");
                XNotiy("10x Combo Enabled");
            }
        }

        //Console Connection
        //

        private void connectConsole_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Connected To Console", "Connection Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XNotiy("Connected");

                //Enable Buttons
                comboFive.Enabled = true;
                comboEight.Enabled = true;
                comboTen.Enabled = true;
                setFreestyleScore.Enabled = true;
                setMoney.Enabled = true;

                //Enable Status & Set Colors
                consoleStatus.Text = "Connected";
                consoleStatus.ForeColor = Color.Green;
                //
                comboFiveStatus.Enabled = true;
                comboFiveStatus.ForeColor = Color.Red;
                ComboFive("Not Active");
                //
                comboEightStatus.Enabled = true;
                comboEightStatus.ForeColor = Color.Red;
                ComboEight("Not Active");
                //
                comboTenStatus.Enabled = true;
                comboTenStatus.ForeColor = Color.Red;
                ComboTen("Not Active");
                //
                connectionError.Enabled = false;
                connectionError.Text = "";

                //Enable Value Boxes
                moneyValue.Enabled = true;
                freestyleScoreValue.Enabled = true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Connection Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                consoleStatus.Text = "Not Connected";
                consoleStatus.ForeColor = Color.Red;
                //
                connectionError.Enabled = true;
                connectionError.ForeColor = Color.Red;
                connectionError.Text = "Check Xbox 360 Neighborhood & DashLaunch";
            }
        }


        //Combo Five Button
        private void comboFive_Click(object sender, EventArgs e)
        {
            try
            {
                startComboFiveTimer();
            }
            catch
            {
                ErrorMessage();
            }
        }

        //(MemoryAddress, Value)
        private void comboFiveTimer_Tick(object sender, EventArgs e)
        {
            xbConTar(0xC328AF18, 0x00000005);
        }

        //Combo Eight Button
        private void comboEight_Click(object sender, EventArgs e)
        {
            try
            {
                startComboEightTimer();
            }
            catch
            {
                ErrorMessage();
            }
        }

        //(MemoryAddress, Value)
        private void comboEightTimer_Tick(object sender, EventArgs e)
        {
            xbConTar(0xC328AF18, 0x00000008);
        }

        //Combo Ten Button
        private void comboTen_Click(object sender, EventArgs e)
        {
            try
            {
                startComboTenTimer();
            }
            catch
            {
                ErrorMessage();
            }
        }

        //(MemoryAddress, Value)
        private void comboTenTimer_Tick(object sender, EventArgs e)
        {
            xbConTar(0xC328AF18, 0x0000000A);
        }
        
        //Set Money Value Entered In Text Box
        //
        private void setMoney_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC7EC98D0), Convert.ToInt32(moneyValue.Text));
                XNotiy("Money Set");
            }
            catch
            {
                ErrorMessage();
            }
        }

        //Set Freestyle Score Entered In Text Box
        //
        private void setFreestyleScore_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC328AF1C), Convert.ToInt32(freestyleScoreValue.Text));
                XNotiy("Freestyle Score Set");
            }
            catch
            {
                ErrorMessage();
            }
        }
    }
}
