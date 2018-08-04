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

namespace Software_V1._0
{
    public partial class Form2 : Form
    {
        List<string> listFiles = new List<string>();

        private Form1 newform = null;//manter o form principal como main handle
        public Form2(Form callingForm)
        {
            newform = callingForm as Form1;//mantem o form1 como principal
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog navegador = new FolderBrowserDialog() { Description = "Selecione seu arquivo..." })
            {

                if (navegador.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(navegador.SelectedPath);
                    txtPatch.Text = navegador.SelectedPath;
                }


            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.newform.OpenProject(txtPatch.Text, System.IO.File.ReadAllText(txtPatch.Text + "//" + "Tipo//type.txt"));
            this.Close();
 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btAnt_Click(object sender, EventArgs e)
        {

            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();

            }
        }

        private void btPro_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {

                webBrowser1.GoForward();
            }
        }
    }
}
