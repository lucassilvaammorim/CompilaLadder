namespace Software_V1._0
{
    partial class Form_novoProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_novoProjeto));
            this.splitContainer_novoProjeto = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Browse_NovoProjeto = new System.Windows.Forms.Button();
            this.Goforward = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.txtNamePath = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelar_botaoNovoProjeto = new System.Windows.Forms.Button();
            this.Ok_botaoNovoProjeto = new System.Windows.Forms.Button();
            this.DiagramaLadder = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_novoProjeto)).BeginInit();
            this.splitContainer_novoProjeto.Panel1.SuspendLayout();
            this.splitContainer_novoProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_novoProjeto
            // 
            this.splitContainer_novoProjeto.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_novoProjeto.Name = "splitContainer_novoProjeto";
            // 
            // splitContainer_novoProjeto.Panel1
            // 
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.DiagramaLadder);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.Cancelar_botaoNovoProjeto);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.webBrowser1);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.label1);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.Ok_botaoNovoProjeto);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.Browse_NovoProjeto);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.Goforward);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.GoBack);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.txtNamePath);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.txtEndereço);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.label6);
            this.splitContainer_novoProjeto.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer_novoProjeto.Panel2
            // 
            this.splitContainer_novoProjeto.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_novoProjeto_Panel2_Paint);
            this.splitContainer_novoProjeto.Size = new System.Drawing.Size(829, 445);
            this.splitContainer_novoProjeto.SplitterDistance = 800;
            this.splitContainer_novoProjeto.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(4, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(657, 327);
            this.webBrowser1.TabIndex = 6;
            // 
            // Browse_NovoProjeto
            // 
            this.Browse_NovoProjeto.Location = new System.Drawing.Point(560, 398);
            this.Browse_NovoProjeto.Name = "Browse_NovoProjeto";
            this.Browse_NovoProjeto.Size = new System.Drawing.Size(101, 23);
            this.Browse_NovoProjeto.TabIndex = 5;
            this.Browse_NovoProjeto.Text = "Procurar";
            this.Browse_NovoProjeto.UseVisualStyleBackColor = true;
            this.Browse_NovoProjeto.Click += new System.EventHandler(this.Browse_NovoProjeto_Click);
            // 
            // Goforward
            // 
            this.Goforward.Location = new System.Drawing.Point(67, 400);
            this.Goforward.Name = "Goforward";
            this.Goforward.Size = new System.Drawing.Size(39, 21);
            this.Goforward.TabIndex = 4;
            this.Goforward.Text = ">>";
            this.Goforward.UseVisualStyleBackColor = true;
            this.Goforward.Click += new System.EventHandler(this.Goforward_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(22, 400);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(39, 21);
            this.GoBack.TabIndex = 3;
            this.GoBack.Text = "<<";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // txtNamePath
            // 
            this.txtNamePath.Location = new System.Drawing.Point(120, 346);
            this.txtNamePath.Name = "txtNamePath";
            this.txtNamePath.Size = new System.Drawing.Size(541, 20);
            this.txtNamePath.TabIndex = 0;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(120, 372);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(541, 20);
            this.txtEndereço.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project path:";
            // 
            // Cancelar_botaoNovoProjeto
            // 
            this.Cancelar_botaoNovoProjeto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_botaoNovoProjeto.Location = new System.Drawing.Point(453, 398);
            this.Cancelar_botaoNovoProjeto.Name = "Cancelar_botaoNovoProjeto";
            this.Cancelar_botaoNovoProjeto.Size = new System.Drawing.Size(101, 23);
            this.Cancelar_botaoNovoProjeto.TabIndex = 3;
            this.Cancelar_botaoNovoProjeto.Text = "Cancelar";
            this.Cancelar_botaoNovoProjeto.UseVisualStyleBackColor = true;
            this.Cancelar_botaoNovoProjeto.Click += new System.EventHandler(this.Cancelar_botaoNovoProjeto_Click);
            // 
            // Ok_botaoNovoProjeto
            // 
            this.Ok_botaoNovoProjeto.Location = new System.Drawing.Point(346, 398);
            this.Ok_botaoNovoProjeto.Name = "Ok_botaoNovoProjeto";
            this.Ok_botaoNovoProjeto.Size = new System.Drawing.Size(101, 23);
            this.Ok_botaoNovoProjeto.TabIndex = 4;
            this.Ok_botaoNovoProjeto.Text = "OK";
            this.Ok_botaoNovoProjeto.UseVisualStyleBackColor = true;
            this.Ok_botaoNovoProjeto.Click += new System.EventHandler(this.Ok_botaoNovoProjeto_Click);
            // 
            // DiagramaLadder
            // 
            this.DiagramaLadder.AutoSize = true;
            this.DiagramaLadder.Location = new System.Drawing.Point(193, 416);
            this.DiagramaLadder.Name = "DiagramaLadder";
            this.DiagramaLadder.Size = new System.Drawing.Size(106, 17);
            this.DiagramaLadder.TabIndex = 2;
            this.DiagramaLadder.TabStop = true;
            this.DiagramaLadder.Text = "Diagrama Ladder";
            this.DiagramaLadder.UseVisualStyleBackColor = true;
            this.DiagramaLadder.CheckedChanged += new System.EventHandler(this.DiagramaLadder_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(120, 416);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AutoCLP";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo do projeto:";
            // 
            // Form_novoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar_botaoNovoProjeto;
            this.ClientSize = new System.Drawing.Size(673, 445);
            this.Controls.Add(this.splitContainer_novoProjeto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_novoProjeto";
            this.Text = "Novo projeto";
            this.Load += new System.EventHandler(this.Form_novoProjeto_Load);
            this.splitContainer_novoProjeto.Panel1.ResumeLayout(false);
            this.splitContainer_novoProjeto.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_novoProjeto)).EndInit();
            this.splitContainer_novoProjeto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_novoProjeto;
        private System.Windows.Forms.RadioButton DiagramaLadder;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamePath;
        private System.Windows.Forms.Button Browse_NovoProjeto;
        private System.Windows.Forms.Button Goforward;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button Cancelar_botaoNovoProjeto;
        private System.Windows.Forms.Button Ok_botaoNovoProjeto;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}