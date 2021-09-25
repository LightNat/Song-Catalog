using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoCat.Forgot
{
    public partial class Password : Form
    {
        public static string id;
        public static string username;
        public static string password;
        public static string number;

        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login.limiter--;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Login")
                {
                    form.Focus();
                }
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtid.Text) == true)
            {
                btnsend.Enabled = false;
            }
            else
            {
                btnsend.Enabled = true;
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT * FROM users WHERE users.userid = '"+txtid.Text+"' ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    id = Function.Function.reader.GetValue(0).ToString();
                    username = Function.Function.reader.GetValue(3).ToString();
                    password = Function.Function.reader.GetValue(4).ToString();
                    number = Function.Function.reader.GetValue(5).ToString();

                    try
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "SELECT * FROM Settings WHERE Settings.settingid = 1 ";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                        Function.Function.reader = Function.Function.command.ExecuteReader();

                        if (Function.Function.reader.HasRows)
                        {
                            Function.Function.reader.Read();

                            Account.Account.accountSid = Function.Function.reader.GetValue(1).ToString();
                            Account.Account.authToken = Function.Function.reader.GetValue(2).ToString();
                            Account.Account.number = Function.Function.reader.GetValue(3).ToString();



                            //Twilio API
                            string accountsid = Account.Account.accountSid;
                            string authtoken = Account.Account.authToken;

                            TwilioClient.Init(accountsid, authtoken);

                            var adminnumber = Account.Account.number;
                            var usernumber = number;

                            var message = MessageResource.Create(
                            body: "This message is from your Application named SoCat(Song Catalog).\n\nUser ID:  "+id+"\nUsername: "+username+"\t\tPassword: "+password+" ",
                            from: new Twilio.Types.PhoneNumber("+" + adminnumber),
                            to: new Twilio.Types.PhoneNumber("+" + usernumber)
                            );
                            
                            Console.WriteLine(message.Sid);
                            MessageBox.Show("Message Sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("ID is Invalid!", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
