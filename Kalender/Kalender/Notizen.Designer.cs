namespace Kalender
{
    partial class Notizen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notizen));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblTermin = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lblNotizen = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.PnlHeader.Controls.Add(this.lblTermin);
            this.PnlHeader.Controls.Add(this.MinimizeBtn);
            this.PnlHeader.Controls.Add(this.pbExit);
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(369, 30);
            this.PnlHeader.TabIndex = 1;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseUp);
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermin.ForeColor = System.Drawing.Color.White;
            this.lblTermin.Location = new System.Drawing.Point(12, 9);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(49, 13);
            this.lblTermin.TabIndex = 9;
            this.lblTermin.Text = "Notizen";
            this.lblTermin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTermin_MouseDown);
            this.lblTermin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblTermin_MouseMove);
            this.lblTermin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblTermin_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::Kalender.Properties.Resources.minimize;
            this.MinimizeBtn.Location = new System.Drawing.Point(307, 3);
            this.MinimizeBtn.MinimumSize = new System.Drawing.Size(10, 10);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(7);
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBtn.TabIndex = 8;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::Kalender.Properties.Resources.close;
            this.pbExit.Location = new System.Drawing.Point(339, 3);
            this.pbExit.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbExit.Name = "pbExit";
            this.pbExit.Padding = new System.Windows.Forms.Padding(7);
            this.pbExit.Size = new System.Drawing.Size(25, 25);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // lblNotizen
            // 
            this.lblNotizen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotizen.ForeColor = System.Drawing.Color.White;
            this.lblNotizen.Location = new System.Drawing.Point(13, 37);
            this.lblNotizen.Name = "lblNotizen";
            this.lblNotizen.Size = new System.Drawing.Size(342, 330);
            this.lblNotizen.TabIndex = 2;
            this.lblNotizen.Text = "Keine Notizen vorhanden";
            // 
            // Notizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(367, 376);
            this.Controls.Add(this.lblNotizen);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notizen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notizen";
            this.Load += new System.EventHandler(this.Notizen_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lblNotizen;
    }
}