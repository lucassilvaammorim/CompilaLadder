namespace Software_V1._0
{
    partial class ConfigPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPort));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSb = new System.Windows.Forms.ComboBox();
            this.cbBd = new System.Windows.Forms.ComboBox();
            this.cbPar = new System.Windows.Forms.ComboBox();
            this.cbVel = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.testCon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSb);
            this.groupBox1.Controls.Add(this.cbBd);
            this.groupBox1.Controls.Add(this.cbPar);
            this.groupBox1.Controls.Add(this.cbVel);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bit de Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pariedade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Porta";
            // 
            // cbSb
            // 
            this.cbSb.Enabled = false;
            this.cbSb.FormattingEnabled = true;
            this.cbSb.Location = new System.Drawing.Point(81, 127);
            this.cbSb.Name = "cbSb";
            this.cbSb.Size = new System.Drawing.Size(142, 21);
            this.cbSb.TabIndex = 4;
            // 
            // cbBd
            // 
            this.cbBd.Enabled = false;
            this.cbBd.FormattingEnabled = true;
            this.cbBd.Location = new System.Drawing.Point(81, 100);
            this.cbBd.Name = "cbBd";
            this.cbBd.Size = new System.Drawing.Size(142, 21);
            this.cbBd.TabIndex = 3;
            // 
            // cbPar
            // 
            this.cbPar.Enabled = false;
            this.cbPar.FormattingEnabled = true;
            this.cbPar.Location = new System.Drawing.Point(81, 73);
            this.cbPar.Name = "cbPar";
            this.cbPar.Size = new System.Drawing.Size(142, 21);
            this.cbPar.TabIndex = 2;
            // 
            // cbVel
            // 
            this.cbVel.Enabled = false;
            this.cbVel.FormattingEnabled = true;
            this.cbVel.Location = new System.Drawing.Point(81, 46);
            this.cbVel.Name = "cbVel";
            this.cbVel.Size = new System.Drawing.Size(142, 21);
            this.cbVel.TabIndex = 1;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(81, 19);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(142, 21);
            this.cbPort.TabIndex = 0;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            this.cbPort.Click += new System.EventHandler(this.cbPort_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(9, 264);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(102, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(117, 264);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(102, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teste";
            // 
            // testCon
            // 
            this.testCon.Location = new System.Drawing.Point(123, 224);
            this.testCon.Name = "testCon";
            this.testCon.Size = new System.Drawing.Size(102, 21);
            this.testCon.TabIndex = 4;
            this.testCon.Text = "Testar Conexão";
            this.testCon.UseVisualStyleBackColor = true;
            this.testCon.Click += new System.EventHandler(this.testCon_Click);
            // 
            // ConfigPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 299);
            this.Controls.Add(this.testCon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigPort";
            this.Text = "SERIAL";
            this.Load += new System.EventHandler(this.ConfigPort_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSb;
        private System.Windows.Forms.ComboBox cbBd;
        private System.Windows.Forms.ComboBox cbPar;
        private System.Windows.Forms.ComboBox cbVel;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button testCon;
    }
}