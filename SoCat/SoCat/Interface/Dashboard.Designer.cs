
namespace SoCat.Interface
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfullname = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnsongs = new System.Windows.Forms.Button();
            this.btnalbums = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmusicsongs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animealbumpanel = new System.Windows.Forms.Panel();
            this.lblanimealbum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musicalbumpanel = new System.Windows.Forms.Panel();
            this.lblmusicalbum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblanimesongs = new System.Windows.Forms.Label();
            this.lbltotalsongs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.panel2.SuspendLayout();
            this.animealbumpanel.SuspendLayout();
            this.musicalbumpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblfullname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnsettings);
            this.panel1.Controls.Add(this.btnsongs);
            this.panel1.Controls.Add(this.btnalbums);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.pbprofile);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 289);
            this.panel1.TabIndex = 0;
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(11, 84);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(116, 13);
            this.lblfullname.TabIndex = 1;
            this.lblfullname.Text = "lastname, firstname";
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Location = new System.Drawing.Point(-1, 239);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(145, 33);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Location = new System.Drawing.Point(-1, 208);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(145, 33);
            this.btnsettings.TabIndex = 4;
            this.btnsettings.Text = "SETTINGS";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnsongs
            // 
            this.btnsongs.FlatAppearance.BorderSize = 0;
            this.btnsongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsongs.Location = new System.Drawing.Point(-1, 177);
            this.btnsongs.Name = "btnsongs";
            this.btnsongs.Size = new System.Drawing.Size(145, 33);
            this.btnsongs.TabIndex = 3;
            this.btnsongs.Text = "SONGS";
            this.btnsongs.UseVisualStyleBackColor = true;
            this.btnsongs.Click += new System.EventHandler(this.btnsongs_Click);
            // 
            // btnalbums
            // 
            this.btnalbums.FlatAppearance.BorderSize = 0;
            this.btnalbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalbums.Location = new System.Drawing.Point(-1, 146);
            this.btnalbums.Name = "btnalbums";
            this.btnalbums.Size = new System.Drawing.Size(145, 33);
            this.btnalbums.TabIndex = 2;
            this.btnalbums.Text = "ALBUMS";
            this.btnalbums.UseVisualStyleBackColor = true;
            this.btnalbums.Click += new System.EventHandler(this.btnalbums_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Location = new System.Drawing.Point(-1, 115);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(145, 33);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "DASHBOARD";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // pbprofile
            // 
            this.pbprofile.BackColor = System.Drawing.Color.White;
            this.pbprofile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbprofile.Location = new System.Drawing.Point(30, 12);
            this.pbprofile.Name = "pbprofile";
            this.pbprofile.Size = new System.Drawing.Size(83, 58);
            this.pbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprofile.TabIndex = 1;
            this.pbprofile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbltotalsongs);
            this.panel2.Controls.Add(this.lblanimesongs);
            this.panel2.Controls.Add(this.lblmusicsongs);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.animealbumpanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.musicalbumpanel);
            this.panel2.Location = new System.Drawing.Point(151, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 240);
            this.panel2.TabIndex = 2;
            // 
            // lblmusicsongs
            // 
            this.lblmusicsongs.AutoSize = true;
            this.lblmusicsongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmusicsongs.Location = new System.Drawing.Point(78, 158);
            this.lblmusicsongs.Name = "lblmusicsongs";
            this.lblmusicsongs.Size = new System.Drawing.Size(16, 16);
            this.lblmusicsongs.TabIndex = 5;
            this.lblmusicsongs.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total # of Songs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Songs:";
            // 
            // animealbumpanel
            // 
            this.animealbumpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animealbumpanel.Controls.Add(this.lblanimealbum);
            this.animealbumpanel.Controls.Add(this.label7);
            this.animealbumpanel.Location = new System.Drawing.Point(194, 48);
            this.animealbumpanel.Name = "animealbumpanel";
            this.animealbumpanel.Size = new System.Drawing.Size(157, 95);
            this.animealbumpanel.TabIndex = 1;
            // 
            // lblanimealbum
            // 
            this.lblanimealbum.AutoSize = true;
            this.lblanimealbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanimealbum.Location = new System.Drawing.Point(0, 0);
            this.lblanimealbum.Name = "lblanimealbum";
            this.lblanimealbum.Size = new System.Drawing.Size(30, 31);
            this.lblanimealbum.TabIndex = 6;
            this.lblanimealbum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Anime Albums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Songs:";
            // 
            // musicalbumpanel
            // 
            this.musicalbumpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musicalbumpanel.Controls.Add(this.lblmusicalbum);
            this.musicalbumpanel.Controls.Add(this.label6);
            this.musicalbumpanel.Location = new System.Drawing.Point(19, 48);
            this.musicalbumpanel.Name = "musicalbumpanel";
            this.musicalbumpanel.Size = new System.Drawing.Size(157, 95);
            this.musicalbumpanel.TabIndex = 0;
            // 
            // lblmusicalbum
            // 
            this.lblmusicalbum.AutoSize = true;
            this.lblmusicalbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmusicalbum.Location = new System.Drawing.Point(0, 0);
            this.lblmusicalbum.Name = "lblmusicalbum";
            this.lblmusicalbum.Size = new System.Drawing.Size(30, 31);
            this.lblmusicalbum.TabIndex = 5;
            this.lblmusicalbum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Music Albums";
            // 
            // lblanimesongs
            // 
            this.lblanimesongs.AutoSize = true;
            this.lblanimesongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanimesongs.Location = new System.Drawing.Point(253, 158);
            this.lblanimesongs.Name = "lblanimesongs";
            this.lblanimesongs.Size = new System.Drawing.Size(16, 16);
            this.lblanimesongs.TabIndex = 6;
            this.lblanimesongs.Text = "0";
            // 
            // lbltotalsongs
            // 
            this.lbltotalsongs.AutoSize = true;
            this.lbltotalsongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsongs.Location = new System.Drawing.Point(221, 199);
            this.lbltotalsongs.Name = "lbltotalsongs";
            this.lbltotalsongs.Size = new System.Drawing.Size(19, 20);
            this.lbltotalsongs.TabIndex = 7;
            this.lbltotalsongs.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 287);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.animealbumpanel.ResumeLayout(false);
            this.animealbumpanel.PerformLayout();
            this.musicalbumpanel.ResumeLayout(false);
            this.musicalbumpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbprofile;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnsongs;
        private System.Windows.Forms.Button btnalbums;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel animealbumpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel musicalbumpanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmusicalbum;
        private System.Windows.Forms.Label lblmusicsongs;
        private System.Windows.Forms.Label lblanimealbum;
        private System.Windows.Forms.Label lblanimesongs;
        private System.Windows.Forms.Label lbltotalsongs;
    }
}