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
    public partial class FormContatos : Form
    {
        string txt_a2, txt_d2;
        private Form1 newform = null;
        public FormContatos(Form callingform, string txt_a, string txt_d)
        {
            txt_a2 = txt_a;
            txt_d2 = txt_d;
            newform = callingform as Form1;//mantem o form1 como principal
            InitializeComponent();
        }
       

        private void FormContatos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//contato aberto
        {
            
        }

        private void btTrancisaoN_Click(object sender, EventArgs e)
        {
          
        }
        #region botoes_ladder
        private void btContatoFechado_Click(object sender, EventArgs e)//contato fechado
        {
            System.IO.File.WriteAllText(txt_a2, "3");
            System.IO.File.WriteAllText(txt_d2, "1");
        }

        private void btNovaLinha_Click(object sender, EventArgs e)//nova linha
        {
            System.IO.File.WriteAllText(txt_a2, "1");
            System.IO.File.WriteAllText(txt_d2, "1");
        }

        private void btAbrirParalelo_Click(object sender, EventArgs e)//abre paralelo
        {
            System.IO.File.WriteAllText(txt_a2, "4");
            System.IO.File.WriteAllText(txt_d2, "1");
        }

        private void btFecharParalelo_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_a2, "5");
            System.IO.File.WriteAllText(txt_d2, "1");
        }

        private void btContatoAberto_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_a2, "2");
            System.IO.File.WriteAllText(txt_d2, "1");
        }
     
            


        private void btsaida_Click_1(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txt_a2, "3");
            System.IO.File.WriteAllText(txt_d2, "1");
        }
        #endregion

    }
}
