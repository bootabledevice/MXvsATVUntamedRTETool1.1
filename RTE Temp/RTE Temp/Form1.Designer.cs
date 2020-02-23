namespace RTE_Temp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectConsole = new MetroFramework.Controls.MetroTile();
            this.comboFive = new MetroFramework.Controls.MetroTile();
            this.comboEight = new MetroFramework.Controls.MetroTile();
            this.comboTen = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.consoleStatus = new MetroFramework.Controls.MetroLabel();
            this.comboFiveStatus = new MetroFramework.Controls.MetroLabel();
            this.comboEightStatus = new MetroFramework.Controls.MetroLabel();
            this.comboTenStatus = new MetroFramework.Controls.MetroLabel();
            this.setMoney = new MetroFramework.Controls.MetroTile();
            this.setFreestyleScore = new MetroFramework.Controls.MetroTile();
            this.moneyValue = new MetroFramework.Controls.MetroTextBox();
            this.freestyleScoreValue = new MetroFramework.Controls.MetroTextBox();
            this.comboFiveTimer = new System.Windows.Forms.Timer(this.components);
            this.comboEightTimer = new System.Windows.Forms.Timer(this.components);
            this.comboTenTimer = new System.Windows.Forms.Timer(this.components);
            this.connectionError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // connectConsole
            // 
            this.connectConsole.ActiveControl = null;
            this.connectConsole.Location = new System.Drawing.Point(24, 68);
            this.connectConsole.Name = "connectConsole";
            this.connectConsole.Size = new System.Drawing.Size(135, 49);
            this.connectConsole.TabIndex = 0;
            this.connectConsole.Text = "Connect To Console";
            this.connectConsole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectConsole.UseSelectable = true;
            this.connectConsole.Click += new System.EventHandler(this.connectConsole_Click);
            // 
            // comboFive
            // 
            this.comboFive.ActiveControl = null;
            this.comboFive.Enabled = false;
            this.comboFive.Location = new System.Drawing.Point(24, 156);
            this.comboFive.Name = "comboFive";
            this.comboFive.Size = new System.Drawing.Size(135, 49);
            this.comboFive.TabIndex = 1;
            this.comboFive.Text = "Always 5x Combo";
            this.comboFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comboFive.UseSelectable = true;
            this.comboFive.Click += new System.EventHandler(this.comboFive_Click);
            // 
            // comboEight
            // 
            this.comboEight.ActiveControl = null;
            this.comboEight.Enabled = false;
            this.comboEight.Location = new System.Drawing.Point(24, 244);
            this.comboEight.Name = "comboEight";
            this.comboEight.Size = new System.Drawing.Size(135, 50);
            this.comboEight.TabIndex = 2;
            this.comboEight.Text = "Always 8x Combo";
            this.comboEight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comboEight.UseSelectable = true;
            this.comboEight.Click += new System.EventHandler(this.comboEight_Click);
            // 
            // comboTen
            // 
            this.comboTen.ActiveControl = null;
            this.comboTen.Enabled = false;
            this.comboTen.Location = new System.Drawing.Point(24, 330);
            this.comboTen.Name = "comboTen";
            this.comboTen.Size = new System.Drawing.Size(135, 50);
            this.comboTen.TabIndex = 3;
            this.comboTen.Text = "Always 10x Combo";
            this.comboTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comboTen.UseSelectable = true;
            this.comboTen.Click += new System.EventHandler(this.comboTen_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Status:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Status:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 297);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Status:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 383);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Status:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // consoleStatus
            // 
            this.consoleStatus.AutoSize = true;
            this.consoleStatus.BackColor = System.Drawing.Color.Transparent;
            this.consoleStatus.Location = new System.Drawing.Point(63, 120);
            this.consoleStatus.Name = "consoleStatus";
            this.consoleStatus.Size = new System.Drawing.Size(0, 0);
            this.consoleStatus.TabIndex = 9;
            this.consoleStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboFiveStatus
            // 
            this.comboFiveStatus.AutoSize = true;
            this.comboFiveStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboFiveStatus.Enabled = false;
            this.comboFiveStatus.Location = new System.Drawing.Point(63, 208);
            this.comboFiveStatus.Name = "comboFiveStatus";
            this.comboFiveStatus.Size = new System.Drawing.Size(0, 0);
            this.comboFiveStatus.TabIndex = 12;
            this.comboFiveStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboEightStatus
            // 
            this.comboEightStatus.AutoSize = true;
            this.comboEightStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboEightStatus.Enabled = false;
            this.comboEightStatus.Location = new System.Drawing.Point(63, 297);
            this.comboEightStatus.Name = "comboEightStatus";
            this.comboEightStatus.Size = new System.Drawing.Size(0, 0);
            this.comboEightStatus.TabIndex = 14;
            this.comboEightStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboTenStatus
            // 
            this.comboTenStatus.AutoSize = true;
            this.comboTenStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboTenStatus.Enabled = false;
            this.comboTenStatus.Location = new System.Drawing.Point(63, 383);
            this.comboTenStatus.Name = "comboTenStatus";
            this.comboTenStatus.Size = new System.Drawing.Size(0, 0);
            this.comboTenStatus.TabIndex = 15;
            this.comboTenStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // setMoney
            // 
            this.setMoney.ActiveControl = null;
            this.setMoney.Enabled = false;
            this.setMoney.Location = new System.Drawing.Point(214, 68);
            this.setMoney.Name = "setMoney";
            this.setMoney.Size = new System.Drawing.Size(135, 49);
            this.setMoney.TabIndex = 16;
            this.setMoney.Text = "Set Money";
            this.setMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setMoney.UseSelectable = true;
            this.setMoney.Click += new System.EventHandler(this.setMoney_Click);
            // 
            // setFreestyleScore
            // 
            this.setFreestyleScore.ActiveControl = null;
            this.setFreestyleScore.Enabled = false;
            this.setFreestyleScore.Location = new System.Drawing.Point(214, 156);
            this.setFreestyleScore.Name = "setFreestyleScore";
            this.setFreestyleScore.Size = new System.Drawing.Size(135, 49);
            this.setFreestyleScore.TabIndex = 17;
            this.setFreestyleScore.Text = "Set Freestyle Score";
            this.setFreestyleScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setFreestyleScore.UseSelectable = true;
            this.setFreestyleScore.Click += new System.EventHandler(this.setFreestyleScore_Click);
            // 
            // moneyValue
            // 
            // 
            // 
            // 
            this.moneyValue.CustomButton.Image = null;
            this.moneyValue.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.moneyValue.CustomButton.Name = "";
            this.moneyValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.moneyValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.moneyValue.CustomButton.TabIndex = 1;
            this.moneyValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.moneyValue.CustomButton.UseSelectable = true;
            this.moneyValue.CustomButton.Visible = false;
            this.moneyValue.Enabled = false;
            this.moneyValue.Lines = new string[0];
            this.moneyValue.Location = new System.Drawing.Point(214, 123);
            this.moneyValue.MaxLength = 32767;
            this.moneyValue.Name = "moneyValue";
            this.moneyValue.PasswordChar = '\0';
            this.moneyValue.PromptText = "Enter Money Amount";
            this.moneyValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.moneyValue.SelectedText = "";
            this.moneyValue.SelectionLength = 0;
            this.moneyValue.SelectionStart = 0;
            this.moneyValue.ShortcutsEnabled = true;
            this.moneyValue.Size = new System.Drawing.Size(135, 23);
            this.moneyValue.TabIndex = 18;
            this.moneyValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.moneyValue.UseSelectable = true;
            this.moneyValue.WaterMark = "Enter Money Amount";
            this.moneyValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.moneyValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // freestyleScoreValue
            // 
            // 
            // 
            // 
            this.freestyleScoreValue.CustomButton.Image = null;
            this.freestyleScoreValue.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.freestyleScoreValue.CustomButton.Name = "";
            this.freestyleScoreValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.freestyleScoreValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.freestyleScoreValue.CustomButton.TabIndex = 1;
            this.freestyleScoreValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.freestyleScoreValue.CustomButton.UseSelectable = true;
            this.freestyleScoreValue.CustomButton.Visible = false;
            this.freestyleScoreValue.Enabled = false;
            this.freestyleScoreValue.Lines = new string[0];
            this.freestyleScoreValue.Location = new System.Drawing.Point(214, 211);
            this.freestyleScoreValue.MaxLength = 32767;
            this.freestyleScoreValue.Name = "freestyleScoreValue";
            this.freestyleScoreValue.PasswordChar = '\0';
            this.freestyleScoreValue.PromptText = "Enter Freestyle Score";
            this.freestyleScoreValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.freestyleScoreValue.SelectedText = "";
            this.freestyleScoreValue.SelectionLength = 0;
            this.freestyleScoreValue.SelectionStart = 0;
            this.freestyleScoreValue.ShortcutsEnabled = true;
            this.freestyleScoreValue.Size = new System.Drawing.Size(135, 23);
            this.freestyleScoreValue.TabIndex = 19;
            this.freestyleScoreValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.freestyleScoreValue.UseSelectable = true;
            this.freestyleScoreValue.WaterMark = "Enter Freestyle Score";
            this.freestyleScoreValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.freestyleScoreValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboFiveTimer
            // 
            this.comboFiveTimer.Tick += new System.EventHandler(this.comboFiveTimer_Tick);
            // 
            // comboEightTimer
            // 
            this.comboEightTimer.Tick += new System.EventHandler(this.comboEightTimer_Tick);
            // 
            // comboTenTimer
            // 
            this.comboTenTimer.Tick += new System.EventHandler(this.comboTenTimer_Tick);
            // 
            // connectionError
            // 
            this.connectionError.AutoSize = true;
            this.connectionError.Enabled = false;
            this.connectionError.Location = new System.Drawing.Point(24, 406);
            this.connectionError.Name = "connectionError";
            this.connectionError.Size = new System.Drawing.Size(0, 0);
            this.connectionError.TabIndex = 20;
            this.connectionError.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 429);
            this.Controls.Add(this.connectionError);
            this.Controls.Add(this.freestyleScoreValue);
            this.Controls.Add(this.moneyValue);
            this.Controls.Add(this.setFreestyleScore);
            this.Controls.Add(this.setMoney);
            this.Controls.Add(this.comboTenStatus);
            this.Controls.Add(this.comboEightStatus);
            this.Controls.Add(this.comboFiveStatus);
            this.Controls.Add(this.consoleStatus);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboTen);
            this.Controls.Add(this.comboEight);
            this.Controls.Add(this.comboFive);
            this.Controls.Add(this.connectConsole);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 64, 20, 21);
            this.Text = "Xbox 360 RTE Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile connectConsole;
        private MetroFramework.Controls.MetroTile comboFive;
        private MetroFramework.Controls.MetroTile comboEight;
        private MetroFramework.Controls.MetroTile comboTen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel consoleStatus;
        private MetroFramework.Controls.MetroLabel comboFiveStatus;
        private MetroFramework.Controls.MetroLabel comboEightStatus;
        private MetroFramework.Controls.MetroLabel comboTenStatus;
        private MetroFramework.Controls.MetroTile setMoney;
        private MetroFramework.Controls.MetroTile setFreestyleScore;
        private MetroFramework.Controls.MetroTextBox moneyValue;
        private MetroFramework.Controls.MetroTextBox freestyleScoreValue;
        private System.Windows.Forms.Timer comboFiveTimer;
        private System.Windows.Forms.Timer comboEightTimer;
        private System.Windows.Forms.Timer comboTenTimer;
        private MetroFramework.Controls.MetroLabel connectionError;
    }
}

