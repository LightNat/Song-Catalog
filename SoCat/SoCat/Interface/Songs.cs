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
    public partial class Songs : Form
    {
        public static bool changer = false;

        public int id;

        public static string profile;

        //dgv music variable/s
        public int albumID;
        public string albumPROFILE;
        public string albumNAME;

        //dgv anime variable/s
        public int albumID2;
        public string albumPROFILE2;
        public string albumNAME2;

        public Songs()
        {
            InitializeComponent();
        }

        private void Songs_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Login.id);
            displayProfile();
            pb();

            lblfullname.Text = Login.lastname + ", " + Login.firstname;

            dataGridViewSettings();
        }

        public void dataGridViewSettings()
        {
            dgvmusic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvanime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        public void pb()
        {
            try
            {
                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\Anime.png";
                pbanime.Image = Image.FromFile(image);

                var image2 = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\Music.png";
                pbmusic.Image = Image.FromFile(image2);
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

        private void pbmusic_Click(object sender, EventArgs e)
        {
            //hides the pb's
            pbmusic.Visible = false;
            pbanime.Visible = false;
            //hides the labels
            lblmusic.Visible = false;
            lblanime.Visible = false;

            dgvmusic.Visible = true;
            dgvanime.Visible = false;

            btnbackmusic.Visible = true;
            btnbackanime.Visible = false;

            pbmusic1.Visible = true;
            pbanime1.Visible = false;

            Function.Function.gen = "SELECT Music.musicid AS [Music Id], album.albumid, album.profile, album.albumname, Music.dateregistered FROM album INNER JOIN Music ON album.albumid = Music.albumid WHERE album.userid = '"+id+"' ";
            Function.Function.fill(Function.Function.gen, dgvmusic);
        }

        private void pbanime_Click(object sender, EventArgs e)
        {
            //hides the pb's
            pbmusic.Visible = false;
            pbanime.Visible = false;
            //hides the labels
            lblmusic.Visible = false;
            lblanime.Visible = false;

            dgvmusic.Visible = false;
            dgvanime.Visible = true;

            btnbackmusic.Visible = false;
            btnbackanime.Visible = true;

            pbmusic1.Visible = false;
            pbanime1.Visible = true;

            Function.Function.gen = "SELECT Anime.animeid AS [Anime Id], album.albumid, album.profile, album.albumname, Anime.dateregistered FROM album INNER JOIN Anime ON album.albumid = Anime.albumid WHERE album.userid = '" + id+"' ";
            Function.Function.fill(Function.Function.gen, dgvanime);
        }

        private void btnbackmusic_Click(object sender, EventArgs e)
        {
            //shows the pb's
            pbmusic.Visible = true;
            pbanime.Visible = true;
            //shows the labels
            lblmusic.Visible = true;
            lblanime.Visible = true;

            dgvmusic.Visible = false;
            dgvanime.Visible = false;

            btnbackmusic.Visible = false;
            btnbackanime.Visible = false;

            pbmusic1.Visible = false;
            pbanime1.Visible = false;
        }

        private void btnbackanime_Click(object sender, EventArgs e)
        {
            //shows the pb's
            pbmusic.Visible = true;
            pbanime.Visible = true;
            //shows the labels
            lblmusic.Visible = true;
            lblanime.Visible = true;

            dgvmusic.Visible = false;
            dgvanime.Visible = false;

            btnbackmusic.Visible = false;
            btnbackanime.Visible = false;

            pbmusic1.Visible = false;
            pbanime1.Visible = false;
        }

        private void dgvmusic_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvmusic.Visible = false;
            
            btnbackmusic.Visible = false;

            dgvmusicsong.Visible = true;

            pbmusic1.Visible = false;

            btnbackmusic2.Visible = true;

            lblcategory.Visible = true;
            lblalbum.Visible = true;

            lblmusiccategory.Text = "Music";
            lblmusiccategory.Visible = true;
            lblmusicalbum.Visible = true;

            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvmusic[1, e.RowIndex].Value?.ToString();
                albumID = Convert.ToInt32(ALBUMid);

                albumPROFILE = dgvmusic[2, e.RowIndex].Value?.ToString();
                albumNAME = dgvmusic[3, e.RowIndex].Value?.ToString();

                lblmusicalbum.Text = albumNAME;

                Function.Function.gen = "SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE Songs.albumid = '" + albumID + "' ";
                Function.Function.fill(Function.Function.gen, dgvmusicsong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvmusic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvmusic[1, e.RowIndex].Value?.ToString();
                albumID = Convert.ToInt32(ALBUMid);

                albumPROFILE = dgvmusic[2, e.RowIndex].Value?.ToString();
                albumNAME = dgvmusic[3, e.RowIndex].Value?.ToString();

                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Albums\\" + albumPROFILE;
                pbmusic1.Image = Image.FromFile(image);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                pbmusic1.Image = null;
            }
        }

        private void dgvanime_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvanime.Visible = false;

            btnbackanime.Visible = false;

            dgvanimesong.Visible = true;

            pbanime1.Visible = false;

            btnbackanime2.Visible = true;

            lblcategory.Visible = true;
            lblalbum.Visible = true;

            lblanimecategory.Text = "Anime Music";
            lblanimecategory.Visible = true;
            lblanimealbum.Visible = true;

            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvanime[1, e.RowIndex].Value?.ToString();
                albumID2 = Convert.ToInt32(ALBUMid);

                albumPROFILE2 = dgvanime[2, e.RowIndex].Value?.ToString();
                albumNAME2 = dgvanime[3, e.RowIndex].Value?.ToString();

                lblanimealbum.Text = albumNAME2;

                Function.Function.gen = "SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE Songs.albumid = '" + albumID2 + "' ";
                Function.Function.fill(Function.Function.gen, dgvanimesong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvanime_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvanime[1, e.RowIndex].Value?.ToString();
                albumID2 = Convert.ToInt32(ALBUMid);

                albumPROFILE2 = dgvanime[2, e.RowIndex].Value?.ToString();
                albumNAME2 = dgvanime[3, e.RowIndex].Value?.ToString();

                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "Albums\\" + albumPROFILE2;
                pbanime1.Image = Image.FromFile(image);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                pbanime1.Image = null;
            }
        }

        private void btnbackmusic2_Click(object sender, EventArgs e)
        {
            dgvmusic.Visible = true;

            btnbackmusic.Visible = true;

            dgvmusicsong.Visible = false;

            pbmusic1.Visible = true;

            btnbackmusic2.Visible = false;

            lblcategory.Visible = false;
            lblalbum.Visible = false;

            lblmusiccategory.Visible = false;
            lblmusicalbum.Visible = false;
        }

        private void btnbackanime2_Click(object sender, EventArgs e)
        {
            dgvanime.Visible = true;

            btnbackanime.Visible = true;

            dgvanimesong.Visible = false;

            pbanime1.Visible = true;

            btnbackanime2.Visible = false;

            lblcategory.Visible = false;
            lblalbum.Visible = false;

            lblanimecategory.Visible = false;
            lblanimealbum.Visible = false;
        }
    }
}
