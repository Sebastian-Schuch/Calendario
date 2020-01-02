namespace Kalender
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sideNav = new System.Windows.Forms.Panel();
            this.panUnterNav = new System.Windows.Forms.Panel();
            this.panSuche = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panMonat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panWoche = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panTag = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSideMenu1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panHeader.SuspendLayout();
            this.sideNav.SuspendLayout();
            this.panUnterNav.SuspendLayout();
            this.panSuche.SuspendLayout();
            this.panMonat.SuspendLayout();
            this.panWoche.SuspendLayout();
            this.panTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.AutoSize = true;
            this.panHeader.Controls.Add(this.MinimizeBtn);
            this.panHeader.Controls.Add(this.pbExit);
            this.panHeader.Controls.Add(this.pictureBox3);
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1060, 39);
            this.panHeader.TabIndex = 1;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanHeader_MouseDown);
            this.panHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanHeader_MouseMove);
            this.panHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanHeader_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "catchy title";
            // 
            // sideNav
            // 
            this.sideNav.Controls.Add(this.panUnterNav);
            this.sideNav.Controls.Add(this.panSuche);
            this.sideNav.Controls.Add(this.panMonat);
            this.sideNav.Controls.Add(this.panWoche);
            this.sideNav.Controls.Add(this.panTag);
            this.sideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNav.Location = new System.Drawing.Point(0, 39);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(263, 761);
            this.sideNav.TabIndex = 2;
            // 
            // panUnterNav
            // 
            this.panUnterNav.Controls.Add(this.pbSideMenu1);
            this.panUnterNav.Location = new System.Drawing.Point(0, 0);
            this.panUnterNav.Name = "panUnterNav";
            this.panUnterNav.Size = new System.Drawing.Size(263, 41);
            this.panUnterNav.TabIndex = 7;
            // 
            // panSuche
            // 
            this.panSuche.Controls.Add(this.label6);
            this.panSuche.Controls.Add(this.pictureBox7);
            this.panSuche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panSuche.Location = new System.Drawing.Point(0, 305);
            this.panSuche.Name = "panSuche";
            this.panSuche.Size = new System.Drawing.Size(263, 41);
            this.panSuche.TabIndex = 6;
            this.panSuche.Click += new System.EventHandler(this.PanSuche_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Suche";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // panMonat
            // 
            this.panMonat.Controls.Add(this.label5);
            this.panMonat.Controls.Add(this.pictureBox6);
            this.panMonat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panMonat.Location = new System.Drawing.Point(0, 245);
            this.panMonat.Name = "panMonat";
            this.panMonat.Size = new System.Drawing.Size(263, 41);
            this.panMonat.TabIndex = 5;
            this.panMonat.Click += new System.EventHandler(this.PanMonat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monat";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panWoche
            // 
            this.panWoche.Controls.Add(this.label4);
            this.panWoche.Controls.Add(this.pictureBox5);
            this.panWoche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panWoche.Location = new System.Drawing.Point(0, 185);
            this.panWoche.Name = "panWoche";
            this.panWoche.Size = new System.Drawing.Size(263, 41);
            this.panWoche.TabIndex = 4;
            this.panWoche.Click += new System.EventHandler(this.PanWoche_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Woche";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panTag
            // 
            this.panTag.Controls.Add(this.label3);
            this.panTag.Controls.Add(this.pictureBox4);
            this.panTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panTag.Location = new System.Drawing.Point(0, 125);
            this.panTag.Name = "panTag";
            this.panTag.Size = new System.Drawing.Size(263, 41);
            this.panTag.TabIndex = 3;
            this.panTag.Click += new System.EventHandler(this.panTag_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tag";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pbSideMenu1
            // 
            this.pbSideMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSideMenu1.Image = global::Kalender.Properties.Resources.menu;
            this.pbSideMenu1.Location = new System.Drawing.Point(225, 6);
            this.pbSideMenu1.MaximumSize = new System.Drawing.Size(32, 32);
            this.pbSideMenu1.MinimumSize = new System.Drawing.Size(15, 15);
            this.pbSideMenu1.Name = "pbSideMenu1";
            this.pbSideMenu1.Size = new System.Drawing.Size(26, 26);
            this.pbSideMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSideMenu1.TabIndex = 0;
            this.pbSideMenu1.TabStop = false;
            this.pbSideMenu1.Click += new System.EventHandler(this.pbSideMenu1_Click_1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Kalender.Properties.Resources.search;
            this.pictureBox7.Location = new System.Drawing.Point(14, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Kalender.Properties.Resources.Monatsuebersicht;
            this.pictureBox6.Location = new System.Drawing.Point(11, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Kalender.Properties.Resources.Wochenuebersicht;
            this.pictureBox5.Location = new System.Drawing.Point(11, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Kalender.Properties.Resources.Tagesübersicht;
            this.pictureBox4.Location = new System.Drawing.Point(11, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::Kalender.Properties.Resources.minimize;
            this.MinimizeBtn.Location = new System.Drawing.Point(990, 1);
            this.MinimizeBtn.MinimumSize = new System.Drawing.Size(10, 10);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(7);
            this.MinimizeBtn.Size = new System.Drawing.Size(35, 35);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBtn.TabIndex = 6;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            this.MinimizeBtn.MouseEnter += new System.EventHandler(this.MinimizeBtn_MouseEnter);
            this.MinimizeBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::Kalender.Properties.Resources.close;
            this.pbExit.Location = new System.Drawing.Point(1022, 1);
            this.pbExit.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbExit.Name = "pbExit";
            this.pbExit.Padding = new System.Windows.Forms.Padding(7);
            this.pbExit.Size = new System.Drawing.Size(35, 35);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.PbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.PbExit_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kalender.Properties.Resources.icon__1_;
            this.pictureBox3.Location = new System.Drawing.Point(12, 8);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(36, 36);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(15, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1060, 800);
            this.ControlBox = false;
            this.Controls.Add(this.sideNav);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.sideNav.ResumeLayout(false);
            this.panUnterNav.ResumeLayout(false);
            this.panSuche.ResumeLayout(false);
            this.panSuche.PerformLayout();
            this.panMonat.ResumeLayout(false);
            this.panMonat.PerformLayout();
            this.panWoche.ResumeLayout(false);
            this.panWoche.PerformLayout();
            this.panTag.ResumeLayout(false);
            this.panTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.PictureBox pbSideMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel sideNav;
        private System.Windows.Forms.Panel panSuche;
        private System.Windows.Forms.Panel panMonat;
        private System.Windows.Forms.Panel panWoche;
        private System.Windows.Forms.Panel panTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panUnterNav;
        private System.Windows.Forms.PictureBox MinimizeBtn;
    }
}

