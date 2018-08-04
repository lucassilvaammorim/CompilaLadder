using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;


namespace Software_V1._0
{
    
    public partial class Form1 : Form
    {
        #region variaveis
        public string app_path = Application.StartupPath ;
        public string ExcecaodoProjeto = "";
        public string path_project = "";
        public string Nome_do_projeto = "";
        public string Flag_novoProjeto = "";
        public string txt_cmd;
        public string txt_d, txt_serial;
        string cmd;
        public bool tipop;
        public bool Flag_proj = false;
        bool Flag_exit = false;
        string s_port = "";
        string test;
        int baud_r;
        Parity par;
        int Bits_dados;
        StopBits Stopbit;
        Byte[] exa;
        bool inicio = false;
        string txt_tipo;
        #endregion

        #region processos
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private IntPtr Child = IntPtr.Zero;
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        AutoClp form2;
        ConfigPort Config_port;

        #region serial
        public delegate void Fdelegate(string a);
        SerialPort SerialCom = new SerialPort();
        string bfRecebe = string.Empty;
        string master_test;

#endregion

       
        #endregion

        public Form1()
        {
        
            InitializeComponent();
            SerialCom.DataReceived += new SerialDataReceivedEventHandler(SerialCom_DataReceived);

        }
        void bot_auto()
        {
            NovoProjetoAtalho.Enabled = false;
            AbrirProjetoAtalho.Enabled = false;
            novoToolStripMenuItem.Enabled = false;
            abrirProjetoToolStripMenuItem.Enabled = false;
            bancoDeDadosToolStripMenuItem.Enabled = true;
            CopilarAtalho.Enabled = true;
            programaLadderToolStripMenuItem.Enabled = false;

        
        
        }
        void bot_ladder()
        {
            NovoProjetoAtalho.Enabled = false;
            AbrirProjetoAtalho.Enabled = false;
            novoToolStripMenuItem.Enabled = false;
            abrirProjetoToolStripMenuItem.Enabled = false;
            CopilarAtalho.Enabled = true;
            autoCLPToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = true;
            SalvarAtalho.Enabled = true;
            btnSaida.Enabled = true;
            NewLine.Enabled = true;
            toolStripButton1.Enabled = true;
            del_net.Enabled = true;
            find_net_bt.Enabled = true;
        
        }
        public void find_net(string net)
        {
            System.IO.File.WriteAllText(txt_cmd, "fn" + net);
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        
        }
        void SerialCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            //throw new NotImplementedException();
            bfRecebe = SerialCom.ReadExisting();
            this.BeginInvoke(new Fdelegate(recebe_serial), new object[] { bfRecebe });


        }

        public void recebe_serial(string a)
        {
            master_test += a;
          
        }
        public void Serial_port(String port, int Baud_rate, Parity parity, int frame_size, StopBits Stop_bits)
        {
            s_port = port;
            baud_r = Baud_rate;
            par = parity;
            Bits_dados = frame_size;
            Stopbit = Stop_bits;

            conectar();
        
        }
        public void conectar()
        {
            if (s_port != "")
            {
                if (SerialCom.IsOpen == true) SerialCom.Close();

                SerialCom.PortName = s_port;
                SerialCom.BaudRate = baud_r;
                SerialCom.Parity = par;
                SerialCom.DataBits = Bits_dados;
                SerialCom.StopBits = Stopbit;


            }
            else
            {

                Config_port = new ConfigPort(this);
                Config_port.Show();
            }
        
        
        }
        public void OpenProject(string path, string tipo)
        {
            if (tipo == "Ladder")
            {
                Nome_do_projeto = Path.GetFileName(path);
                path_project = Path.GetDirectoryName(path);

                txt_cmd = path_project + "//" + Nome_do_projeto + "//" + "Debug//cmd.txt";
                txt_tipo = path_project + "//" + Nome_do_projeto + "//" + "Tipo//type.txt";
                txt_d = path_project + "//" + Nome_do_projeto + "//" + "Debug//flag.txt";
                txt_serial = path_project + "//" + Nome_do_projeto + "//" + "Debug//serial.txt";

             
                
                tabPage2.Text = Nome_do_projeto;

                abrirexe();
                Thread.Sleep(100);
                Splash_screen s = new Splash_screen();
                s.ShowDialog();
                System.IO.File.WriteAllText(txt_cmd, "l");
                System.IO.File.WriteAllText(txt_d, "1");
                bot_ladder();
                Navegador.SelectTab(tabPage2);

                
               
                


            }
            else
            {
                MessageBox.Show("Parametro Incorreto");

            }

        }
        public void NewProject (string path, string name, bool tipo, string excecao)
        {

            #region Info_projeto
            ExcecaodoProjeto = excecao;
            path_project = path;
            Nome_do_projeto = name;
            tipop = tipo;
            Flag_proj = true;
            
            tabPage2.Text = name;
            ListDirectory(ArvoreDeArquivos, path_project +"//"+ Nome_do_projeto);//criar lista de arquivos com o projeto
            #endregion

            #region trata_tipo_projeto
            if (tipop == false)
            {
                txt_cmd = path_project + "//" + Nome_do_projeto + "//" + "Debug//cmd.txt";
                txt_tipo = path_project + "//" + Nome_do_projeto + "//" + "Tipo//type.txt";
                txt_d = path_project + "//" + Nome_do_projeto + "//" + "Debug//flag.txt";
                txt_serial = path_project + "//" + Nome_do_projeto + "//" + "Debug//serial.txt";
                System.IO.File.WriteAllText(txt_tipo, "Ladder");
                abrirexe();
                Thread.Sleep(100);
                Splash_screen s = new Splash_screen();
                s.ShowDialog();
                bot_ladder();
                Navegador.SelectTab(tabPage2);
                
            }
            else if (tipop == true)
            {
                txt_tipo = path_project + "//" + Nome_do_projeto + "//" + "Tipo//type.txt";
                System.IO.File.WriteAllText(txt_tipo, "Auto");
                Abrir_Auto();
                bot_auto();
                Navegador.SelectTab(tabPage2);

            }
            #endregion

        }
   
        private void abrirexe()
        {
            #region Abrir_exe
            p = System.Diagnostics.Process.Start(path_project +"//"+ Nome_do_projeto + "//" + "Debug//CompilaLadder4.exe");
            while (p.MainWindowHandle == IntPtr.Zero)
            {
                p.Refresh();
                System.Threading.Thread.Sleep(200);
            }
            Child = p.MainWindowHandle;
            Win32.SetParent(Child, tabPage2.Handle);
            Win32.ShowWindow(Child, Win32.nCmdShow.SW_SHOWMAXIMIZED);
            #endregion

            #region Personalizar_exe
            //Retira a barra de título e as bordas da Janela do app externo
            int winLong = Win32.GetWindowLong(Child, Win32.GWL_STYLE);
            winLong &= ~((int)Win32.WS.WS_EX_DLGMODALFRAME | (int)Win32.WS.WS_EX_CLIENTEDGE | (int)Win32.WS.WS_EX_STATICEDGE | (int)Win32.WS.WS_POPUP);
            winLong &= ~((int)Win32.WS.WS_CAPTION | (int)Win32.WS.WS_THICKFRAME | (int)Win32.WS.WS_MINIMIZE | (int)Win32.WS.WS_MAXIMIZE);
            Win32.SetWindowLong(Child, Win32.GWL_STYLE, winLong);
            //redefine o tamanho
            Win32.SetWindowPos(Child, IntPtr.Zero, 0, 0, 700, tabPage2.Height, (uint)((uint)Win32.SWPF.FRAMECHANGED | (uint)Win32.SWPF.NOZORDER | (uint)Win32.SWPF.NOOWNERZORDER));
            #endregion






        }
        private void Abrir_Auto()
        {

            form2 = new AutoClp(path_project + "\\" + Nome_do_projeto);
            form2.TopLevel = false;
            form2.AutoScroll = true;
            form2.Parent = this;
            form2.Width = tabPage2.Width;
            form2.Height = tabPage2.Height;
            tabPage2.Controls.Add(form2);
            form2.Show();
        
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
           
            
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbPorts.Items.Add(valoresPort[i]);
            }
            cbPorts.Text = "COM1";
            #endregion
  
        }

        private void projetoAutomáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Fechar aplicação****************************************************************************************************************************************************
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flag_exit == false)
            {
                DialogResult exit = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
              

                if (exit == DialogResult.Yes)
                {
                    Flag_exit = true;
                    Application.Exit();
                    if (Flag_proj == true) p.Kill(); 


                }
                else if (exit == DialogResult.No)
                {

                    Flag_exit = false;

                }
            }
         
        }
        //************************************************************************************************************************************************************************

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_ButtonClick(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
//Fechar aplicação *****************************************************************************************************************************
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Flag_exit == false)
            {
               
                DialogResult exit = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (exit == DialogResult.Yes)
                {
                    if (Flag_proj == true && tipop == false)
                    {
                        p.Kill();

                    }
                    Flag_exit = true;
                    Application.Exit();

                    
                }
                else if (exit == DialogResult.No)
                {
                    e.Cancel = true;
                    
                }
            }
        }
//*******************************************************************************************************************************************************************
        private void programarSupervisórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NovoProjetoAtalho_Click(object sender, EventArgs e)
        {
            Form_novoProjeto fmr2 = new Form_novoProjeto(this);
            fmr2.Show();
        }

        //criando um novo projeto*****************************wizard*********************************************************************************************************
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_novoProjeto fmr2 = new Form_novoProjeto(this);
            fmr2.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navegador.SelectedTab = StartPage;          
        }
        
      
     
        //************************************************************* end wizard***************************************************************************************************

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void abrirProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(this);
            fm.Show();
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
             
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //**********************************************************************Criando arvore de arquivos***********************************************************
        private void ListDirectory(TreeView treeView, string path)
        {
            #region Criar_arvore de arquivos
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
            #endregion

        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryinfo)
        {
            var directoryNode = new TreeNode(directoryinfo.Name);
            foreach (var directory in directoryinfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
              
            }

            foreach (var file in directoryinfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;
        }
        //-**************************************************************************************************************************************************
        private void StartPage_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)//desenha linha
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//contato aberto
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//contato fechado
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)// saida
        {
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
   
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
          
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        #region botoes_lader
        private void abertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "ca");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void fechadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "cf");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void NovaLinha_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "nn");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void abrirParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "ap");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void fecharParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.IO.File.WriteAllText(txt_cmd, "fp");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void reléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "sa");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }
#endregion

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void cbPorts_Click(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cbPorts.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbPorts.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            cbPorts.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cbPorts.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cbPorts.SelectedIndex = 0;
        }
        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copilarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoCLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            #region variaveis
            bool novo_cil = false, flag_temp = false;
            int aux_cont = 0;
            string cil_atual = "";
            string TextPic = "";
            String[] avanco = { "A", "B", "C", "D", "E", "F" };
            String[] retorno = { "a", "b", "c", "d", "e", "f" };
            #endregion
            string testinho = "";
            if (s_port != "")
            {
                #region Algoritimo_string
                for (int aux = 0; aux < form2.tamanho_string; aux++)
                {


                    if (form2.string_mestre.Substring(aux, 1) == "_")
                    {
                        novo_cil = true;
                    }
                    else if (form2.string_mestre.Substring(aux, 2) == "'(")
                    {
                        
                        TextPic += "(;";
                        //MessageBox.Show(TextPic);
                        aux++;
                        flag_temp = false;

                    }
                    else if (form2.string_mestre.Substring(aux, 2) == ")'")
                    {
                        TextPic += ");";
                        //MessageBox.Show(TextPic);
                        aux++;
                        flag_temp = false;

                    }

                    else if (form2.string_mestre.Substring(aux, 2) == "),")
                    {
                        TextPic += "};";
                        // MessageBox.Show(TextPic);
                        aux++;
                        flag_temp = false;

                    }
                    else if (form2.string_mestre.Substring(aux, 2) == ",(")
                    {
                        int j;
                        int aux_temp = 0;
  

                        for (j = aux + 2; form2.string_mestre.Substring(j, 2) != "),"; j++) aux_temp++;
                        switch (aux_temp)
                        {
                            case 1:
                                TextPic += "{;0;0;0;";
                                break;
                            case 2:
                                TextPic += "{;0;0;";
                                break;
                            case 3:
                                TextPic += "{;0;";
                                break;
                            case 4:
                                TextPic += "{;";
                                break;

                        }

                        // MessageBox.Show(TextPic);
                        aux++;
                        flag_temp = true;

                    }
                    else if (flag_temp)
                    {
                        TextPic += form2.string_mestre.Substring(aux, 1) + ";";

                    }


                    else if (form2.string_mestre.Substring(aux, 2) == "X.")
                    {
                      
                        TextPic += "];";
                        // MessageBox.Show(TextPic);
                        aux++;

                    }

                    else if (form2.string_mestre.Substring(aux, 2) == ".(")
                    {
                        int j, k, l;
                        j = aux + 1;
                        aux_cont = 0;
                        int aux_temp = 0;
                        int aux_2 = 0;

                        for (int x = aux + 2; form2.string_mestre.Substring(x, 2) != "X."; x++) aux_temp++;
                        for (int y = aux_temp + aux; form2.string_mestre.Substring(y, 1) != ")"; y--, aux_2++) ;
                    
                            switch (aux_2)
                            {
                               
                                case 0:
                                    TextPic += "[;0;";
                                    break;
                                case 1:
                                    TextPic += "[;";
                                    break;

                            }

                        while (j < form2.tamanho_string)
                        {


                            if (form2.string_mestre.Substring(j, 2) == ".(") aux_cont++;

                            else if (form2.string_mestre.Substring(j, 2) == "X." && aux_cont == 0) break;
                            else if (form2.string_mestre.Substring(j, 2) == "X." && aux_cont > 0)
                            {
                                aux_cont--;
                            }

                            j++;

                        }

                        for (k = j; form2.string_mestre.Substring(k, 1) != ")"; k--) ;

                        l = k + 1;


                        do
                        {
                            if (form2.string_mestre.Substring(l, 1) == "X")
                            {
                                aux++;
                                break;
                            }
                            else
                            {
                                TextPic += form2.string_mestre.Substring(l, 1) + ";";
                               

                            }
                            l++;


                        } while (true);

                    }

                    else if (form2.string_mestre.Substring(aux, 1) == "+")
                    {
                        novo_cil = false;
                        for (int x = 0; x < 6; x++)
                        {

                            if (form2.Names[x] == cil_atual)
                            {
                                TextPic += avanco[x] + ";";


                            }

                        }
                        cil_atual = "";

                    }
                    else if (form2.string_mestre.Substring(aux, 1) == "-")
                    {
                        novo_cil = false;
                        for (int x = 0; x < 6; x++)
                        {

                            if (form2.Names[x] == cil_atual)
                            {
                                TextPic += retorno[x] + ";";
                               

                            }

                        }
                        cil_atual = "";

                    }

                    else if (novo_cil == true) cil_atual += form2.string_mestre.Substring(aux, 1);

                }

                if (form2.continuo == true) TextPic += "*;";
                try
                {

                    SerialCom.Open();
                    SerialCom.Write("&a");
                    testinho += "&a";
                    

                    for (int x = 0; x < 6; x ++)
                    {
                        try
                        {
                            SerialCom.Write(form2.Saidas_fisicas[x].ToString() + ";");
                            testinho += form2.Saidas_fisicas[x].ToString() + ";";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    for (int x = 0; x < 6; x++)
                    {
                        try
                        {
                            SerialCom.Write(form2.avanco[x].ToString() + ";");
                            testinho += form2.avanco[x].ToString() + ";";
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    for (int x = 0; x < 6; x++)
                    {
                        try
                        {
                            SerialCom.Write((form2.retorno[x]).ToString() + ";");
                            testinho += form2.retorno[x].ToString() + ";";
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    
                    for (int i = 0; i < TextPic.Length; i++)
                    {
                        SerialCom.Write(TextPic[i].ToString());
                        testinho += TextPic[i].ToString();
                        
                    }
                    //MessageBox.Show(testinho.ToString());

                    SerialCom.Write("&");
                    testinho += "&";
                    SerialCom.Close();

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Config_port = new ConfigPort(this);
                Config_port.Show();
            
            }
            #endregion
            
        }

        private void sobreOCLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DBAutoCLP da = new Form_DBAutoCLP(this); 
            da.Show();

        
        
        }

        private void configurarConecçãoSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config_port = new ConfigPort(this);
            Config_port.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

          
        }

        private void ArvoreDeArquivos_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void programaLadderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
            if (s_port != "")
            {
                Teste t;
                try
                {
                    System.IO.File.Delete(txt_serial);
                }
                catch
                { 
                
                }
                System.IO.File.WriteAllText(txt_cmd, "Co");
                System.IO.File.WriteAllText(txt_d, "1");
                SetForegroundWindow(p.MainWindowHandle);
                Thread.Sleep(200);
                try
                {
                    
                    
                    cmd = System.IO.File.ReadAllText(txt_serial);
                    t = new Teste(cmd);
                    t.ShowDialog();
                    SetForegroundWindow(p.MainWindowHandle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                



                try
                {
                    SerialCom.Open();
                   // MessageBox.Show(cmd);
                    SerialCom.Write("&l" + cmd + "&");
                    SerialCom.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Erro ao enviar programa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

            }
            else
            {
                Config_port = new ConfigPort(this);
                Config_port.Show();

            }

        }

        private void deleteNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "de");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void findNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find_net fn = new Find_net(this);
            fn.Show();
        }

        private void AbrirProjetoAtalho_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(this);
            fm.Show();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "k");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void SalvarAtalho_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_cmd, "k");
            System.IO.File.WriteAllText(txt_d, "1");
            SetForegroundWindow(p.MainWindowHandle);
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
           
        }

        private void manualSobreOSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    
        //**********************************************************************************************************************************************
    }//end form1
}
