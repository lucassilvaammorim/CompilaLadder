using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Software_V1._0
{
    public partial class Form_DBAutoCLP : Form
    {
        DataBase db = new DataBase();
        Form1 fm = new Form1();
        public Form_DBAutoCLP(Form callingForm)
        {
            fm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form_DBAutoCLP_Load(object sender, EventArgs e)
        {
           dGAuto.DataSource =  db.Mostrar(fm.path_project + "\\" + fm.Nome_do_projeto);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



     
    }
}
