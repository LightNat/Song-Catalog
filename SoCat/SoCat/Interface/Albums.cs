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
    public partial class Albums : Form
    {
        public static bool changer = false;

        public int id;

        public static string profile;

        public static string filename;

        public string genre;

        //Album Variable/s
        public int albumid;
        public string albumname;
        public string albumgenre;

        //dgv music variable/s
        public int albumID;
        public string albumPROFILE;
        public string albumNAME;
        public string albumGENRE;

        //dgv anime variable/s
        public int albumID2;
        public string albumPROFILE2;
        public string albumNAME2;
        public string albumGENRE2;

        public Albums()
        {
            InitializeComponent();
        }

        private void Albums_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Login.id);
            displayProfile();

            lblfullname.Text = Login.lastname + ", " + Login.firstname;

            var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\Button\\Uploader.png";
            btnupload.Image = Image.FromFile(image);

            //As Default every Load
            filename = "";

            //Filling Data Tables
            DataFill();
            DataFill2();

            dataGridViewSettings();     //For full row selection
        }
        
        //Data Table for Music
        public void DataFill()
        {
            Function.Function.gen = "SELECT album.albumid, album.profile, album.albumname, album.albumgenre FROM album WHERE userid = '" + id + "' AND album.albumgenre = 'Music' ";
            Function.Function.fill(Function.Function.gen, dgvmusic);
        }


        //Data Table for Anime
        public void DataFill2()
        {
            Function.Function.gen = "SELECT album.albumid, album.profile, album.albumname, album.albumgenre FROM album WHERE userid = '"+id+"' AND album.albumgenre = 'Anime Music' ";
            Function.Function.fill(Function.Function.gen, dgvanime);
        }

        public void dataGridViewSettings()
        {
            dgvmusic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvanime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Songs Data for Music Table
        public void DataFill3()
        {
            Function.Function.gen = "SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE Songs.albumid = '"+albumID+"' ";
            Function.Function.fill(Function.Function.gen, dgvmusicsong);
        }

        public void DataFill4()
        {
            Function.Function.gen = "SELECT Songs.songid, Songs.songtitle, Songs.songwriter, Songs.dateregistered  FROM album INNER JOIN Songs ON album.albumid = Songs.albumid WHERE Songs.albumid = '" + albumID2 + "' ";
            Function.Function.fill(Function.Function.gen, dgvanimesong);
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

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filename = open.FileName;
                pbalbumimage.Image = new Bitmap(filename);
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filename) == true)
            {
                MessageBox.Show("No Image File Detected!");
            }
            else if(String.IsNullOrWhiteSpace(txtalbumname.Text) == true)
            {
                MessageBox.Show("Album name must not be empty or a whitespace!");
            }
            else
            {
                try
                {
                    if (rdbAnime.Checked == true)
                    {
                        genre = "Anime Music";

                        try
                        {
                            var file = Path.GetFileName(filename);

                            Connection.Connection.DB();
                            Function.Function.gen = "INSERT INTO album(userid, profile, albumname, albumgenre) VALUES('" + id + "', '" + file + "', '" + txtalbumname.Text + "', '" + genre + "') ";
                            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                            Function.Function.command.ExecuteNonQuery();


                            try
                            {
                                File.Copy(filename, Path.Combine(@"C:\Users\gubot\source\repos\Song-Catalog\SoCat\SoCat\bin\Debug\Albums", file));
                            }
                            catch (Exception ex)
                            {
                                //nothing
                            }


                            try
                            {
                                Connection.Connection.DB();
                                Function.Function.gen = "SELECT * FROM album ORDER BY album.albumid DESC";
                                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                                Function.Function.reader = Function.Function.command.ExecuteReader();

                                if (Function.Function.reader.HasRows)
                                {
                                    Function.Function.reader.Read();

                                    string AlbumId = Function.Function.reader.GetValue(0).ToString();
                                    albumid = Convert.ToInt32(AlbumId);

                                    albumname = Function.Function.reader.GetValue(1).ToString();
                                    albumgenre = Function.Function.reader.GetValue(2).ToString();

                                    try
                                    {
                                        Connection.Connection.DB();
                                        Function.Function.gen = "INSERT INTO Anime(userid, albumid, dateregistered) VALUES('" + id + "', '" + albumid + "', '" + DateTime.Now.ToString() + "') ";
                                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                                        Function.Function.command.ExecuteNonQuery();

                                        MessageBox.Show("Album Saved Successfully!", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cleaner();

                                        tabControl1.SelectedTab = tabPage2;     //Changing the tabselected

                                        tabControl2.SelectedTab = tabPage4;     //changing the tabselected

                                        DataFill2();        //to load the table automatically

                                        Connection.Connection.conn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Connection.Connection.conn.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (rdbmusic.Checked == true)
                    {
                        genre = "Music";

                        try
                        {
                            var file = Path.GetFileName(filename);

                            Connection.Connection.DB();
                            Function.Function.gen = "INSERT INTO album(userid, profile, albumname, albumgenre) VALUES('" + id + "', '" + file + "', '" + txtalbumname.Text + "', '" + genre + "') ";
                            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                            Function.Function.command.ExecuteNonQuery();


                            try
                            {
                                File.Copy(filename, Path.Combine(@"C:\Users\gubot\source\repos\Song-Catalog\SoCat\SoCat\bin\Debug\Albums", file));
                            }
                            catch (Exception ex)
                            {
                                //nothing
                            }


                            try
                            {
                                Connection.Connection.DB();
                                Function.Function.gen = "SELECT * FROM album ORDER BY album.albumid DESC";
                                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                                Function.Function.reader = Function.Function.command.ExecuteReader();

                                if (Function.Function.reader.HasRows)
                                {
                                    Function.Function.reader.Read();

                                    string AlbumId = Function.Function.reader.GetValue(0).ToString();
                                    albumid = Convert.ToInt32(AlbumId);

                                    albumname = Function.Function.reader.GetValue(1).ToString();
                                    albumgenre = Function.Function.reader.GetValue(2).ToString();

                                    try
                                    {
                                        Connection.Connection.DB();
                                        Function.Function.gen = "INSERT INTO Music(userid, albumid, dateregistered) VALUES('" + id + "', '" + albumid + "', '" + DateTime.Now.ToString() + "') ";
                                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                                        Function.Function.command.ExecuteNonQuery();

                                        MessageBox.Show("Album Saved Successfully!", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cleaner();

                                        tabControl1.SelectedTab = tabPage2;     //Changing the tabselected

                                        tabControl2.SelectedTab = tabPage3;     //changing the tabselected

                                        DataFill();        //to load the table automatically

                                        Connection.Connection.conn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Connection.Connection.conn.Close();

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a genre for this Album and try Again!", "Genre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void cleaner()
        {
            filename = "";
            genre = "";
            txtalbumname.Text = "";
            pbalbumimage.Image = null;

            rdbAnime.Checked = false;
            rdbmusic.Checked = false;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                lblalbum.Visible = false;
                lbladd.Visible = true;
            }
            else
            {
                lblalbum.Visible = true;
                lbladd.Visible = false;
            }
        }

        private void dgvmusic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvmusic.Visible = false;
            btnback1.Visible = true;

            lblmusic.Visible = true;
            lblmusicalbumname.Visible = true;

            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvmusic[0, e.RowIndex].Value?.ToString();
                albumID = Convert.ToInt32(ALBUMid);

                albumPROFILE = dgvmusic[1, e.RowIndex].Value?.ToString();
                albumNAME = dgvmusic[2, e.RowIndex].Value?.ToString();
                albumGENRE = dgvmusic[3, e.RowIndex].Value?.ToString();

                //
                lblmusicalbumname.Text = albumNAME;

                dgvmusicsong.Visible = true;

                //show display
                txtsongtitle.Visible = true;
                txtsongwriter.Visible = true;
                lblsongtitle.Visible = true;
                lblsongwriter.Visible = true;

                DataFill3();

                if (String.IsNullOrEmpty(lblmusicalbumname.Text) == true)
                {
                    btnadd.Visible = false;
                }
                else
                {
                    btnadd.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvanime_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvanime.Visible = false;
            btnback2.Visible = true;

            lblanime.Visible = true;
            lblanimealbumname.Visible = true;

            try
            {
                //Data values
                //using '?' symbol to ignore NullReferenceException
                string ALBUMid = dgvanime[0, e.RowIndex].Value?.ToString();
                albumID2 = Convert.ToInt32(ALBUMid);

                albumPROFILE2 = dgvanime[1, e.RowIndex].Value?.ToString();
                albumNAME2 = dgvanime[2, e.RowIndex].Value?.ToString();
                albumGENRE2 = dgvanime[3, e.RowIndex].Value?.ToString();

                //
                lblanimealbumname.Text = albumNAME2;

                dgvanimesong.Visible = true;

                //Show Display
                txtsongtitle2.Visible = true;
                txtsongwriter2.Visible = true;
                lblsongtitle2.Visible = true;
                lblsongwriter2.Visible = true;

                DataFill4();

                if (String.IsNullOrEmpty(lblanimealbumname.Text) == true)
                {
                    btnadd2.Visible = false;
                }
                else
                {
                    btnadd2.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            dgvmusic.Visible = true;
            btnback1.Visible = false;

            lblmusic.Visible = false;
            lblmusicalbumname.Visible = false;

            dgvmusicsong.Visible = false;

            //hide display
            txtsongtitle.Visible = false;
            txtsongwriter.Visible = false;
            lblsongtitle.Visible = false;
            lblsongwriter.Visible = false;

            btnadd.Visible = false;
        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            dgvanime.Visible = true;
            btnback2.Visible = false;

            lblanime.Visible = false;
            lblanimealbumname.Visible = false;

            dgvanimesong.Visible = false;

            //hide display
            txtsongtitle2.Visible = false;
            txtsongwriter2.Visible = false;
            lblsongtitle2.Visible = false;
            lblsongwriter2.Visible = false;

        }

        //Add songs to album
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtsongtitle.Text) == true)
            {
                MessageBox.Show("Song Title must not be empty or whitespace!", "Song Title");
            }
            else if (String.IsNullOrWhiteSpace(txtsongwriter.Text) == true)
            {
                MessageBox.Show("Song Writer must not be empty or whitespace!", "Song Writer");
            }
            else
            {
                try
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "INSERT INTO Songs(albumid, songtitle, songwriter, dateregistered) VALUES('"+albumID+"', '"+txtsongtitle.Text+"', '"+txtsongwriter.Text+"', '"+DateTime.Now.ToString()+"') ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    MessageBox.Show("Song Added Successfully!", "SAVE");
                    DataFill3();
                    txtsongtitle.Text = "";
                    txtsongwriter.Text = "";

                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtsongtitle2.Text) == true)
            {
                MessageBox.Show("Song Title must not be empty or whitespace!", "Song Title");
            }
            else if (String.IsNullOrWhiteSpace(txtsongwriter2.Text) == true)
            {
                MessageBox.Show("Song Writer must not be empty or whitespace!", "Song Writer");
            }
            else
            {
                try
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "INSERT INTO Songs(albumid, songtitle, songwriter, dateregistered) VALUES('" + albumID2 + "', '" + txtsongtitle2.Text + "', '" + txtsongwriter2.Text + "', '" + DateTime.Now.ToString() + "')";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    MessageBox.Show("Song Added Successfully!", "SAVE");
                    DataFill4();
                    txtsongtitle2.Text = "";
                    txtsongwriter2.Text = "";

                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
