namespace Software_V1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarConecçãoSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSobreOSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOCLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPorts = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ArvoreDeArquivos = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Navegador = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.NovoProjetoAtalho = new System.Windows.Forms.ToolStripButton();
            this.AbrirProjetoAtalho = new System.Windows.Forms.ToolStripButton();
            this.SalvarAtalho = new System.Windows.Forms.ToolStripButton();
            this.CopilarAtalho = new System.Windows.Forms.ToolStripSplitButton();
            this.programaLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaida = new System.Windows.Forms.ToolStripSplitButton();
            this.reléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewLine = new System.Windows.Forms.ToolStripSplitButton();
            this.NovaLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.abertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.del_net = new System.Windows.Forms.ToolStripSplitButton();
            this.deleteNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.find_net_bt = new System.Windows.Forms.ToolStripSplitButton();
            this.findNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Navegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.bancoDeDadosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sobreToolStripMenuItem1,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirProjetoToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.imageres_1023;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirProjetoToolStripMenuItem
            // 
            this.abrirProjetoToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.shell32_46;
            this.abrirProjetoToolStripMenuItem.Name = "abrirProjetoToolStripMenuItem";
            this.abrirProjetoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirProjetoToolStripMenuItem.Text = "Abrir Projeto";
            this.abrirProjetoToolStripMenuItem.Click += new System.EventHandler(this.abrirProjetoToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.setupapi_35;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Enabled = false;
            this.salvarToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.shell32_16761;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.wpdshext_754;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDataBaseToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Enabled = false;
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // mostrarDataBaseToolStripMenuItem
            // 
            this.mostrarDataBaseToolStripMenuItem.Name = "mostrarDataBaseToolStripMenuItem";
            this.mostrarDataBaseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mostrarDataBaseToolStripMenuItem.Text = "Mostrar Data Base";
            this.mostrarDataBaseToolStripMenuItem.Click += new System.EventHandler(this.mostrarDataBaseToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarConecçãoSerialToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.sobreToolStripMenuItem.Text = "Configurações";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // configurarConecçãoSerialToolStripMenuItem
            // 
            this.configurarConecçãoSerialToolStripMenuItem.Name = "configurarConecçãoSerialToolStripMenuItem";
            this.configurarConecçãoSerialToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.configurarConecçãoSerialToolStripMenuItem.Text = "Configurar Conexão Serial";
            this.configurarConecçãoSerialToolStripMenuItem.Click += new System.EventHandler(this.configurarConecçãoSerialToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualSobreOSoftwareToolStripMenuItem,
            this.sobreOCLPToolStripMenuItem});
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem1.Text = "Ajuda";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // manualSobreOSoftwareToolStripMenuItem
            // 
            this.manualSobreOSoftwareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualSobreOSoftwareToolStripMenuItem.Image")));
            this.manualSobreOSoftwareToolStripMenuItem.Name = "manualSobreOSoftwareToolStripMenuItem";
            this.manualSobreOSoftwareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.manualSobreOSoftwareToolStripMenuItem.Text = "Sobre o software";
            this.manualSobreOSoftwareToolStripMenuItem.Click += new System.EventHandler(this.manualSobreOSoftwareToolStripMenuItem_Click);
            // 
            // sobreOCLPToolStripMenuItem
            // 
            this.sobreOCLPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreOCLPToolStripMenuItem.Image")));
            this.sobreOCLPToolStripMenuItem.Name = "sobreOCLPToolStripMenuItem";
            this.sobreOCLPToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sobreOCLPToolStripMenuItem.Text = "Sobre o CLP";
            this.sobreOCLPToolStripMenuItem.Click += new System.EventHandler(this.sobreOCLPToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.mfc100_16931;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbPorts});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portToolStripMenuItem.Text = "Port";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 23);
            this.cbPorts.Click += new System.EventHandler(this.cbPorts_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ArvoreDeArquivos);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Navegador);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(890, 404);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 2;
            // 
            // ArvoreDeArquivos
            // 
            this.ArvoreDeArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArvoreDeArquivos.ImageIndex = 1;
            this.ArvoreDeArquivos.ImageList = this.imageList1;
            this.ArvoreDeArquivos.Location = new System.Drawing.Point(0, 0);
            this.ArvoreDeArquivos.Name = "ArvoreDeArquivos";
            this.ArvoreDeArquivos.SelectedImageIndex = 0;
            this.ArvoreDeArquivos.Size = new System.Drawing.Size(190, 404);
            this.ArvoreDeArquivos.TabIndex = 1;
            this.ArvoreDeArquivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArvoreDeArquivos_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TxtFile.ico");
            this.imageList1.Images.SetKeyName(1, "Folder.ico");
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(190, 404);
            this.treeView1.TabIndex = 0;
            // 
            // Navegador
            // 
            this.Navegador.Controls.Add(this.StartPage);
            this.Navegador.Controls.Add(this.tabPage2);
            this.Navegador.Location = new System.Drawing.Point(2, 3);
            this.Navegador.Name = "Navegador";
            this.Navegador.SelectedIndex = 0;
            this.Navegador.Size = new System.Drawing.Size(692, 413);
            this.Navegador.TabIndex = 0;
            // 
            // StartPage
            // 
            this.StartPage.Location = new System.Drawing.Point(4, 22);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(684, 387);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "Start Page";
            this.StartPage.UseVisualStyleBackColor = true;
            this.StartPage.Click += new System.EventHandler(this.StartPage_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoProjetoAtalho,
            this.AbrirProjetoAtalho,
            this.bindingNavigatorSeparator,
            this.SalvarAtalho,
            this.CopilarAtalho,
            this.bindingNavigatorSeparator2,
            this.btnSaida,
            this.NewLine,
            this.toolStripButton1,
            this.del_net,
            this.find_net_bt});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(904, 26);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // NovoProjetoAtalho
            // 
            this.NovoProjetoAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NovoProjetoAtalho.Image = global::Software_V1._0.Properties.Resources.imageres_1023;
            this.NovoProjetoAtalho.Name = "NovoProjetoAtalho";
            this.NovoProjetoAtalho.RightToLeftAutoMirrorImage = true;
            this.NovoProjetoAtalho.Size = new System.Drawing.Size(23, 23);
            this.NovoProjetoAtalho.Text = "Novo projeto";
            this.NovoProjetoAtalho.Click += new System.EventHandler(this.NovoProjetoAtalho_Click);
            // 
            // AbrirProjetoAtalho
            // 
            this.AbrirProjetoAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AbrirProjetoAtalho.Image = global::Software_V1._0.Properties.Resources.shell32_46;
            this.AbrirProjetoAtalho.Name = "AbrirProjetoAtalho";
            this.AbrirProjetoAtalho.RightToLeftAutoMirrorImage = true;
            this.AbrirProjetoAtalho.Size = new System.Drawing.Size(23, 23);
            this.AbrirProjetoAtalho.Text = "Abrir Projeto";
            this.AbrirProjetoAtalho.Click += new System.EventHandler(this.AbrirProjetoAtalho_Click);
            // 
            // SalvarAtalho
            // 
            this.SalvarAtalho.AccessibleName = "Position";
            this.SalvarAtalho.AutoSize = false;
            this.SalvarAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SalvarAtalho.Enabled = false;
            this.SalvarAtalho.Image = global::Software_V1._0.Properties.Resources.shell32_16761;
            this.SalvarAtalho.ImageTransparentColor = System.Drawing.Color.Black;
            this.SalvarAtalho.Name = "SalvarAtalho";
            this.SalvarAtalho.Size = new System.Drawing.Size(23, 23);
            this.SalvarAtalho.Text = "Salvar";
            this.SalvarAtalho.ToolTipText = "Salvar";
            this.SalvarAtalho.Click += new System.EventHandler(this.SalvarAtalho_Click);
            // 
            // CopilarAtalho
            // 
            this.CopilarAtalho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaLadderToolStripMenuItem,
            this.autoCLPToolStripMenuItem});
            this.CopilarAtalho.Enabled = false;
            this.CopilarAtalho.Image = global::Software_V1._0.Properties.Resources.gameux_207;
            this.CopilarAtalho.Name = "CopilarAtalho";
            this.CopilarAtalho.RightToLeftAutoMirrorImage = true;
            this.CopilarAtalho.Size = new System.Drawing.Size(88, 23);
            this.CopilarAtalho.Text = "Compilar";
            this.CopilarAtalho.ButtonClick += new System.EventHandler(this.bindingNavigatorMoveLastItem_ButtonClick);
            // 
            // programaLadderToolStripMenuItem
            // 
            this.programaLadderToolStripMenuItem.Name = "programaLadderToolStripMenuItem";
            this.programaLadderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.programaLadderToolStripMenuItem.Text = "Programa Ladder";
            this.programaLadderToolStripMenuItem.Click += new System.EventHandler(this.programaLadderToolStripMenuItem_Click);
            // 
            // autoCLPToolStripMenuItem
            // 
            this.autoCLPToolStripMenuItem.Name = "autoCLPToolStripMenuItem";
            this.autoCLPToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.autoCLPToolStripMenuItem.Text = "AutoCLP";
            this.autoCLPToolStripMenuItem.Click += new System.EventHandler(this.autoCLPToolStripMenuItem_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reléToolStripMenuItem});
            this.btnSaida.Enabled = false;
            this.btnSaida.Image = global::Software_V1._0.Properties.Resources.IconSaidaBPM;
            this.btnSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(32, 23);
            this.btnSaida.Text = "toolStripButton2";
            this.btnSaida.ToolTipText = "Relé";
            // 
            // reléToolStripMenuItem
            // 
            this.reléToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.IconSaidaBPM;
            this.reléToolStripMenuItem.Name = "reléToolStripMenuItem";
            this.reléToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reléToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reléToolStripMenuItem.Text = "Relé";
            this.reléToolStripMenuItem.Click += new System.EventHandler(this.reléToolStripMenuItem_Click);
            // 
            // NewLine
            // 
            this.NewLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewLine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovaLinha,
            this.abrirParaleloToolStripMenuItem,
            this.fecharParaleloToolStripMenuItem});
            this.NewLine.Enabled = false;
            this.NewLine.Image = global::Software_V1._0.Properties.Resources.IconLinhaBPM;
            this.NewLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewLine.Name = "NewLine";
            this.NewLine.Size = new System.Drawing.Size(32, 23);
            this.NewLine.Text = "toolStripButton3";
            this.NewLine.ToolTipText = "Net";
            // 
            // NovaLinha
            // 
            this.NovaLinha.Image = global::Software_V1._0.Properties.Resources.IconLinhaBPM;
            this.NovaLinha.Name = "NovaLinha";
            this.NovaLinha.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.NovaLinha.Size = new System.Drawing.Size(173, 22);
            this.NovaLinha.Text = "New network";
            this.NovaLinha.Click += new System.EventHandler(this.NovaLinha_Click);
            // 
            // abrirParaleloToolStripMenuItem
            // 
            this.abrirParaleloToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.IconAbreBPM;
            this.abrirParaleloToolStripMenuItem.Name = "abrirParaleloToolStripMenuItem";
            this.abrirParaleloToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.abrirParaleloToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.abrirParaleloToolStripMenuItem.Text = "Abrir Paralelo";
            this.abrirParaleloToolStripMenuItem.Click += new System.EventHandler(this.abrirParaleloToolStripMenuItem_Click);
            // 
            // fecharParaleloToolStripMenuItem
            // 
            this.fecharParaleloToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.IconFechaBPM;
            this.fecharParaleloToolStripMenuItem.Name = "fecharParaleloToolStripMenuItem";
            this.fecharParaleloToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.fecharParaleloToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fecharParaleloToolStripMenuItem.Text = "Fechar Paralelo";
            this.fecharParaleloToolStripMenuItem.Click += new System.EventHandler(this.fecharParaleloToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abertoToolStripMenuItem,
            this.fechadoToolStripMenuItem});
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Contatos";
            // 
            // abertoToolStripMenuItem
            // 
            this.abertoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abertoToolStripMenuItem.Image")));
            this.abertoToolStripMenuItem.Name = "abertoToolStripMenuItem";
            this.abertoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abertoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abertoToolStripMenuItem.Text = "Aberto";
            this.abertoToolStripMenuItem.Click += new System.EventHandler(this.abertoToolStripMenuItem_Click);
            // 
            // fechadoToolStripMenuItem
            // 
            this.fechadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fechadoToolStripMenuItem.Image")));
            this.fechadoToolStripMenuItem.Name = "fechadoToolStripMenuItem";
            this.fechadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fechadoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fechadoToolStripMenuItem.Text = "Fechado";
            this.fechadoToolStripMenuItem.Click += new System.EventHandler(this.fechadoToolStripMenuItem_Click);
            // 
            // del_net
            // 
            this.del_net.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.del_net.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteNetworkToolStripMenuItem});
            this.del_net.Enabled = false;
            this.del_net.Image = global::Software_V1._0.Properties.Resources.wpdshext_754;
            this.del_net.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del_net.Name = "del_net";
            this.del_net.Size = new System.Drawing.Size(32, 23);
            this.del_net.Text = "toolStripButton2";
            this.del_net.ToolTipText = "Del";
            // 
            // deleteNetworkToolStripMenuItem
            // 
            this.deleteNetworkToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.wpdshext_754;
            this.deleteNetworkToolStripMenuItem.Name = "deleteNetworkToolStripMenuItem";
            this.deleteNetworkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteNetworkToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteNetworkToolStripMenuItem.Text = "Delete network";
            this.deleteNetworkToolStripMenuItem.Click += new System.EventHandler(this.deleteNetworkToolStripMenuItem_Click);
            // 
            // find_net_bt
            // 
            this.find_net_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.find_net_bt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findNetworkToolStripMenuItem});
            this.find_net_bt.Enabled = false;
            this.find_net_bt.Image = global::Software_V1._0.Properties.Resources.mmcndmgr_30562;
            this.find_net_bt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.find_net_bt.Name = "find_net_bt";
            this.find_net_bt.Size = new System.Drawing.Size(32, 23);
            this.find_net_bt.Text = "toolStripButton3";
            this.find_net_bt.ToolTipText = "Find network";
            // 
            // findNetworkToolStripMenuItem
            // 
            this.findNetworkToolStripMenuItem.Image = global::Software_V1._0.Properties.Resources.mmcndmgr_30562;
            this.findNetworkToolStripMenuItem.Name = "findNetworkToolStripMenuItem";
            this.findNetworkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findNetworkToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.findNetworkToolStripMenuItem.Text = "Find Network";
            this.findNetworkToolStripMenuItem.Click += new System.EventHandler(this.findNetworkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ".";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Navegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualSobreOSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOCLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView ArvoreDeArquivos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl Navegador;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.ToolStripButton AbrirProjetoAtalho;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton SalvarAtalho;
        private System.Windows.Forms.ToolStripSplitButton CopilarAtalho;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton NovoProjetoAtalho;
        private System.Windows.Forms.ToolStripSplitButton NewLine;
        private System.Windows.Forms.ToolStripMenuItem NovaLinha;
        private System.Windows.Forms.ToolStripMenuItem abrirParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton btnSaida;
        private System.Windows.Forms.ToolStripMenuItem reléToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem abertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem programaLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarConecçãoSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton del_net;
        private System.Windows.Forms.ToolStripMenuItem deleteNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton find_net_bt;
        private System.Windows.Forms.ToolStripMenuItem findNetworkToolStripMenuItem;
    }
}

