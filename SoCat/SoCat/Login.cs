using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoCat
{
    public partial class Login : Form
    {
        public static int limiter = 0;

        //Personal Info
        public static string id;
        public static string firstname;
        public static string lastname;
        public static string username;
        public static string password;
        public static string number;
        public static string profile;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var SoCat = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\SoCat.png";
            pictureBox1.Image = Image.FromFile(SoCat);

            var Title = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Title.png" ;
            pictureBox2.Image = Image.FromFile(Title);

            var Settings = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\setting.jpg";
            btnsettings.Image = Image.FromFile(Settings);

        }


        private void btnsettings_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT * FROM Settings";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();    //To check if there's already a data or not

                    if (limiter == 0)
                    {
                        limiter++;
                        Security.Security security = new Security.Security();
                        security.Show();
                    }
                }
                else
                {
                    if (limiter == 0)
                    {
                        limiter++;
                        Security.Setup setup = new Security.Setup();
                        setup.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //for focusing the form purpose only
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Security")
                {
                    form.Focus();
                    //break;          //Optional
                }
                else if (form.Text == "Sms")
                {
                    form.Focus();
                }
                else if (form.Text == "Master")
                {
                    form.Focus();
                }
                else if (form.Text == "Setup")
                {
                    form.Focus();
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Account.Account account = new Account.Account();
            this.Visible = false;
            account.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (limiter == 0)
                {
                    limiter++;
                    Forgot.Password password = new Forgot.Password();
                    password.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Password")
                {
                    form.Focus();
                }
            }

        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {

            }
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.Red;
            btnexit.ForeColor = Color.White;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.White;
            btnexit.ForeColor = Color.Red;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text) ==  true || String.IsNullOrEmpty(txtpassword.Text) == true)
            {
                MessageBox.Show("Error: Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "SELECT * FROM users WHERE username = '"+txtusername.Text+"' AND password = '"+txtpassword.Text+"' ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.reader = Function.Function.command.ExecuteReader();

                    if (Function.Function.reader.HasRows)
                    {
                        Function.Function.reader.Read();

                        txtusername.Text = Function.Function.reader.GetValue(3).ToString();
                        txtpassword.Text = Function.Function.reader.GetValue(4).ToString();

                        //Full info
                        id = Function.Function.reader.GetValue(0).ToString();
                        firstname = Function.Function.reader.GetValue(1).ToString();
                        lastname = Function.Function.reader.GetValue(2).ToString();
                        username = txtusername.Text;
                        password = txtpassword.Text;
                        number = Function.Function.reader.GetValue(5).ToString();
                        profile = Function.Function.reader.GetValue(6).ToString();

                        Interface.Dashboard dashboard = new Interface.Dashboard();
                        this.Visible = false;
                        dashboard.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
