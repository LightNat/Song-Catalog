using System;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;
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

namespace SoCat.Account
{
    public partial class Account : Form
    {
        public static string profile;

        public bool status = false;

        //Settings info
        public static string accountSid;
        public static string authToken;
        public static string number;

        //User's info
        public static string latestid;
        public static string firstname;
        public static string lastname;
        public static string username;
        public static string password;
        public static string phonenumber;
        public static string profilename;

        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                lblimagefile.Text = open.FileName;
                pbimage.Image = new Bitmap(lblimagefile.Text);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var file = Path.GetFileName(lblimagefile.Text);
                profile = file;

                if (String.IsNullOrEmpty(txtfirstname.Text) == true || String.IsNullOrEmpty(txtlastname.Text) == true || String.IsNullOrEmpty(txtusername.Text) == true || String.IsNullOrEmpty(txtpassword.Text) == true || String.IsNullOrEmpty(txtnumber.Text) == true)
                {
                    MessageBox.Show("Error: Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(lblimagefile.Text) == true)
                {
                    MessageBox.Show("Error: Image File Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "INSERT INTO users(firstname, lastname, username, password, number, profile) VALUES('"+txtfirstname.Text+"', '"+txtlastname.Text+"', '"+txtusername.Text+"', '"+txtpassword.Text+"', ('+' +'"+txtnumber.Text+"'), '"+profile+"') ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    try
                    {
                        //Uploading the image selected
                        File.Copy(lblimagefile.Text, Path.Combine(@"C:\Users\gubot\source\repos\SoCat\SoCat\bin\Debug\Profile\", file)/*true(optional)*/);

                        status = true;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        status = true;
                    }

                    if (status == true)
                    {
                        Login login = new Login();
                        this.Visible = false;
                        login.Show();
                        MessageBox.Show("Registration Saved Successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }

                    SMS();

                    Connection.Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }


        public void SMS()
        {
            //Twilio functions
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT * FROM users ORDER BY users.userid DESC";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    //user's details
                    latestid = Function.Function.reader.GetValue(0).ToString();
                    firstname = Function.Function.reader.GetValue(1).ToString();
                    lastname = Function.Function.reader.GetValue(2).ToString();
                    username = Function.Function.reader.GetValue(3).ToString();
                    password = Function.Function.reader.GetValue(4).ToString();
                    phonenumber = Function.Function.reader.GetValue(5).ToString();
                    profilename = Function.Function.reader.GetValue(6).ToString();

                    try
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "SELECT * FROM Settings WHERE Settings.settingid = 1 ";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                        Function.Function.reader = Function.Function.command.ExecuteReader();

                        if (Function.Function.reader.HasRows)
                        {
                            Function.Function.reader.Read();

                            accountSid = Function.Function.reader.GetValue(1).ToString();
                            authToken = Function.Function.reader.GetValue(2).ToString();
                            number = Function.Function.reader.GetValue(3).ToString();



                            //Twilio API
                            string accountsid = accountSid;
                            string authtoken = authToken;

                            TwilioClient.Init(accountsid, authtoken);

                            var adminnumber = number;
                            var usernumber = phonenumber;

                            var message = MessageResource.Create(
                            body: "Welcome new User, please remember this info below incase you forgot your password and dont forget to update your latest phone number being used.\n\nUser ID:  "+latestid+"\nFirstname: "+firstname+"\tLastname: "+lastname+" ",
                            from: new Twilio.Types.PhoneNumber("+" + adminnumber),
                            to: new Twilio.Types.PhoneNumber("+" + usernumber)
                            );

                            Console.WriteLine(message.Sid);


                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {

                }
            }
            catch (ApiException e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
