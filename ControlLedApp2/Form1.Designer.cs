namespace ControlLedApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxPORT = new System.Windows.Forms.GroupBox();
            this.groupBoxLED = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblPort = new System.Windows.Forms.Label();
            this.lblBaud = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.comboBoxBAUD = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxLED = new System.Windows.Forms.PictureBox();
            this.btnLEDON = new System.Windows.Forms.Button();
            this.btnLEDOFF = new System.Windows.Forms.Button();
            this.progressBarConexion = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxPORT.SuspendLayout();
            this.groupBoxLED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLED)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPORT
            // 
            this.groupBoxPORT.Controls.Add(this.btnClose);
            this.groupBoxPORT.Controls.Add(this.btnOpen);
            this.groupBoxPORT.Controls.Add(this.comboBoxBAUD);
            this.groupBoxPORT.Controls.Add(this.comboBoxCOM);
            this.groupBoxPORT.Controls.Add(this.lblBaud);
            this.groupBoxPORT.Controls.Add(this.lblPort);
            this.groupBoxPORT.Location = new System.Drawing.Point(23, 25);
            this.groupBoxPORT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPORT.Name = "groupBoxPORT";
            this.groupBoxPORT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPORT.Size = new System.Drawing.Size(388, 310);
            this.groupBoxPORT.TabIndex = 0;
            this.groupBoxPORT.TabStop = false;
            this.groupBoxPORT.Text = "COM PORT SETTINGS";
            // 
            // groupBoxLED
            // 
            this.groupBoxLED.Controls.Add(this.btnLEDOFF);
            this.groupBoxLED.Controls.Add(this.btnLEDON);
            this.groupBoxLED.Controls.Add(this.pictureBoxLED);
            this.groupBoxLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLED.Location = new System.Drawing.Point(433, 38);
            this.groupBoxLED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLED.Name = "groupBoxLED";
            this.groupBoxLED.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLED.Size = new System.Drawing.Size(604, 416);
            this.groupBoxLED.TabIndex = 1;
            this.groupBoxLED.TabStop = false;
            this.groupBoxLED.Text = "LED CONTROL";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(48, 64);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(134, 25);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "COM PORT";
            this.lblPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(48, 121);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(144, 25);
            this.lblBaud.TabIndex = 1;
            this.lblBaud.Text = "BAUD RATE";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(202, 61);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCOM.TabIndex = 2;
            // 
            // comboBoxBAUD
            // 
            this.comboBoxBAUD.FormattingEnabled = true;
            this.comboBoxBAUD.Location = new System.Drawing.Point(202, 118);
            this.comboBoxBAUD.Name = "comboBoxBAUD";
            this.comboBoxBAUD.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBAUD.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(48, 218);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(134, 52);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(211, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 52);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxLED
            // 
            this.pictureBoxLED.Image = global::ControlLedApp2.Properties.Resources.green_led_off_md;
            this.pictureBoxLED.Location = new System.Drawing.Point(192, 27);
            this.pictureBoxLED.Name = "pictureBoxLED";
            this.pictureBoxLED.Size = new System.Drawing.Size(236, 230);
            this.pictureBoxLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLED.TabIndex = 0;
            this.pictureBoxLED.TabStop = false;
            // 
            // btnLEDON
            // 
            this.btnLEDON.Location = new System.Drawing.Point(108, 338);
            this.btnLEDON.Name = "btnLEDON";
            this.btnLEDON.Size = new System.Drawing.Size(153, 52);
            this.btnLEDON.TabIndex = 1;
            this.btnLEDON.Text = "LED ON";
            this.btnLEDON.UseVisualStyleBackColor = true;
            // 
            // btnLEDOFF
            // 
            this.btnLEDOFF.Location = new System.Drawing.Point(397, 338);
            this.btnLEDOFF.Name = "btnLEDOFF";
            this.btnLEDOFF.Size = new System.Drawing.Size(149, 52);
            this.btnLEDOFF.TabIndex = 2;
            this.btnLEDOFF.Text = "LED OFF";
            this.btnLEDOFF.UseVisualStyleBackColor = true;
            // 
            // progressBarConexion
            // 
            this.progressBarConexion.Location = new System.Drawing.Point(23, 407);
            this.progressBarConexion.Name = "progressBarConexion";
            this.progressBarConexion.Size = new System.Drawing.Size(388, 38);
            this.progressBarConexion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1084, 473);
            this.Controls.Add(this.progressBarConexion);
            this.Controls.Add(this.groupBoxLED);
            this.Controls.Add(this.groupBoxPORT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL LED APLICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPORT.ResumeLayout(false);
            this.groupBoxPORT.PerformLayout();
            this.groupBoxLED.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPORT;
        private System.Windows.Forms.GroupBox groupBoxLED;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxBAUD;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBoxLED;
        private System.Windows.Forms.Button btnLEDOFF;
        private System.Windows.Forms.Button btnLEDON;
        private System.Windows.Forms.ProgressBar progressBarConexion;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

