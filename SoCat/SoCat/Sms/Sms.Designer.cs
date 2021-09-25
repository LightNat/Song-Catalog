
namespace SoCat.Sms
{
    partial class Sms
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
            this.btnlocker = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnback = new System.Windows.Forms.Button();
            this.txtacctsid = new System.Windows.Forms.TextBox();
            this.txtauthtoken = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btnlocker2 = new System.Windows.Forms.Button();
            this.btnlocker3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            this.lblcheck2 = new System.Windows.Forms.Label();
            this.lblcheck3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlocker
            // 
            this.btnlocker.Location = new System.Drawing.Point(233, 42);
            this.btnlocker.Name = "btnlocker";
            this.btnlocker.Size = new System.Drawing.Size(20, 20);
            this.btnlocker.TabIndex = 0;
            this.btnlocker.UseVisualStyleBackColor = true;
            this.btnlocker.Click += new System.EventHandler(this.btnlocker_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(205, 133);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 120);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(36, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "←";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtacctsid
            // 
            this.txtacctsid.Enabled = false;
            this.txtacctsid.Location = new System.Drawing.Point(127, 42);
            this.txtacctsid.Name = "txtacctsid";
            this.txtacctsid.Size = new System.Drawing.Size(100, 20);
            this.txtacctsid.TabIndex = 4;
            // 
            // txtauthtoken
            // 
            this.txtauthtoken.Enabled = false;
            this.txtauthtoken.Location = new System.Drawing.Point(127, 68);
            this.txtauthtoken.Name = "txtauthtoken";
            this.txtauthtoken.Size = new System.Drawing.Size(100, 20);
            this.txtauthtoken.TabIndex = 5;
            // 
            // txtnumber
            // 
            this.txtnumber.Enabled = false;
            this.txtnumber.Location = new System.Drawing.Point(127, 94);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 6;
            // 
            // btnlocker2
            // 
            this.btnlocker2.Location = new System.Drawing.Point(233, 68);
            this.btnlocker2.Name = "btnlocker2";
            this.btnlocker2.Size = new System.Drawing.Size(20, 20);
            this.btnlocker2.TabIndex = 7;
            this.btnlocker2.UseVisualStyleBackColor = true;
            this.btnlocker2.Click += new System.EventHandler(this.btnlocker2_Click);
            // 
            // btnlocker3
            // 
            this.btnlocker3.Location = new System.Drawing.Point(233, 94);
            this.btnlocker3.Name = "btnlocker3";
            this.btnlocker3.Size = new System.Drawing.Size(20, 20);
            this.btnlocker3.TabIndex = 9;
            this.btnlocker3.UseVisualStyleBackColor = true;
            this.btnlocker3.Click += new System.EventHandler(this.btnlocker3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "AccID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "AuthToken :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone # :";
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck.ForeColor = System.Drawing.Color.Green;
            this.lblcheck.Location = new System.Drawing.Point(259, 44);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(20, 16);
            this.lblcheck.TabIndex = 15;
            this.lblcheck.Text = "✔";
            this.lblcheck.Visible = false;
            // 
            // lblcheck2
            // 
            this.lblcheck2.AutoSize = true;
            this.lblcheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck2.ForeColor = System.Drawing.Color.Green;
            this.lblcheck2.Location = new System.Drawing.Point(259, 70);
            this.lblcheck2.Name = "lblcheck2";
            this.lblcheck2.Size = new System.Drawing.Size(20, 16);
            this.lblcheck2.TabIndex = 16;
            this.lblcheck2.Text = "✔";
            this.lblcheck2.Visible = false;
            // 
            // lblcheck3
            // 
            this.lblcheck3.AutoSize = true;
            this.lblcheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck3.ForeColor = System.Drawing.Color.Green;
            this.lblcheck3.Location = new System.Drawing.Point(259, 96);
            this.lblcheck3.Name = "lblcheck3";
            this.lblcheck3.Size = new System.Drawing.Size(20, 16);
            this.lblcheck3.TabIndex = 17;
            this.lblcheck3.Text = "✔";
            this.lblcheck3.Visible = false;
            // 
            // Sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 155);
            this.Controls.Add(this.lblcheck3);
            this.Controls.Add(this.lblcheck2);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlocker3);
            this.Controls.Add(this.btnlocker2);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtauthtoken);
            this.Controls.Add(this.txtacctsid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnlocker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms";
            this.Load += new System.EventHandler(this.Sms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlocker;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtacctsid;
        private System.Windows.Forms.TextBox txtauthtoken;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btnlocker2;
        private System.Windows.Forms.Button btnlocker3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Label lblcheck2;
        private System.Windows.Forms.Label lblcheck3;
    }
}