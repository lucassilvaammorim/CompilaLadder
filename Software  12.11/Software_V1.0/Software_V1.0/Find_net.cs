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
    public partial class Find_net : Form
    {
        private Form1 newform = null;//manter o form principal como main handle
        public Find_net(Form callingForm)
        {
            newform = callingForm as Form1;
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            this.newform.find_net(network_txt.Text);
            this.Close();
        }

        private void network_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!= 8) e.Handled = true;
        }
    }
}
