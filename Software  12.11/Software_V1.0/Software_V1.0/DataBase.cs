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
    class DataBase
    {
        private SqlCeCommand _cmd;
        private SqlCeConnection _con;
        private SqlCeDataAdapter _da;
        private DataTable _dt;
        private string conection;

        public void create(string endereco)
        {
            conection = "Data Source = " + endereco + "\\DataBase.sdf;Persist Security Info=False";
            SqlCeEngine en = new SqlCeEngine(conection);
            en.CreateDatabase();

        }
        public void NewTable(string endereco)
        {
            conection = "Data Source = " + endereco + "\\DataBase.sdf;Persist Security Info=False";
            _con = new SqlCeConnection(conection);
            _con.Open();
            _cmd = new SqlCeCommand(@"create table Table1 ( Id int, nome nvarchar(100), saida_fisica int,duplo_solenoide int, estado int , rolete_de_avanco int, rolete_de_retorno int)", _con);
            _cmd.ExecuteNonQuery();
            _con.Close();
        
        }
        public void InsertDB(string endereco,int Id,string nome,int saida,int duplo,int estado, int cilRet, int cilAv)
        {
            conection = "Data Source = " + endereco + "\\Debug\\DataBase.sdf;Persist Security Info=False";
            _con = new SqlCeConnection(conection);
            _con.Open();
            _cmd = new SqlCeCommand(@"INSERT INTO Table1 (Id,nome,saida_fisica, duplo_solenoide,estado, rolete_de_avanco, rolete_de_retorno) Values (@ID,@Name,@saida,@duplo,@estado,@rolAv,@rolRet)", _con);
            _cmd.Parameters.Add("@Name", nome);
            _cmd.Parameters.Add("@ID", Id);
            _cmd.Parameters.Add("@saida", saida);
            _cmd.Parameters.Add("@duplo", duplo);
            _cmd.Parameters.Add("@estado", estado);
            _cmd.Parameters.Add("@rolAv", cilAv);
           _cmd.Parameters.Add("@rolRet", cilRet);
            _cmd.ExecuteNonQuery();
            _con.Close();
        
        
        }
        public DataTable Mostrar(string endereco)
        {
            SqlCeDataReader datareader;

            conection = "Data Source = " + endereco + "\\Debug\\DataBase.sdf;Persist Security Info=False";
            _con = new SqlCeConnection(conection);
            _con.Open();
            _cmd = new SqlCeCommand(@"SELECT *FROM Table1 ", _con);
            _dt = new DataTable();
            datareader = _cmd.ExecuteReader();
            _dt.Load(datareader);
            _con.Close();
            return _dt;
                
        }


    }
}
