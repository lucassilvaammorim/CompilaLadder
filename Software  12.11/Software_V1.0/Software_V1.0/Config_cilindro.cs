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
    public partial class Config_cilindro : Form
    {
        public string nome;
        public int saida,cil_av,cil_ret;
        public int duplo_solenoide;
        public String[] Nomes = new string[6];
        public int[] saidas = new int [6];
        public int[] Avanco = new int[6];
        public int[] Retorno = new int[6];
        
  
        private AutoClp newform = null;
        public Config_cilindro(Form callingForm,String[]Nomes_s, int[] saidas_s, int[] avanco, int[] retorno)
        {
            Nomes = Nomes_s;
            saidas = saidas_s;
            Avanco = avanco;
            Retorno = retorno;
            newform = callingForm as AutoClp;
            InitializeComponent();
        }

        private void Config_cilindro_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i ++)
            {
                cbSaida.Items.Add(i.ToString());
            }
            for (int i = 0; i < 12; i++)
            {
                cbRolRet.Items.Add(i.ToString());
                cbRolAvan.Items.Add(i.ToString());
            }
        
                cbSaida.Text = "1";
                cbRolAvan.Text = "1";
                cbRolRet.Text = "2";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool test_flag = false;

            for (int x = 0; x < 6; x++)
            {
                if (Nomes[x] == Nomecilindrotxt.Text) test_flag = true;
                if (saidas[x] == Convert.ToInt32(cbSaida.Text)) test_flag = true;
                if (Avanco[x] == Convert.ToInt32(cbRolAvan.Text) || Avanco[x] == Convert.ToInt32(cbRolRet.Text)) test_flag = true;
                if (Retorno[x] == Convert.ToInt32(cbRolAvan.Text) || Retorno[x] == Convert.ToInt32(cbRolRet.Text)) test_flag = true;
            
            }
            if (cbRolAvan.Text == cbRolRet.Text) test_flag = true;
            if (test_flag == false)
            {
                nome = Nomecilindrotxt.Text;
                saida = Convert.ToInt32(cbSaida.Text);
                cil_av = Convert.ToInt32(cbRolAvan.Text);
                cil_ret = Convert.ToInt32(cbRolRet.Text);

              




                this.DialogResult = DialogResult.OK;
                this.newform.CallBack(nome, saida, duplo_solenoide,cil_av,cil_ret);
                this.Close();
            }
            else {
                const string message = "O nome ou a saída já tem registro!";
                const string caption = "Erro";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbSaida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
