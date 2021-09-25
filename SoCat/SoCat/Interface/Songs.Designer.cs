
namespace SoCat.Interface
{
    partial class Songs
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
            this.btndashboard = new System.Windows.Forms.Button();
            this.lblfullname = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnalbums = new System.Windows.Forms.Button();
            this.btnsongs = new System.Windows.Forms.Button();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SongsPanel = new System.Windows.Forms.Panel();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblalbum = new System.Windows.Forms.Label();
            this.btnbackanime2 = new System.Windows.Forms.Button();
            this.btnbackmusic2 = new System.Windows.Forms.Button();
            this.btnbackanime = new System.Windows.Forms.Button();
            this.btnbackmusic = new System.Windows.Forms.Button();
            this.lblanime = new System.Windows.Forms.Label();
            this.lblmusic = new System.Windows.Forms.Label();
            this.pbmusic = new System.Windows.Forms.PictureBox();
            this.pbanime = new System.Windows.Forms.PictureBox();
            this.dgvmusic = new System.Windows.Forms.DataGridView();
            this.dgvanime = new System.Windows.Forms.DataGridView();
            this.pbmusic1 = new System.Windows.Forms.PictureBox();
            this.pbanime1 = new System.Windows.Forms.PictureBox();
            this.dgvmusicsong = new System.Windows.Forms.DataGridView();
            this.dgvanimesong = new System.Windows.Forms.DataGridView();
            this.lblanimealbum = new System.Windows.Forms.Label();
            this.lblmusicalbum = new System.Windows.Forms.Label();
            this.lblanimecategory = new System.Windows.Forms.Label();
            this.lblmusiccategory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.SongsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmusicsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanimesong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.lblfullname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnsettings);
            this.panel1.Controls.Add(this.btnalbums);
            this.panel1.Controls.Add(this.btnsongs);
            this.panel1.Controls.Add(this.pbprofile);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 289);
            this.panel1.TabIndex = 0;
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Location = new System.Drawing.Point(-1, 115);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(145, 33);
            this.btndashboard.TabIndex = 6;
            this.btndashboard.Text = "DASHBOARD";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
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
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Songs";
            // 
            // SongsPanel
            // 
            this.SongsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SongsPanel.Controls.Add(this.lblcategory);
            this.SongsPanel.Controls.Add(this.lblalbum);
            this.SongsPanel.Controls.Add(this.btnbackanime2);
            this.SongsPanel.Controls.Add(this.btnbackmusic2);
            this.SongsPanel.Controls.Add(this.btnbackanime);
            this.SongsPanel.Controls.Add(this.btnbackmusic);
            this.SongsPanel.Controls.Add(this.lblanime);
            this.SongsPanel.Controls.Add(this.lblmusic);
            this.SongsPanel.Controls.Add(this.pbmusic);
            this.SongsPanel.Controls.Add(this.pbanime);
            this.SongsPanel.Controls.Add(this.dgvmusic);
            this.SongsPanel.Controls.Add(this.dgvanime);
            this.SongsPanel.Controls.Add(this.pbmusic1);
            this.SongsPanel.Controls.Add(this.pbanime1);
            this.SongsPanel.Controls.Add(this.dgvmusicsong);
            this.SongsPanel.Controls.Add(this.dgvanimesong);
            this.SongsPanel.Controls.Add(this.lblanimealbum);
            this.SongsPanel.Controls.Add(this.lblmusicalbum);
            this.SongsPanel.Controls.Add(this.lblanimecategory);
            this.SongsPanel.Controls.Add(this.lblmusiccategory);
            this.SongsPanel.Location = new System.Drawing.Point(151, 35);
            this.SongsPanel.Name = "SongsPanel";
            this.SongsPanel.Size = new System.Drawing.Size(372, 240);
            this.SongsPanel.TabIndex = 8;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(3, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(106, 16);
            this.lblcategory.TabIndex = 26;
            this.lblcategory.Text = "Category Name:";
            this.lblcategory.Visible = false;
            // 
            // lblalbum
            // 
            this.lblalbum.AutoSize = true;
            this.lblalbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalbum.Location = new System.Drawing.Point(3, 18);
            this.lblalbum.Name = "lblalbum";
            this.lblalbum.Size = new System.Drawing.Size(89, 16);
            this.lblalbum.TabIndex = 24;
            this.lblalbum.Text = "Album Name:";
            this.lblalbum.Visible = false;
            // 
            // btnbackanime2
            // 
            this.btnbackanime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackanime2.Location = new System.Drawing.Point(3, 212);
            this.btnbackanime2.Name = "btnbackanime2";
            this.btnbackanime2.Size = new System.Drawing.Size(36, 23);
            this.btnbackanime2.TabIndex = 23;
            this.btnbackanime2.Text = "←";
            this.btnbackanime2.UseVisualStyleBackColor = true;
            this.btnbackanime2.Visible = false;
            this.btnbackanime2.Click += new System.EventHandler(this.btnbackanime2_Click);
            // 
            // btnbackmusic2
            // 
            this.btnbackmusic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackmusic2.Location = new System.Drawing.Point(3, 212);
            this.btnbackmusic2.Name = "btnbackmusic2";
            this.btnbackmusic2.Size = new System.Drawing.Size(36, 23);
            this.btnbackmusic2.TabIndex = 22;
            this.btnbackmusic2.Text = "←";
            this.btnbackmusic2.UseVisualStyleBackColor = true;
            this.btnbackmusic2.Visible = false;
            this.btnbackmusic2.Click += new System.EventHandler(this.btnbackmusic2_Click);
            // 
            // btnbackanime
            // 
            this.btnbackanime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackanime.Location = new System.Drawing.Point(3, 212);
            this.btnbackanime.Name = "btnbackanime";
            this.btnbackanime.Size = new System.Drawing.Size(36, 23);
            this.btnbackanime.TabIndex = 17;
            this.btnbackanime.Text = "←";
            this.btnbackanime.UseVisualStyleBackColor = true;
            this.btnbackanime.Visible = false;
            this.btnbackanime.Click += new System.EventHandler(this.btnbackanime_Click);
            // 
            // btnbackmusic
            // 
            this.btnbackmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackmusic.Location = new System.Drawing.Point(3, 212);
            this.btnbackmusic.Name = "btnbackmusic";
            this.btnbackmusic.Size = new System.Drawing.Size(36, 23);
            this.btnbackmusic.TabIndex = 16;
            this.btnbackmusic.Text = "←";
            this.btnbackmusic.UseVisualStyleBackColor = true;
            this.btnbackmusic.Visible = false;
            this.btnbackmusic.Click += new System.EventHandler(this.btnbackmusic_Click);
            // 
            // lblanime
            // 
            this.lblanime.AutoSize = true;
            this.lblanime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanime.Location = new System.Drawing.Point(232, 172);
            this.lblanime.Name = "lblanime";
            this.lblanime.Size = new System.Drawing.Size(62, 22);
            this.lblanime.TabIndex = 3;
            this.lblanime.Text = "Anime";
            // 
            // lblmusic
            // 
            this.lblmusic.AutoSize = true;
            this.lblmusic.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmusic.Location = new System.Drawing.Point(77, 172);
            this.lblmusic.Name = "lblmusic";
            this.lblmusic.Size = new System.Drawing.Size(57, 22);
            this.lblmusic.TabIndex = 2;
            this.lblmusic.Text = "Music";
            // 
            // pbmusic
            // 
            this.pbmusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmusic.Location = new System.Drawing.Point(49, 48);
            this.pbmusic.Name = "pbmusic";
            this.pbmusic.Size = new System.Drawing.Size(117, 112);
            this.pbmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmusic.TabIndex = 1;
            this.pbmusic.TabStop = false;
            this.pbmusic.Click += new System.EventHandler(this.pbmusic_Click);
            // 
            // pbanime
            // 
            this.pbanime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbanime.Location = new System.Drawing.Point(207, 48);
            this.pbanime.Name = "pbanime";
            this.pbanime.Size = new System.Drawing.Size(117, 112);
            this.pbanime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanime.TabIndex = 0;
            this.pbanime.TabStop = false;
            this.pbanime.Click += new System.EventHandler(this.pbanime_Click);
            // 
            // dgvmusic
            // 
            this.dgvmusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmusic.Location = new System.Drawing.Point(-1, 110);
            this.dgvmusic.Name = "dgvmusic";
            this.dgvmusic.Size = new System.Drawing.Size(372, 98);
            this.dgvmusic.TabIndex = 4;
            this.dgvmusic.Visible = false;
            this.dgvmusic.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmusic_CellMouseClick);
            this.dgvmusic.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmusic_CellMouseDoubleClick);
            // 
            // dgvanime
            // 
            this.dgvanime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvanime.Location = new System.Drawing.Point(-1, 110);
            this.dgvanime.Name = "dgvanime";
            this.dgvanime.Size = new System.Drawing.Size(372, 98);
            this.dgvanime.TabIndex = 5;
            this.dgvanime.Visible = false;
            this.dgvanime.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvanime_CellMouseClick);
            this.dgvanime.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvanime_CellMouseDoubleClick);
            // 
            // pbmusic1
            // 
            this.pbmusic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmusic1.Location = new System.Drawing.Point(141, 15);
            this.pbmusic1.Name = "pbmusic1";
            this.pbmusic1.Size = new System.Drawing.Size(91, 79);
            this.pbmusic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmusic1.TabIndex = 18;
            this.pbmusic1.TabStop = false;
            this.pbmusic1.Visible = false;
            // 
            // pbanime1
            // 
            this.pbanime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbanime1.Location = new System.Drawing.Point(141, 15);
            this.pbanime1.Name = "pbanime1";
            this.pbanime1.Size = new System.Drawing.Size(91, 79);
            this.pbanime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanime1.TabIndex = 19;
            this.pbanime1.TabStop = false;
            this.pbanime1.Visible = false;
            // 
            // dgvmusicsong
            // 
            this.dgvmusicsong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmusicsong.Location = new System.Drawing.Point(-1, 48);
            this.dgvmusicsong.Name = "dgvmusicsong";
            this.dgvmusicsong.Size = new System.Drawing.Size(372, 160);
            this.dgvmusicsong.TabIndex = 20;
            this.dgvmusicsong.Visible = false;
            // 
            // dgvanimesong
            // 
            this.dgvanimesong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvanimesong.Location = new System.Drawing.Point(-1, 48);
            this.dgvanimesong.Name = "dgvanimesong";
            this.dgvanimesong.Size = new System.Drawing.Size(372, 160);
            this.dgvanimesong.TabIndex = 21;
            this.dgvanimesong.Visible = false;
            // 
            // lblanimealbum
            // 
            this.lblanimealbum.AutoSize = true;
            this.lblanimealbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanimealbum.Location = new System.Drawing.Point(98, 18);
            this.lblanimealbum.Name = "lblanimealbum";
            this.lblanimealbum.Size = new System.Drawing.Size(46, 16);
            this.lblanimealbum.TabIndex = 29;
            this.lblanimealbum.Text = "name";
            this.lblanimealbum.Visible = false;
            // 
            // lblmusicalbum
            // 
            this.lblmusicalbum.AutoSize = true;
            this.lblmusicalbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmusicalbum.Location = new System.Drawing.Point(98, 18);
            this.lblmusicalbum.Name = "lblmusicalbum";
            this.lblmusicalbum.Size = new System.Drawing.Size(46, 16);
            this.lblmusicalbum.TabIndex = 25;
            this.lblmusicalbum.Text = "name";
            this.lblmusicalbum.Visible = false;
            // 
            // lblanimecategory
            // 
            this.lblanimecategory.AutoSize = true;
            this.lblanimecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanimecategory.Location = new System.Drawing.Point(115, 0);
            this.lblanimecategory.Name = "lblanimecategory";
            this.lblanimecategory.Size = new System.Drawing.Size(69, 16);
            this.lblanimecategory.TabIndex = 28;
            this.lblanimecategory.Text = "category";
            this.lblanimecategory.Visible = false;
            // 
            // lblmusiccategory
            // 
            this.lblmusiccategory.AutoSize = true;
            this.lblmusiccategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmusiccategory.Location = new System.Drawing.Point(115, 0);
            this.lblmusiccategory.Name = "lblmusiccategory";
            this.lblmusiccategory.Size = new System.Drawing.Size(69, 16);
            this.lblmusiccategory.TabIndex = 27;
            this.lblmusiccategory.Text = "category";
            this.lblmusiccategory.Visible = false;
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 287);
            this.Controls.Add(this.SongsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Songs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Songs";
            this.Load += new System.EventHandler(this.Songs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            this.SongsPanel.ResumeLayout(false);
            this.SongsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmusicsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanimesong)).EndInit();
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
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SongsPanel;
        private System.Windows.Forms.PictureBox pbmusic;
        private System.Windows.Forms.PictureBox pbanime;
        private System.Windows.Forms.Label lblanime;
        private System.Windows.Forms.Label lblmusic;
        private System.Windows.Forms.DataGridView dgvanime;
        private System.Windows.Forms.DataGridView dgvmusic;
        private System.Windows.Forms.Button btnbackanime;
        private System.Windows.Forms.Button btnbackmusic;
        private System.Windows.Forms.PictureBox pbmusic1;
        private System.Windows.Forms.PictureBox pbanime1;
        private System.Windows.Forms.DataGridView dgvmusicsong;
        private System.Windows.Forms.DataGridView dgvanimesong;
        private System.Windows.Forms.Button btnbackanime2;
        private System.Windows.Forms.Button btnbackmusic2;
        private System.Windows.Forms.Label lblalbum;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblmusiccategory;
        private System.Windows.Forms.Label lblmusicalbum;
        private System.Windows.Forms.Label lblanimealbum;
        private System.Windows.Forms.Label lblanimecategory;
    }
}