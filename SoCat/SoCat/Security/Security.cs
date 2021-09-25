using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoCat.Security
{
    public partial class Security : Form
    {
        public static string password;

        public Security()
        {
            InitializeComponent();
        }

        private void Security_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT Settings.password FROM Settings";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    password = Function.Function.reader.GetValue(0).ToString();

                    if (txtpassword.Text == password)
                    {
                        Sms.Sms sms = new Sms.Sms();
                        this.Visible = false;
                        sms.Show();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login.limiter--;
            foreach(Form form in Application.OpenForms)
            {
                if (form.Text == "Login")
                {
                    form.Focus();   //Just to focus your login form after
                    break;          //Optional
                }
            }
        }
    }
}
