namespace AccessB_Debug
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
            this.cmbSFR_1 = new System.Windows.Forms.ComboBox();
            this.btnReadSFR = new System.Windows.Forms.Button();
            this.txtbSFR_2 = new System.Windows.Forms.TextBox();
            this.cmbSFR_2 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_3 = new System.Windows.Forms.TextBox();
            this.cmbSFR_3 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_4 = new System.Windows.Forms.TextBox();
            this.cmbSFR_4 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_5 = new System.Windows.Forms.TextBox();
            this.cmbSFR_5 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_1 = new System.Windows.Forms.TextBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSFR_6 = new System.Windows.Forms.ComboBox();
            this.cmbSFR_7 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_6 = new System.Windows.Forms.TextBox();
            this.txtbSFR_7 = new System.Windows.Forms.TextBox();
            this.txtbSFR_10 = new System.Windows.Forms.TextBox();
            this.cmbSFR_8 = new System.Windows.Forms.ComboBox();
            this.cmbSFR_10 = new System.Windows.Forms.ComboBox();
            this.txtbSFR_8 = new System.Windows.Forms.TextBox();
            this.txtbSFR_9 = new System.Windows.Forms.TextBox();
            this.cmbSFR_9 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSFR_1
            // 
            this.cmbSFR_1.FormattingEnabled = true;
            this.cmbSFR_1.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_1.Location = new System.Drawing.Point(6, 19);
            this.cmbSFR_1.Name = "cmbSFR_1";
            this.cmbSFR_1.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_1.TabIndex = 0;
            // 
            // btnReadSFR
            // 
            this.btnReadSFR.Location = new System.Drawing.Point(97, 153);
            this.btnReadSFR.Name = "btnReadSFR";
            this.btnReadSFR.Size = new System.Drawing.Size(75, 23);
            this.btnReadSFR.TabIndex = 1;
            this.btnReadSFR.Text = "Read SFR";
            this.btnReadSFR.UseVisualStyleBackColor = true;
            this.btnReadSFR.Click += new System.EventHandler(this.btnReadSFR_Click);
            // 
            // txtbSFR_2
            // 
            this.txtbSFR_2.Location = new System.Drawing.Point(133, 46);
            this.txtbSFR_2.Name = "txtbSFR_2";
            this.txtbSFR_2.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_2.TabIndex = 4;
            // 
            // cmbSFR_2
            // 
            this.cmbSFR_2.FormattingEnabled = true;
            this.cmbSFR_2.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_2.Location = new System.Drawing.Point(6, 46);
            this.cmbSFR_2.Name = "cmbSFR_2";
            this.cmbSFR_2.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_2.TabIndex = 3;
            // 
            // txtbSFR_3
            // 
            this.txtbSFR_3.Location = new System.Drawing.Point(133, 73);
            this.txtbSFR_3.Name = "txtbSFR_3";
            this.txtbSFR_3.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_3.TabIndex = 6;
            // 
            // cmbSFR_3
            // 
            this.cmbSFR_3.FormattingEnabled = true;
            this.cmbSFR_3.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_3.Location = new System.Drawing.Point(6, 73);
            this.cmbSFR_3.Name = "cmbSFR_3";
            this.cmbSFR_3.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_3.TabIndex = 5;
            // 
            // txtbSFR_4
            // 
            this.txtbSFR_4.Location = new System.Drawing.Point(133, 100);
            this.txtbSFR_4.Name = "txtbSFR_4";
            this.txtbSFR_4.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_4.TabIndex = 8;
            // 
            // cmbSFR_4
            // 
            this.cmbSFR_4.FormattingEnabled = true;
            this.cmbSFR_4.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_4.Location = new System.Drawing.Point(6, 100);
            this.cmbSFR_4.Name = "cmbSFR_4";
            this.cmbSFR_4.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_4.TabIndex = 7;
            // 
            // txtbSFR_5
            // 
            this.txtbSFR_5.Location = new System.Drawing.Point(133, 127);
            this.txtbSFR_5.Name = "txtbSFR_5";
            this.txtbSFR_5.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_5.TabIndex = 10;
            // 
            // cmbSFR_5
            // 
            this.cmbSFR_5.FormattingEnabled = true;
            this.cmbSFR_5.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_5.Location = new System.Drawing.Point(6, 127);
            this.cmbSFR_5.Name = "cmbSFR_5";
            this.cmbSFR_5.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_5.TabIndex = 9;
            // 
            // txtbSFR_1
            // 
            this.txtbSFR_1.Location = new System.Drawing.Point(133, 19);
            this.txtbSFR_1.Name = "txtbSFR_1";
            this.txtbSFR_1.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_1.TabIndex = 11;
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(6, 154);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(75, 23);
            this.btnDetect.TabIndex = 12;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(165, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:******";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSFR_6);
            this.groupBox1.Controls.Add(this.cmbSFR_7);
            this.groupBox1.Controls.Add(this.txtbSFR_6);
            this.groupBox1.Controls.Add(this.txtbSFR_7);
            this.groupBox1.Controls.Add(this.txtbSFR_10);
            this.groupBox1.Controls.Add(this.cmbSFR_8);
            this.groupBox1.Controls.Add(this.cmbSFR_10);
            this.groupBox1.Controls.Add(this.txtbSFR_8);
            this.groupBox1.Controls.Add(this.txtbSFR_9);
            this.groupBox1.Controls.Add(this.cmbSFR_9);
            this.groupBox1.Controls.Add(this.cmbSFR_1);
            this.groupBox1.Controls.Add(this.btnReadSFR);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.cmbSFR_2);
            this.groupBox1.Controls.Add(this.btnDetect);
            this.groupBox1.Controls.Add(this.txtbSFR_1);
            this.groupBox1.Controls.Add(this.txtbSFR_2);
            this.groupBox1.Controls.Add(this.txtbSFR_5);
            this.groupBox1.Controls.Add(this.cmbSFR_3);
            this.groupBox1.Controls.Add(this.cmbSFR_5);
            this.groupBox1.Controls.Add(this.txtbSFR_3);
            this.groupBox1.Controls.Add(this.txtbSFR_4);
            this.groupBox1.Controls.Add(this.cmbSFR_4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFR";
            // 
            // cmbSFR_6
            // 
            this.cmbSFR_6.FormattingEnabled = true;
            this.cmbSFR_6.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_6.Location = new System.Drawing.Point(198, 18);
            this.cmbSFR_6.Name = "cmbSFR_6";
            this.cmbSFR_6.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_6.TabIndex = 13;
            // 
            // cmbSFR_7
            // 
            this.cmbSFR_7.FormattingEnabled = true;
            this.cmbSFR_7.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_7.Location = new System.Drawing.Point(198, 45);
            this.cmbSFR_7.Name = "cmbSFR_7";
            this.cmbSFR_7.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_7.TabIndex = 14;
            // 
            // txtbSFR_6
            // 
            this.txtbSFR_6.Location = new System.Drawing.Point(325, 18);
            this.txtbSFR_6.Name = "txtbSFR_6";
            this.txtbSFR_6.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_6.TabIndex = 22;
            // 
            // txtbSFR_7
            // 
            this.txtbSFR_7.Location = new System.Drawing.Point(325, 45);
            this.txtbSFR_7.Name = "txtbSFR_7";
            this.txtbSFR_7.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_7.TabIndex = 15;
            // 
            // txtbSFR_10
            // 
            this.txtbSFR_10.Location = new System.Drawing.Point(325, 126);
            this.txtbSFR_10.Name = "txtbSFR_10";
            this.txtbSFR_10.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_10.TabIndex = 21;
            // 
            // cmbSFR_8
            // 
            this.cmbSFR_8.FormattingEnabled = true;
            this.cmbSFR_8.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_8.Location = new System.Drawing.Point(198, 72);
            this.cmbSFR_8.Name = "cmbSFR_8";
            this.cmbSFR_8.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_8.TabIndex = 16;
            // 
            // cmbSFR_10
            // 
            this.cmbSFR_10.FormattingEnabled = true;
            this.cmbSFR_10.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_10.Location = new System.Drawing.Point(198, 126);
            this.cmbSFR_10.Name = "cmbSFR_10";
            this.cmbSFR_10.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_10.TabIndex = 20;
            // 
            // txtbSFR_8
            // 
            this.txtbSFR_8.Location = new System.Drawing.Point(325, 72);
            this.txtbSFR_8.Name = "txtbSFR_8";
            this.txtbSFR_8.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_8.TabIndex = 17;
            // 
            // txtbSFR_9
            // 
            this.txtbSFR_9.Location = new System.Drawing.Point(325, 99);
            this.txtbSFR_9.Name = "txtbSFR_9";
            this.txtbSFR_9.Size = new System.Drawing.Size(39, 20);
            this.txtbSFR_9.TabIndex = 19;
            // 
            // cmbSFR_9
            // 
            this.cmbSFR_9.FormattingEnabled = true;
            this.cmbSFR_9.Items.AddRange(new object[] {
            "TOSU  FFF",
            "INDF2 FDF",
            "CCPR1H FBF",
            "IPR1  F9F",
            "UEP15 F7F",
            "TOSH  FFE",
            "POSTINC2 FDE",
            "CCPR1L FBE",
            "PIR1 F9E",
            "UEP14 F7E",
            "TOSL FFD",
            "POSTDEC2 FDD",
            "CCP1CON  FBD",
            "PIE1 F9D",
            "UEP13 F7D",
            "STKPTR FFC",
            "PREINC2 FDC",
            "CCPR2H FBC",
            "UEP12 F7C",
            "PCLATU FFB",
            "PLUSW2 FDB",
            "CCPR2L FBB",
            "OSCTUNE F9B",
            "UEP11 F7B",
            "PCLATH FFA",
            "FSR2H FDA",
            "CCP2CON FBA",
            "UEP10 F7A",
            "PCL  FF9",
            "FSR2L FD9",
            "UEP9 F79",
            "TBLPTRU FF8",
            "STATUS FD8",
            "BAUDCON  FB8",
            "UEP8 F78",
            "TBLPTRH  FF7",
            "TMR0H  FD7",
            "ECCP1DEL FB7",
            "UEP7 F77",
            "TBLPTRL FF6",
            "TMR0L FD6",
            "ECCP1AS FB6",
            "UEP6 F76",
            "TABLAT  FF5",
            "T0CON FD5",
            "CVRCON FB5",
            "UEP5 F75",
            "PRODH  FF4",
            "CMCON FB4",
            "TRISC  F94",
            "UEP4 F74",
            "PRODL  FF3",
            "OSCCON FD3",
            "TMR3H FB3",
            "TRISB  F93",
            "UEP3 F73",
            "INTCON FF2",
            "HLVDCON FD2",
            "TMR3L FB2",
            "TRISA  F92",
            "UEP2 F72",
            "INTCON2  FF1",
            "WDTCON  FD1",
            "T3CON  FB1",
            "UEP1 F71",
            "INTCON3 FF0",
            "RCON  FD0",
            "SPBRGH FB0",
            "UEP0 F70",
            "INDF0 FEF",
            "TMR1H  FCF",
            "SPBRG  FAF",
            "UCFG F6F",
            "POSTINC0 FEE",
            "TMR1L  FCE",
            "RCREG  FAE",
            "UADDR F6E",
            "POSTDEC0 FED",
            "T1CON  FCD",
            "TXREG  FAD",
            "UCON F6D",
            "PREINC0 FEC",
            "TMR2  FCC",
            "TXSTA  FAC",
            "USTAT F6C",
            "PLUSW0 FEB",
            "PR2  FCB",
            "RCSTA  FAB",
            "LATC  F8B",
            "UEIE F6B",
            "FSR0H  FEA",
            "T2CON  FCA",
            "LATB  F8A",
            "UEIR F6A",
            "FSR0L FE9",
            "SSPBUF FC9",
            "EEADR  FA9",
            "LATA  F89",
            "UIE F69",
            "WREG  FE8",
            "SSPADD FC8",
            "EEDATA FA8",
            "UIR F68",
            "INDF1 FE7",
            "SSPSTAT  FC7",
            "EECON2 FA7",
            "UFRMH F67",
            "POSTINC1 FE6",
            "SSPCON1 FC6",
            "EECON1  FA6",
            "UFRML F66",
            "POSTDEC1 FE5",
            "SSPCON2  FC5",
            "PREINC1 FE4",
            "ADRESH  FC4",
            "PORTE F84",
            "PLUSW1 FE3",
            "ADRESL  FC3",
            "FSR1H  FE2",
            "ADCON0  FC2",
            "IPR2 FA2",
            "PORTC F82",
            "FSR1L  FE1",
            "ADCON1  FC1",
            "PIR2  FA1",
            "PORTB  F81",
            "BSR  FE0",
            "ADCON2  FC0",
            "PIE2 FA0",
            "PORTA F80"});
            this.cmbSFR_9.Location = new System.Drawing.Point(198, 99);
            this.cmbSFR_9.Name = "cmbSFR_9";
            this.cmbSFR_9.Size = new System.Drawing.Size(121, 21);
            this.cmbSFR_9.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Space";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AccessB Debug";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSFR_1;
        private System.Windows.Forms.Button btnReadSFR;
        private System.Windows.Forms.TextBox txtbSFR_2;
        private System.Windows.Forms.ComboBox cmbSFR_2;
        private System.Windows.Forms.TextBox txtbSFR_3;
        private System.Windows.Forms.ComboBox cmbSFR_3;
        private System.Windows.Forms.TextBox txtbSFR_4;
        private System.Windows.Forms.ComboBox cmbSFR_4;
        private System.Windows.Forms.TextBox txtbSFR_5;
        private System.Windows.Forms.ComboBox cmbSFR_5;
        private System.Windows.Forms.TextBox txtbSFR_1;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSFR_6;
        private System.Windows.Forms.ComboBox cmbSFR_7;
        private System.Windows.Forms.TextBox txtbSFR_6;
        private System.Windows.Forms.TextBox txtbSFR_7;
        private System.Windows.Forms.TextBox txtbSFR_10;
        private System.Windows.Forms.ComboBox cmbSFR_8;
        private System.Windows.Forms.ComboBox cmbSFR_10;
        private System.Windows.Forms.TextBox txtbSFR_8;
        private System.Windows.Forms.TextBox txtbSFR_9;
        private System.Windows.Forms.ComboBox cmbSFR_9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

