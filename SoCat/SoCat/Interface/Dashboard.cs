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
    public partial class Dashboard : Form
    {
        public static bool changer = false;

        public int id;

        public static string profile;

        public static int musicalbumcounter = 0;

        //for musicalbum
        public bool changeLoc = false;
        //for animealbum
        public bool changeLoc2 = false;


        public int musicalbum = 0;
        public int animealbum = 0;

        public int musicsongs = 0;
        public int animesongs = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Login.id);
            displayProfile();

            lblfullname.Text = Login.lastname + ", " + Login.firstname;

            musicDashboard();
            animeDashboard();
            totalSongs();

            try
            {
                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\albumpanel.png";
                musicalbumpanel.BackgroundImage = Image.FromFile(image);

                animealbumpanel.BackgroundImage = Image.FromFile(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            change();
            change2();
        }

        public void musicDashboard()
        {
            Connection.Connection.DB();
            Function.Function.gen = "SELECT COUNT(*) from Music WHERE Music.userid = '"+id+"' ";
            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
            Function.Function.reader = Function.Function.command.ExecuteReader();

            if (Function.Function.reader.HasRows)
            {
                Function.Function.reader.Read();

                lblmusicalbum.Text = Function.Function.reader.GetValue(0).ToString();

                musicalbum = Convert.ToInt32(lblmusicalbum.Text);

                if (musicalbum > 9)
                {
                    changeLoc = true;
                }
                else
                {
                    changeLoc = false;
                }
            }

            Connection.Connection.DB();
            Function.Function.gen = "SELECT COUNT(*) FROM(SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE album.albumgenre = 'Music' AND album.userid = '" + id + "') AS COUNTS ";
            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
            Function.Function.reader = Function.Function.command.ExecuteReader();

            if (Function.Function.reader.HasRows)
            {
                Function.Function.reader.Read();

                lblmusicsongs.Text = Function.Function.reader.GetValue(0).ToString();
                musicsongs = Convert.ToInt32(lblmusicsongs.Text);
            }
        }

        public void animeDashboard()
        {
            Connection.Connection.DB();
            Function.Function.gen = "SELECT COUNT(*) from Anime WHERE Anime.userid = '" + id + "'";
            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
            Function.Function.reader = Function.Function.command.ExecuteReader();

            if (Function.Function.reader.HasRows)
            {
                Function.Function.reader.Read();

                lblanimealbum.Text = Function.Function.reader.GetValue(0).ToString();
                animealbum = Convert.ToInt32(lblanimealbum.Text);

                if (animealbum > 9)
                {
                    changeLoc2 = true;
                }
                else
                {
                    changeLoc2 = false;
                }
            }

            Connection.Connection.DB();
            Function.Function.gen = "SELECT COUNT(*) FROM(SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE album.albumgenre = 'Anime Music' AND album.userid = '" + id + "') AS COUNTS ";
            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
            Function.Function.reader = Function.Function.command.ExecuteReader();

            if (Function.Function.reader.HasRows)
            {
                Function.Function.reader.Read();

                lblanimesongs.Text = Function.Function.reader.GetValue(0).ToString();
                animesongs = Convert.ToInt32(lblanimesongs.Text);
            }
        }

        public void totalSongs()
        {
            int totalsongs = musicsongs + animesongs;
            lbltotalsongs.Text = totalsongs.ToString();
        }

        public void change()
        {
            if (changeLoc == false)
            {
                this.lblmusicalbum.Location = new System.Drawing.Point(64, 42);
            }
            else
            {
                this.lblmusicalbum.Location = new System.Drawing.Point(54, 42);
            }
            
        }
        public void change2()
        {
            if (changeLoc2 == false)
            {
                this.lblanimealbum.Location = new System.Drawing.Point(64, 42);
            }
            else
            {
                this.lblanimealbum.Location = new System.Drawing.Point(54, 42);
            }
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
