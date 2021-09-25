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

namespace SoCat.Interface
{
    public partial class Settings : Form
    {
        public static bool changer = false;

        public int id;

        public static string profile;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Login.id);
            displayProfile();

            lblfullname.Text = Login.lastname + ", " + Login.firstname;
        }

        public void displayProfile()
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT * FROM users WHERE userid = '" + id + "' ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();

                    profile = Function.Function.reader.GetValue(6).ToString();

                    if (changer == false)
                    {
                        var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Profile\\" + profile;
                        pbprofile.Image = Image.FromFile(image);
                    }
                    else
                    {
                        var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Profile\\" + Login.profile;
                        pbprofile.Image = Image.FromFile(image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btndashboard_Click(object sender, EventArgs e)
        {
            Interface.Dashboard dashboard = new Interface.Dashboard();
            this.Visible = false;
            dashboard.Show();
        }

        private void btnalbums_Click(object sender, EventArgs e)
        {
            Interface.Albums albums = new Interface.Albums();
            this.Visible = false;
            albums.Show();
        }


        private void btnsongs_Click(object sender, EventArgs e)
        {
            Interface.Songs songs = new Interface.Songs();
            this.Visible = false;
            songs.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Interface.Settings settings = new Interface.Settings();
            this.Visible = false;
            settings.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Visible = false;
                login.Show();
            }
        }
    }
}
