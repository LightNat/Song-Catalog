using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoCat.Function
{
    class Function
    {
        public static string gen = "";              //Variable that holds sql statements
        public static SqlCommand command;           //Processes Sql Statements and Connection
        public static SqlDataReader reader;         //Retrieves data from Database

        public static void fill(string q, DataGridView dgv)
        {
            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(q, Connection.Connection.conn);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;        //Retrieves all records from dgv
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
