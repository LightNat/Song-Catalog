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
    public partial class Setup : Form
    {
        public static int counter = 0;
        public static int counter2 = 0;
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login.limiter--;
            foreach(Form form in Application.OpenForms)
            {
                if (form.Text == "Login")
                {
                    form.Focus();
                }
            }
        }

        private void txtmaster_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmaster.Text) ==  true)
            {
                btnmastershow.Enabled = false;
            }
            else
            {
                btnmastershow.Enabled = true;
            }
        }

        private void btnmastershow_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
            {
                btnmastershow.Text = "Show";
                txtmaster.PasswordChar = '*';       
            }
            else
            {
                btnmastershow.Text = "Hide";
                txtmaster.PasswordChar = '\0';      //to show the characters
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpassword.Text) == true)
            {
                btnpassword.Enabled = false;
            }
            else
            {
                btnpassword.Enabled = true;
            }
        }

        private void btnpassword_Click(object sender, EventArgs e)
        {
            counter2++;
            if (counter2 % 2 == 0)
            {
                btnpassword.Text = "Show";
                txtpassword.PasswordChar = '*';
            }
            else
            {
                btnpassword.Text = "Hide";
                txtpassword.PasswordChar = '\0';
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtmaster.Text) == true || String.IsNullOrEmpty(txtpassword.Text) == true)
                {
                    MessageBox.Show("Empty Fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "INSERT INTO Settings(accountSid, authToken, number, password, master) VALUES('', '', '', '"+txtpassword.Text+"', '"+txtmaster.Text+"' ) ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    Login.limiter--;
                    this.Visible = false;
                    MessageBox.Show("Passwords saved Successfully!", "First Time Setup Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Text == "Login")
                        {
                            form.Focus();
                        }
                    }

                    Connection.Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
