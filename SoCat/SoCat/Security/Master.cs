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
    public partial class Master : Form
    {
        public static int counter = 0;

        public static string masterpassword;

        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login.limiter--;

            this.Visible = false;

            foreach(Form form in Application.OpenForms)
            {
                if (form.Text == "Login")
                {
                    form.Focus();
                }
            }
        }

        private void txtmasterpassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT Settings.master FROM Settings;";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    masterpassword = Function.Function.reader.GetValue(0).ToString();

                    if (txtmasterpassword.Text == masterpassword)
                    {
                        lblstatus2.Visible = false;
                        lblstatus.Visible = true;
                        txtpassword.Enabled = true;
                        txtmasterpassword.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnupdate.Enabled = !String.IsNullOrEmpty(txtpassword.Text);
                btnshow.Visible = !String.IsNullOrEmpty(txtpassword.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter % 2 == 0)
            {
                btnshow.Text = "Show";
                txtpassword.PasswordChar = '*';
            }
            else
            {
                btnshow.Text = "Hide";
                txtpassword.PasswordChar = '\0';
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "UPDATE Settings SET password = '"+txtpassword.Text+"' ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.command.ExecuteNonQuery();

                Login.limiter--;
                this.Visible = false;
                MessageBox.Show("Password Updated Successfully!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach(Form form in Application.OpenForms)
                {
                    if (form.Text == "Login")
                    {
                        form.Focus();
                    }
                }


                Connection.Connection.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
