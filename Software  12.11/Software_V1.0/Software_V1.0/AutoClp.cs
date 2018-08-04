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
    public partial class AutoClp : Form
    {
        
        #region variaveis_globais
        public int aux,tamanho_string;
        Boolean[] flag_cilindro = { false, false, false, false, false, false};
        Boolean[] flag_config = { false, false, false, false, false, false };
        public String[] Names = new String [6];
        public int[] Saidas_fisicas = new int[6];
        public int[] avanco = new int[6];
        public int[] retorno = new int[6];
        public String string_mestre;
        public Boolean continuo = false;
        string end;



        #endregion
        DataBase dt = new DataBase();
        public void CallBack(string nome, int saidas,int duplo_solenoide, int avanco_s, int retorno_s)
        {
            Config_cilindro fm = new Config_cilindro(this,Names,Saidas_fisicas,avanco,retorno);
            Names[aux] = nome;
            Saidas_fisicas[aux] = saidas;
            avanco[aux] = avanco_s;
            retorno[aux] = retorno_s;


            #region Mudar o texto dos botões
            switch (aux)
            { 
                case 0:
                    btA.Text = Names[0] + "+";
                    btna.Text = Names[0] + "-";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0,avanco_s,retorno_s);
                    break;

                case 1:
                    btnb.Text = Names[1] + "-";
                    btB.Text = Names[1] + "+";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0, avanco_s, retorno_s);
                    break;

                case 2:
                    btC.Text = Names[2] + "+";
                    btnc.Text = Names[2] + "-";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0, avanco_s, retorno_s);
                    break;

                case 3:
                    btD.Text = Names[3] + "+";
                    btnd.Text = Names[3] + "-";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0, avanco_s, retorno_s);
                    break;

                case 4:
                    btE.Text = Names[4] + "+";
                    btne.Text = Names[4] + "-";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0, avanco_s, retorno_s);
                    break;

                case 5:
                    btF.Text = Names[5] + "+";
                    btnf.Text = Names[5] + "-";
                    dt.InsertDB(end, aux + 1, nome, saidas, duplo_solenoide, 0, avanco_s, retorno_s);
                    break;


            }
            #endregion

        }
        public AutoClp(string path)
        {
            InitializeComponent();
            end = path;
        }

        private void AutoClp_Load(object sender, EventArgs e)
        {
        

        }

        private void txtSequencia_TextChanged(object sender, EventArgs e)
        {
            string_mestre = txtSequencia.Text + "\n";
            tamanho_string = txtSequencia.TextLength;
        }

        #region Btn_Avanço
        private void btA_Click(object sender, EventArgs e)
        {
            #region Escreve_A

            if (!flag_config[0])
            {
                Config_cilindro fm = new Config_cilindro(this,Names,Saidas_fisicas,avanco,retorno);
                aux = 0;
                DialogResult res = fm.ShowDialog();
                if (res != DialogResult.Cancel) flag_config[0] = true;
                

            }
            else
            {
                if (flag_cilindro[0] == false)
                {
                    
                    txtSequencia.Text += "_" + Names[0] + "+";
                    flag_cilindro[0] = true;
                }
                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro A já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btB_Click(object sender, EventArgs e)
        {
            #region Escreve_B
            if (!flag_config[1])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 1;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[1] = true;

            }
            else
            {
                if (flag_cilindro[1] == false)
                {
                    txtSequencia.Text += "_" + Names[1] + "+";
                    flag_cilindro[1] = true;
                }

                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro B já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btC_Click(object sender, EventArgs e)
        {
            #region Escreve_C
            if (!flag_config[2])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 2;
                DialogResult res = fm.ShowDialog();
                if (res != DialogResult.Cancel)flag_config[2] = true;

            }
            else
            {
                if (flag_cilindro[2] == false)
                {
                    txtSequencia.Text += "_" + Names[2] + "+";
                    flag_cilindro[2] = true;
                }

                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro C já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion


        }

        private void btE_Click(object sender, EventArgs e)
        {
            #region Escreve_E
            if (!flag_config[4])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 4;
                DialogResult res = fm.ShowDialog();
                if (res != DialogResult.Cancel)flag_config[4] = true;

            }
            else
            {
                if (flag_cilindro[4] == false)
                {
                    txtSequencia.Text +="_" + Names[4] + "+";
                    flag_cilindro[4] = true;
                }
                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro E já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion
        }

        private void btD_Click(object sender, EventArgs e)
        {
            #region Escreve_D
            if (!flag_config[3])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 3;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[3] = true;

            }
            else
            {
                if (flag_cilindro[3] == false)
                {
                    txtSequencia.Text +="_" +  Names[3] + "+";
                    flag_cilindro[3] = true;
                }
                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro D já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btF_Click(object sender, EventArgs e)
        {
            #region Escreve_F
            if (!flag_config[5])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 5;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[5] = true;

            }
            else
            {
                if (flag_cilindro[5] == false)
                {
                    txtSequencia.Text += "_" + Names[5] + "+";
                    flag_cilindro[5] = true;
                }
                else
                {
                    DialogResult aviso = MessageBox.Show("O cilindro F já recebeu o comando de avanço, esperando comando de retorno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }
        #endregion



        #region Bt_retorno
        private void btna_Click(object sender, EventArgs e)
        {
            #region Ecreve_a
            if (!flag_config[0])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 0;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[0] = true;

            }
            else
            {

                if (flag_cilindro[0] == true)
                {
                    txtSequencia.Text += "_" + Names[0] + "-";
                    flag_cilindro[0] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro A já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btnb_Click(object sender, EventArgs e)
        {
            #region Escreve_b
            if (!flag_config[1])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 1;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[1] = true;

            }
            else
            {
                if (flag_cilindro[1] == true)
                {
                    txtSequencia.Text +="_" + Names[1] + "-";
                    flag_cilindro[1] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro B já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            #region Escreve_c
            if (!flag_config[2])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 2;
                DialogResult res = fm.ShowDialog();
               if (res != DialogResult.Cancel) flag_config[2] = true;

            }
            else
            {
                if (flag_cilindro[2] == true)
                {
                    txtSequencia.Text +="_" +  Names[2] + "-";
                    flag_cilindro[2] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro C já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            #region Escreve_d
            if (!flag_config[3])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 3;
                DialogResult res = fm.ShowDialog();
                if(res!= DialogResult.Cancel)flag_config[3] = true;

            }
            else
            {
                if (flag_cilindro[3] == true)
                {
                    txtSequencia.Text +="_" +  Names[3] + "-";
                    flag_cilindro[3] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro D já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btne_Click(object sender, EventArgs e)
        {
            #region Escreve_e
            if (!flag_config[4])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 4;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[4] = true;

            }
            else
            {
                if (flag_cilindro[4] == true)
                {
                    txtSequencia.Text +="_" + Names[4] + "-";
                    flag_cilindro[4] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro E já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }

        private void btnf_Click(object sender, EventArgs e)
        {
            #region Escreve_f
            if (!flag_config[5])
            {
                Config_cilindro fm = new Config_cilindro(this, Names, Saidas_fisicas, avanco, retorno);
                aux = 5;
                DialogResult res = fm.ShowDialog();
                if(res != DialogResult.Cancel)flag_config[5] = true;

            }
            else
            {
                if (flag_cilindro[5] == true)
                {
                    txtSequencia.Text +="_" + Names[5] + "-";
                    flag_cilindro[5] = false;
                }
                else
                {

                    DialogResult aviso = MessageBox.Show("O cilindro F já recebeu o comando de retorno, esperando comando de avanço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            #endregion

        }
        #endregion


        #region Bt_funções
        private void btContagem_Click(object sender, EventArgs e)
        {
            #region Add_contagem_na_tela
            String aux = ".(", completa, texto, text_selct; ;
            int final;
            string start;
            string stop;
            texto = txtSequencia.Text;

            if (txtSequencia.SelectedText == "")
            {
                txtSequencia.SelectAll();
                aux += txtSequencia.SelectedText + ")" + NumContagem.Text + "X" + ".";
                final = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                completa = texto.Substring(final, texto.Length - final);
                txtSequencia.Text = texto.Substring(0,txtSequencia.SelectionStart)+ aux + completa;
            }

            else if (!String.IsNullOrEmpty(txtSequencia.Text))
            {
                text_selct = txtSequencia.SelectedText;
                start = text_selct.Substring(0, 1);
                stop = text_selct.Substring(text_selct.Length - 1, 1);
                if ((stop == "+" || stop == "-" || stop == "_" || start == "." || start == "," || start == "'") && (start == "_" || start == "(" || start == "." || start == "," || start == "'"))
                {
                    aux += txtSequencia.SelectedText + ")" + NumContagem.Text + "X" + ".";
                    final = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                    completa = texto.Substring(final, texto.Length - final);
                    txtSequencia.Text = texto.Substring(0, txtSequencia.SelectionStart) + aux + completa;
                }
                else
                {
                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            }
            else if (String.IsNullOrEmpty(txtSequencia.Text))
            {
                const string message ="Selecione a sequência corretamente";
                const string caption = "Erro";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)//Clar  Contagem
        {
            NumContagem.Clear();
        }

        private void txtContagem_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            String texto, aux , final,text_selct,start,stop;
            int num;
            texto = txtSequencia.Text;

            if (txtSequencia.SelectedText == "")
            {
                DialogResult aviso = MessageBox.Show("Selecione o texto a ser deletado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!String.IsNullOrEmpty(txtSequencia.Text))
            {
                  text_selct = txtSequencia.SelectedText;
                start = text_selct.Substring(0, 1);
                stop = text_selct.Substring(text_selct.Length - 1, 1);
                if ((stop == "+" || stop == "-" || stop == "_" ||  start == "." || start == "," || start == "'") && (start == "_" || start == "(" || start == "." || start == "," || start == "'"))
                {
                    num = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                    aux = txtSequencia.Text.Substring(0, txtSequencia.SelectionStart);
                    final = txtSequencia.Text.Substring(num, txtSequencia.Text.Length - num);
                    txtSequencia.Text = aux + final;
                }
                else
                {
                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void NumContagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtTemporizacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
         
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            txtSequencia.Clear();
            Array.Clear(flag_cilindro, 0, 6);     
        }

        private void BaseSegundos_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void clrTemporizacao_Click(object sender, EventArgs e)
        {
            txtTemporizacao.Clear();
        }

        private void btTemporizacao_Click(object sender, EventArgs e)
        {
            #region add_temporizacao_na_tela
            int pos;
            String temp = ",(" + txtTemporizacao.Text + "),", completa, text_selct;
            String texto = txtSequencia.Text;
            string start;
            string stop;

            if (txtSequencia.SelectedText == "")
            {
                txtSequencia.SelectAll();
                text_selct = txtSequencia.SelectedText;
                pos = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                completa = texto.Substring(pos, texto.Length - pos);
                txtSequencia.Text = texto.Substring(0, txtSequencia.SelectionStart) + text_selct + temp + completa;
            }

            else if (!String.IsNullOrEmpty(txtSequencia.Text))
            {
                
                text_selct = txtSequencia.SelectedText;
                start = text_selct.Substring(0, 1);
                stop = text_selct.Substring(text_selct.Length - 1, 1);
                if ((stop == "+" || stop == "-" || stop == "_" || start == "." || start == "," || start == "'") && (start == "_" || start == "(" || start == "." || start == "," || start == "'"))
                {
                    pos = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                    completa = texto.Substring(pos, texto.Length - pos);
                    txtSequencia.Text = texto.Substring(0, txtSequencia.SelectionStart) + text_selct + temp + completa;
                }
                else {
                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (String.IsNullOrEmpty(txtSequencia.Text))
            {
                const string message = "Selecione a sequência corretamente";
                const string caption = "Erro";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

        }

        private void btSimu_Click(object sender, EventArgs e)
        {
            #region add_simul_na_tela
            int pos;
            String completa, text_selct;
            String texto = txtSequencia.Text;
            string start;
            string stop;
            bool fail = false;

            if (txtSequencia.SelectedText == "")
            {
                txtSequencia.SelectAll();
                text_selct = txtSequencia.SelectedText;

                for (int k = 0; k < text_selct.Length; k++)//verifica codição impossível
                {
              
                    if (text_selct.Substring(k, 1) == "(") fail = true;
                }


                if (!fail)
                {

                    pos = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                    completa = texto.Substring(pos, texto.Length - pos);
                    txtSequencia.Text = texto.Substring(0, txtSequencia.SelectionStart) + "'(" + text_selct + ")'" + completa;
                }
                else {

                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fail = false;
                
                
                }

            }

            else if (!String.IsNullOrEmpty(txtSequencia.Text))
            {
                
                text_selct = txtSequencia.SelectedText;
                start = text_selct.Substring(0, 1);
                stop = text_selct.Substring(text_selct.Length - 1, 1);

                for (int k = 0; k < text_selct.Length; k++)//verifica codição impossível
                {
                    MessageBox.Show(text_selct.Substring(k, 1));
                    if (text_selct.Substring(k, 1) == "(") fail = true;
                }
                MessageBox.Show(fail.ToString());
                if (fail)
                {
                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fail = false;


                }
                

                else if ((stop == "+" || stop == "-" || stop == "_" || start == "." || start == "," || start == "'") && (start == "_" || start == "(" || start == "." || start == "," || start == "'"))
               {
                    text_selct = txtSequencia.SelectedText;
                    pos = txtSequencia.SelectionStart + txtSequencia.SelectionLength;
                    completa = texto.Substring(pos, texto.Length - pos);
                    txtSequencia.Text = texto.Substring(0, txtSequencia.SelectionStart) + "'(" + text_selct + ")'" + completa;
               }
               else
               {
                    const string message = "Selecione a sequência corretamente";
                    const string caption = "Erro";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

               }
            }
            else if (String.IsNullOrEmpty(txtSequencia.Text))
            {
                const string message = "Selecione a sequência corretamente";
                const string caption = "Erro";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
            #endregion 

        }
        #endregion

        private void btConinuo_CheckedChanged(object sender, EventArgs e)
        {
            if (btConinuo.Checked == true) continuo = true;
            else if (btConinuo.Checked == false) continuo = false;
        }

        private void NumContagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTemporizacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
