namespace SerialPortTRR
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxRecevied = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend2 = new System.Windows.Forms.Button();
            this.textBoxSend2 = new System.Windows.Forms.TextBox();
            this.textBoxRecevied2 = new System.Windows.Forms.TextBox();
            this.buttonDisconnect2 = new System.Windows.Forms.Button();
            this.buttonConnect2 = new System.Windows.Forms.Button();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear1);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Controls.Add(this.textBoxRecevied);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Ivory;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSend.Location = new System.Drawing.Point(258, 382);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(118, 33);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Gönder";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 382);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(246, 68);
            this.textBoxSend.TabIndex = 4;
            // 
            // textBoxRecevied
            // 
            this.textBoxRecevied.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRecevied.Enabled = false;
            this.textBoxRecevied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRecevied.Location = new System.Drawing.Point(6, 51);
            this.textBoxRecevied.Multiline = true;
            this.textBoxRecevied.Name = "textBoxRecevied";
            this.textBoxRecevied.Size = new System.Drawing.Size(370, 325);
            this.textBoxRecevied.TabIndex = 3;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect.Location = new System.Drawing.Point(258, 11);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(119, 33);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Bağlantı Kes";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect.Location = new System.Drawing.Point(133, 11);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(119, 33);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Bağlan";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(6, 16);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClear2);
            this.groupBox2.Controls.Add(this.buttonSend2);
            this.groupBox2.Controls.Add(this.textBoxSend2);
            this.groupBox2.Controls.Add(this.textBoxRecevied2);
            this.groupBox2.Controls.Add(this.buttonDisconnect2);
            this.groupBox2.Controls.Add(this.buttonConnect2);
            this.groupBox2.Controls.Add(this.comboBoxPorts2);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 456);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // buttonSend2
            // 
            this.buttonSend2.BackColor = System.Drawing.Color.Ivory;
            this.buttonSend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSend2.Location = new System.Drawing.Point(258, 382);
            this.buttonSend2.Name = "buttonSend2";
            this.buttonSend2.Size = new System.Drawing.Size(118, 33);
            this.buttonSend2.TabIndex = 5;
            this.buttonSend2.Text = "Gönder";
            this.buttonSend2.UseVisualStyleBackColor = false;
            this.buttonSend2.Click += new System.EventHandler(this.buttonSend2_Click);
            // 
            // textBoxSend2
            // 
            this.textBoxSend2.Location = new System.Drawing.Point(6, 382);
            this.textBoxSend2.Multiline = true;
            this.textBoxSend2.Name = "textBoxSend2";
            this.textBoxSend2.Size = new System.Drawing.Size(246, 68);
            this.textBoxSend2.TabIndex = 4;
            // 
            // textBoxRecevied2
            // 
            this.textBoxRecevied2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRecevied2.Enabled = false;
            this.textBoxRecevied2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRecevied2.Location = new System.Drawing.Point(6, 51);
            this.textBoxRecevied2.Multiline = true;
            this.textBoxRecevied2.Name = "textBoxRecevied2";
            this.textBoxRecevied2.Size = new System.Drawing.Size(370, 325);
            this.textBoxRecevied2.TabIndex = 3;
            // 
            // buttonDisconnect2
            // 
            this.buttonDisconnect2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonDisconnect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect2.Location = new System.Drawing.Point(258, 11);
            this.buttonDisconnect2.Name = "buttonDisconnect2";
            this.buttonDisconnect2.Size = new System.Drawing.Size(119, 33);
            this.buttonDisconnect2.TabIndex = 2;
            this.buttonDisconnect2.Text = "Bağlantı Kes";
            this.buttonDisconnect2.UseVisualStyleBackColor = false;
            this.buttonDisconnect2.Click += new System.EventHandler(this.buttonDisconnect2_Click);
            // 
            // buttonConnect2
            // 
            this.buttonConnect2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConnect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect2.Location = new System.Drawing.Point(133, 11);
            this.buttonConnect2.Name = "buttonConnect2";
            this.buttonConnect2.Size = new System.Drawing.Size(119, 33);
            this.buttonConnect2.TabIndex = 1;
            this.buttonConnect2.Text = "Bağlan";
            this.buttonConnect2.UseVisualStyleBackColor = false;
            this.buttonConnect2.Click += new System.EventHandler(this.buttonConnect2_Click);
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(6, 16);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts2.TabIndex = 0;
            // 
            // buttonClear1
            // 
            this.buttonClear1.BackColor = System.Drawing.Color.Snow;
            this.buttonClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear1.ForeColor = System.Drawing.Color.Black;
            this.buttonClear1.Location = new System.Drawing.Point(259, 420);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(118, 30);
            this.buttonClear1.TabIndex = 6;
            this.buttonClear1.Text = "Yazıları Sil";
            this.buttonClear1.UseVisualStyleBackColor = false;
            this.buttonClear1.Click += new System.EventHandler(this.buttonClear1_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.BackColor = System.Drawing.Color.Snow;
            this.buttonClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear2.ForeColor = System.Drawing.Color.Black;
            this.buttonClear2.Location = new System.Drawing.Point(260, 419);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(118, 30);
            this.buttonClear2.TabIndex = 7;
            this.buttonClear2.Text = "Yazıları Sil";
            this.buttonClear2.UseVisualStyleBackColor = false;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxRecevied;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSend2;
        private System.Windows.Forms.TextBox textBoxSend2;
        private System.Windows.Forms.TextBox textBoxRecevied2;
        private System.Windows.Forms.Button buttonDisconnect2;
        private System.Windows.Forms.Button buttonConnect2;
        private System.Windows.Forms.ComboBox comboBoxPorts2;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.Button buttonClear2;
    }
}

