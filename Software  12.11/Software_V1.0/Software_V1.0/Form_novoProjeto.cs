using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_V1._0
{
    public partial class Form_novoProjeto : Form
    {
        #region variaveis
        bool tipo_do_projeto = false;
        #endregion


        private Form1 newform = null;//manter o form principal como main handle
        public Form_novoProjeto(Form callingForm)
        {
            newform = callingForm as Form1;//mantem o form1 como principal
            InitializeComponent();
            
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (DiagramaLadder.Checked == true)
            {
                DiagramaLadder.Checked = false;
                radioButton1.Checked = true;
               // AutoCLP.Enabled = true;
               
            }


            tipo_do_projeto = true;

            
        }

        private void DiagramaLadder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
                DiagramaLadder.Checked = true;
                //AutoCLP.Enabled = false;
            }
           
            tipo_do_projeto = false;

        }
//File Browser *********************************************************************************************************************************************************
        private void Browse_NovoProjeto_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog navegador = new FolderBrowserDialog() { Description = "Selecione seu arquivo..." })
            {
    
                if (navegador.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(navegador.SelectedPath);
                    txtEndereço.Text = navegador.SelectedPath;
                }


            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();

            }
        }

        private void Goforward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
//********************************************************************************************************************************************************************************
        private void Exceção_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Cancelar_botaoNovoProjeto_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        private void Form_novoProjeto_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            radioButton1.Checked = true;
           

        }

        private void Ok_botaoNovoProjeto_Click(object sender, EventArgs e)
        {
            #region cria_projeto
            CriarPasta novo = new CriarPasta();
            novo.PastaDoProjeto(txtEndereço.Text + "\\" + txtNamePath.Text, tipo_do_projeto,txtNamePath.Text);
            #endregion



            #region reabrir_form1
            this.newform.NewProject(txtEndereço.Text,txtNamePath.Text,tipo_do_projeto, "");//aponta que o form 1 faz parte do form 2
            this.Close();
#endregion
        }

        private void ExcecaoLadder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Excecaoescrita_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void splitContainer_novoProjeto_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      }
   }

