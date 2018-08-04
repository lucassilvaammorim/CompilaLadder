namespace Software_V1._0
{
    partial class FormContatos
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
            this.BoxContatos = new System.Windows.Forms.GroupBox();
            this.BoxNetwork = new System.Windows.Forms.GroupBox();
            this.btsaida = new System.Windows.Forms.Button();
            this.btFecharParalelo = new System.Windows.Forms.Button();
            this.btAbrirParalelo = new System.Windows.Forms.Button();
            this.btNovaLinha = new System.Windows.Forms.Button();
            this.btTrancisaoN = new System.Windows.Forms.Button();
            this.btTransicaoP = new System.Windows.Forms.Button();
            this.btContatoFechado = new System.Windows.Forms.Button();
            this.btContatoAberto = new System.Windows.Forms.Button();
            this.BoxContatos.SuspendLayout();
            this.BoxNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxContatos
            // 
            this.BoxContatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BoxContatos.Controls.Add(this.btTrancisaoN);
            this.BoxContatos.Controls.Add(this.btTransicaoP);
            this.BoxContatos.Controls.Add(this.btContatoFechado);
            this.BoxContatos.Controls.Add(this.btContatoAberto);
            this.BoxContatos.Location = new System.Drawing.Point(12, 12);
            this.BoxContatos.Name = "BoxContatos";
            this.BoxContatos.Size = new System.Drawing.Size(78, 206);
            this.BoxContatos.TabIndex = 4;
            this.BoxContatos.TabStop = false;
            this.BoxContatos.Text = "Contatos:";
            // 
            // BoxNetwork
            // 
            this.BoxNetwork.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BoxNetwork.Controls.Add(this.btsaida);
            this.BoxNetwork.Controls.Add(this.btFecharParalelo);
            this.BoxNetwork.Controls.Add(this.btAbrirParalelo);
            this.BoxNetwork.Controls.Add(this.btNovaLinha);
            this.BoxNetwork.Location = new System.Drawing.Point(103, 12);
            this.BoxNetwork.Name = "BoxNetwork";
            this.BoxNetwork.Size = new System.Drawing.Size(74, 206);
            this.BoxNetwork.TabIndex = 5;
            this.BoxNetwork.TabStop = false;
            this.BoxNetwork.Text = "Network:";
            // 
            // btsaida
            // 
            this.btsaida.Image = global::Software_V1._0.Properties.Resources.IconSaidaBPM;
            this.btsaida.Location = new System.Drawing.Point(6, 158);
            this.btsaida.Name = "btsaida";
            this.btsaida.Size = new System.Drawing.Size(56, 34);
            this.btsaida.TabIndex = 3;
            this.btsaida.UseVisualStyleBackColor = true;
            this.btsaida.Click += new System.EventHandler(this.btsaida_Click_1);
            // 
            // btFecharParalelo
            // 
            this.btFecharParalelo.Image = global::Software_V1._0.Properties.Resources.IconFechaBPM;
            this.btFecharParalelo.Location = new System.Drawing.Point(6, 116);
            this.btFecharParalelo.Name = "btFecharParalelo";
            this.btFecharParalelo.Size = new System.Drawing.Size(56, 36);
            this.btFecharParalelo.TabIndex = 2;
            this.btFecharParalelo.UseVisualStyleBackColor = true;
            this.btFecharParalelo.Click += new System.EventHandler(this.btFecharParalelo_Click);
            // 
            // btAbrirParalelo
            // 
            this.btAbrirParalelo.Image = global::Software_V1._0.Properties.Resources.IconAbreBPM;
            this.btAbrirParalelo.Location = new System.Drawing.Point(6, 78);
            this.btAbrirParalelo.Name = "btAbrirParalelo";
            this.btAbrirParalelo.Size = new System.Drawing.Size(56, 36);
            this.btAbrirParalelo.TabIndex = 1;
            this.btAbrirParalelo.UseVisualStyleBackColor = true;
            this.btAbrirParalelo.Click += new System.EventHandler(this.btAbrirParalelo_Click);
            // 
            // btNovaLinha
            // 
            this.btNovaLinha.Image = global::Software_V1._0.Properties.Resources.IconLinhaBPM;
            this.btNovaLinha.Location = new System.Drawing.Point(6, 36);
            this.btNovaLinha.Name = "btNovaLinha";
            this.btNovaLinha.Size = new System.Drawing.Size(56, 36);
            this.btNovaLinha.TabIndex = 0;
            this.btNovaLinha.UseVisualStyleBackColor = true;
            this.btNovaLinha.Click += new System.EventHandler(this.btNovaLinha_Click);
            // 
            // btTrancisaoN
            // 
            this.btTrancisaoN.Image = global::Software_V1._0.Properties.Resources.IconNBMP;
            this.btTrancisaoN.Location = new System.Drawing.Point(7, 36);
            this.btTrancisaoN.Name = "btTrancisaoN";
            this.btTrancisaoN.Size = new System.Drawing.Size(56, 36);
            this.btTrancisaoN.TabIndex = 1;
            this.btTrancisaoN.UseVisualStyleBackColor = true;
            this.btTrancisaoN.Click += new System.EventHandler(this.btTrancisaoN_Click);
            // 
            // btTransicaoP
            // 
            this.btTransicaoP.Image = global::Software_V1._0.Properties.Resources.IconPBMP;
            this.btTransicaoP.Location = new System.Drawing.Point(7, 78);
            this.btTransicaoP.Name = "btTransicaoP";
            this.btTransicaoP.Size = new System.Drawing.Size(56, 34);
            this.btTransicaoP.TabIndex = 0;
            this.btTransicaoP.UseVisualStyleBackColor = true;
            this.btTransicaoP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btContatoFechado
            // 
            this.btContatoFechado.Image = global::Software_V1._0.Properties.Resources.Icon2BMP3;
            this.btContatoFechado.Location = new System.Drawing.Point(6, 116);
            this.btContatoFechado.Name = "btContatoFechado";
            this.btContatoFechado.Size = new System.Drawing.Size(56, 34);
            this.btContatoFechado.TabIndex = 2;
            this.btContatoFechado.UseVisualStyleBackColor = true;
            this.btContatoFechado.Click += new System.EventHandler(this.btContatoFechado_Click);
            // 
            // btContatoAberto
            // 
            this.btContatoAberto.Image = global::Software_V1._0.Properties.Resources.IconAbertoBMP;
            this.btContatoAberto.Location = new System.Drawing.Point(7, 158);
            this.btContatoAberto.Name = "btContatoAberto";
            this.btContatoAberto.Size = new System.Drawing.Size(56, 36);
            this.btContatoAberto.TabIndex = 3;
            this.btContatoAberto.UseVisualStyleBackColor = true;
            this.btContatoAberto.Click += new System.EventHandler(this.btContatoAberto_Click);
            // 
            // FormContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(189, 223);
            this.Controls.Add(this.BoxNetwork);
            this.Controls.Add(this.BoxContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContatos";
            this.Text = "FormContatos";
            this.Load += new System.EventHandler(this.FormContatos_Load);
            this.BoxContatos.ResumeLayout(false);
            this.BoxNetwork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTransicaoP;
        private System.Windows.Forms.Button btTrancisaoN;
        private System.Windows.Forms.Button btContatoFechado;
        private System.Windows.Forms.Button btContatoAberto;
        private System.Windows.Forms.GroupBox BoxContatos;
        private System.Windows.Forms.GroupBox BoxNetwork;
        private System.Windows.Forms.Button btFecharParalelo;
        private System.Windows.Forms.Button btAbrirParalelo;
        private System.Windows.Forms.Button btNovaLinha;
        private System.Windows.Forms.Button btsaida;
    }
}