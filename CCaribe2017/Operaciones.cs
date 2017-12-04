using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCaribe2017
{
    public class Operaciones
    {
        public string Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\db1.db;Version=3;");
            try
            {
                cnx.Open();

                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }

        public string ConsultaSinResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\db1.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataSet ConsultaConResultado(string sql)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\db1.db;Version=3;");
            try
            {
                cnx.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
