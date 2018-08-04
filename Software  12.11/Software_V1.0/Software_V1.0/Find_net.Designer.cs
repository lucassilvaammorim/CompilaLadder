namespace Software_V1._0
{
    partial class Find_net
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
            this.label1 = new System.Windows.Forms.Label();
            this.network_txt = new System.Windows.Forms.TextBox();
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network:";
            // 
            // network_txt
            // 
            this.network_txt.Location = new System.Drawing.Point(80, 45);
            this.network_txt.Name = "network_txt";
            this.network_txt.Size = new System.Drawing.Size(119, 22);
            this.network_txt.TabIndex = 1;
            this.network_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.network_txt_KeyPress);
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(15, 113);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(87, 30);
            this.ok_bt.TabIndex = 2;
            this.ok_bt.Text = "OK";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(108, 113);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(91, 30);
            this.cancel_bt.TabIndex = 3;
            this.cancel_bt.Text = "CANCELAR";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // Find_net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 155);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.network_txt);
            this.Controls.Add(this.label1);
            this.Name = "Find_net";
            this.Text = "Find_net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox network_txt;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
    }
}