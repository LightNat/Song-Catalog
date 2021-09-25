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
using static System.EventHandler;

namespace SoCat.Sms
{
    public partial class Sms : Form
    {
        //Timer
        public static Timer timer = new Timer();
        public static Timer timer2 = new Timer();
        public static Timer timer3 = new Timer();

        public static int lockercount = 0;
        public static int lockercount2 = 0;
        public static int lockercount3 = 0;


        public static int counter = 0;
        public static int counter2 = 0;
        public static int counter3 = 0;



        public Sms()
        {
            InitializeComponent();
        }

        private void Sms_Load(object sender, EventArgs e)
        {
            buttons();          //Set Buttons Image
            display();
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
                    //break;        //Optional
                }
            }
        }

        private void btnlocker_Click(object sender, EventArgs e)
        {
            lockercount++;
            if (lockercount % 2 == 0)
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                    btnlocker.Image = Image.FromFile(btnimage);

                    txtacctsid.Enabled = false;

                    try
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "UPDATE Settings SET accountSid = '"+txtacctsid.Text+"' ";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                        Function.Function.command.ExecuteNonQuery();

                        /*Timer Setup*/
                        timer.Enabled = true;
                        timer.Tick += new System.EventHandler(check);
                        timer.Start();

                        Connection.Connection.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\unlock.jpg";
                    btnlocker.Image = Image.FromFile(btnimage);

                    txtacctsid.Enabled = true;
                    
                    //support for balancing
                    timer.Enabled = true;
                    timer.Tick -= new System.EventHandler(check);
                    timer.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnlocker2_Click(object sender, EventArgs e)
        {
            lockercount2++;
            if (lockercount2 % 2 == 0)
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                    btnlocker2.Image = Image.FromFile(btnimage);

                    txtauthtoken.Enabled = false;

                    try
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "UPDATE Settings SET authToken = '"+txtauthtoken.Text+"' ";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                        Function.Function.command.ExecuteNonQuery();

                        /*Timer Setup*/
                        timer2.Enabled = true;
                        timer2.Tick += new System.EventHandler(check2);
                        timer2.Start();

                        Connection.Connection.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\unlock.jpg";
                    btnlocker2.Image = Image.FromFile(btnimage);

                    txtauthtoken.Enabled = true;

                    //support for balancing
                    timer2.Enabled = true;
                    timer2.Tick -= new System.EventHandler(check2);
                    timer2.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnlocker3_Click(object sender, EventArgs e)
        {
            lockercount3++;
            if (lockercount3 % 2 == 0)
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                    btnlocker3.Image = Image.FromFile(btnimage);

                    txtnumber.Enabled = false;

                    try
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "UPDATE Settings SET number = '"+txtnumber.Text+"' ";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                        Function.Function.command.ExecuteNonQuery();

                        /*Timer Setup*/
                        timer3.Enabled = true;
                        timer3.Tick += new System.EventHandler(check3);
                        timer3.Start();

                        Connection.Connection.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\unlock.jpg";
                    btnlocker3.Image = Image.FromFile(btnimage);

                    txtnumber.Enabled = true;

                    //support for balancing
                    timer3.Enabled = true;
                    timer3.Tick -= new System.EventHandler(check3);
                    timer3.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void buttons()
        {
            try
            {
                var btnimage = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                btnlocker.Image = Image.FromFile(btnimage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var btnimage2 = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                btnlocker2.Image = Image.FromFile(btnimage2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var btnimage3 = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Image\\Button\\lock.jpg";
                btnlocker3.Image = Image.FromFile(btnimage3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Security.Master master = new Security.Master();
            this.Visible = false;
            master.Show();
        }

        public void display()
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT Settings.accountSid FROM Settings";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    txtacctsid.Text = Function.Function.reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT Settings.authToken FROM Settings";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    txtauthtoken.Text = Function.Function.reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT Settings.number FROM Settings";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    txtnumber.Text = Function.Function.reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void check(Object Sender, EventArgs e)
        {
            timer.Interval = 1000;
            counter++;
            if (counter == 5)
            {
                lblcheck.Visible = false;
                timer.Stop();
                Console.WriteLine("Stop\n");
                counter = 0;

            }
            else
            {
                lblcheck.Visible = true;
                Console.WriteLine("" + counter);
            }
        }

        public void check2(Object Sender, EventArgs e)
        {
            timer2.Interval = 1000;
            counter2++;
            if (counter2 == 5)
            {
                lblcheck2.Visible = false;
                timer2.Stop();
                Console.WriteLine("Stop\n");
                counter2 = 0;

            }
            else
            {
                lblcheck2.Visible = true;
                Console.WriteLine("" + counter2);
            }
        }

        public void check3(Object Sender, EventArgs e)
        {
            timer3.Interval = 1000;
            counter3++;
            if (counter3 == 5)
            {
                lblcheck3.Visible = false;
                timer3.Stop();
                Console.WriteLine("Stop\n");
                counter3 = 0;

            }
            else
            {
                lblcheck3.Visible = true;
                Console.WriteLine("" + counter3);
            }
        }
    }
}
