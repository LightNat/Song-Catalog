
namespace SoCat.Interface
{
    partial class Settings
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
            this.btnsongs = new System.Windows.Forms.Button();
            this.btnalbums = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.lblfullname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnsongs);
            this.panel1.Controls.Add(this.btnalbums);
            this.panel1.Controls.Add(this.btnsettings);
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
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
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
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label label1;
    }
}