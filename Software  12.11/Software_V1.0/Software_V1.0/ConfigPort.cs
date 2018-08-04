using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Software_V1._0
{
    public partial class ConfigPort : Form
    {
        private Form1 fm1 = null;
        public ConfigPort(Form callingform)
        {
            fm1 = callingform as Form1;
            InitializeComponent();
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cbPort.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbPort.Items[i++].Equals(s) == false)
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
            cbPort.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cbPort.SelectedIndex = 0;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.fm1.Serial_port(cbPort.Text, Convert.ToInt32(cbVel.Text), (Parity)cbPar.SelectedIndex, Convert.ToInt32(cbBd.Text),  (StopBits)cbSb.SelectedIndex);
            this.Close();

        }

        private void ConfigPort_Load(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            
            int i = 0;

  
            cbVel.SelectedText = "9600";

            i = 0;

            foreach (String str in Enum.GetNames(typeof(Parity)))
            {
                cbPar.Items.Add(str);

                if (str == "None")
                    cbPar.SelectedIndex = i;
                i++;

            }

            cbBd.SelectedText = "8";

            i = 0;

            foreach (String str in Enum.GetNames(typeof(StopBits)))
            {
                cbSb.Items.Add(str);
                if (str == "One")
                    cbSb.SelectedIndex = i;
                i++;
            }
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPort_Click(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            label6.Text = "Teste";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testCon_Click(object sender, EventArgs e)
        {
            SerialPort SerialCom = new SerialPort();
            if (SerialCom.IsOpen == true) SerialCom.Close();

            SerialCom.PortName = cbPort.Text;
            SerialCom.BaudRate =Convert.ToInt32(cbVel.Text);
            SerialCom.Parity =  (Parity)cbPar.SelectedIndex;
            SerialCom.DataBits =   Convert.ToInt32(cbBd.Text);
            SerialCom.StopBits = (StopBits)cbSb.SelectedIndex;

            try
            {
                SerialCom.Open();
                label6.Text = "Conexão bem sucedida!";

            }
            catch 
            {
                label6.Text = "Erro ao abrir porta";

            }
            if (SerialCom.IsOpen)
            {
                try
                {

                    SerialCom.Write("Teste\r\n");
                    label6.Text = "Sucesso!";
                    SerialCom.Close();
                }
                catch 
                {
                    label6.Text = "Erro ao enviar mensagem";
                }
                
            }
        }
    }
}
