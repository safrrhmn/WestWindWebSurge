﻿namespace WebSurge
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.StartupTimer = new System.Windows.Forms.Timer(this.components);
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.lblRegisterType = new System.Windows.Forms.LinkLabel();
            this.lblVersionText = new System.Windows.Forms.Label();
            this.lblYouAreUsing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblClickClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // StartupTimer
            // 
            this.StartupTimer.Interval = 4000;
            this.StartupTimer.Tick += new System.EventHandler(this.StartupTimer_Tick);
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackColor = System.Drawing.Color.Black;
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(-13, -21);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(371, 322);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            this.PictureLogo.Click += new System.EventHandler(this.PictureLogo_Click);
            // 
            // lblRegisterType
            // 
            this.lblRegisterType.BackColor = System.Drawing.Color.Black;
            this.lblRegisterType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRegisterType.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterType.Location = new System.Drawing.Point(253, 20);
            this.lblRegisterType.Name = "lblRegisterType";
            this.lblRegisterType.Size = new System.Drawing.Size(81, 16);
            this.lblRegisterType.TabIndex = 5;
            this.lblRegisterType.TabStop = true;
            this.lblRegisterType.Text = "Professional";
            this.lblRegisterType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRegisterType.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegisterType_LinkClicked);
            // 
            // lblVersionText
            // 
            this.lblVersionText.BackColor = System.Drawing.Color.Black;
            this.lblVersionText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersionText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVersionText.Location = new System.Drawing.Point(217, 36);
            this.lblVersionText.Name = "lblVersionText";
            this.lblVersionText.Size = new System.Drawing.Size(118, 20);
            this.lblVersionText.TabIndex = 4;
            this.lblVersionText.Text = "Version 0.10";
            this.lblVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYouAreUsing
            // 
            this.lblYouAreUsing.AutoSize = true;
            this.lblYouAreUsing.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblYouAreUsing.ForeColor = System.Drawing.SystemColors.Info;
            this.lblYouAreUsing.Location = new System.Drawing.Point(17, 317);
            this.lblYouAreUsing.Name = "lblYouAreUsing";
            this.lblYouAreUsing.Size = new System.Drawing.Size(270, 21);
            this.lblYouAreUsing.TabIndex = 6;
            this.lblYouAreUsing.Text = "You\'ve been using the Free version of";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Westwind WebSurge";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(17, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 62);
            this.label2.TabIndex = 8;
            this.label2.Text = "If you\'re using this tool commercially or you find that you\'re using it frequentl" +
    "y, please purchase a registered version of WebSurge.";
            // 
            // lnkRegister
            // 
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lnkRegister.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkRegister.Location = new System.Drawing.Point(24, 442);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(302, 51);
            this.lnkRegister.TabIndex = 9;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            this.lnkRegister.Click += new System.EventHandler(this.lnkRegister_Click);
            // 
            // lblClickClose
            // 
            this.lblClickClose.AutoSize = true;
            this.lblClickClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClickClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClickClose.Location = new System.Drawing.Point(330, 2);
            this.lblClickClose.Name = "lblClickClose";
            this.lblClickClose.Size = new System.Drawing.Size(13, 14);
            this.lblClickClose.TabIndex = 18;
            this.lblClickClose.Text = "x";
            this.lblClickClose.Click += new System.EventHandler(this.lblClickClose_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(345, 300);
            this.Controls.Add(this.lblClickClose);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYouAreUsing);
            this.Controls.Add(this.lblRegisterType);
            this.Controls.Add(this.lblVersionText);
            this.Controls.Add(this.PictureLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About West Wind Web Surge";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Splash_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer StartupTimer;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.LinkLabel lblRegisterType;
        private System.Windows.Forms.Label lblVersionText;
        private System.Windows.Forms.Label lblYouAreUsing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblClickClose;
    }
}