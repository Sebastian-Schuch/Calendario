namespace Kalender
{
    partial class TerminHinzufuegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminHinzufuegen));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGanz = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblGanz = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBis = new System.Windows.Forms.TextBox();
            this.lblNotizen = new System.Windows.Forms.Label();
            this.txtNotizen = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TTalarm = new System.Windows.Forms.ToolTip(this.components);
            this.pbAlarm2 = new System.Windows.Forms.PictureBox();
            this.pbAlarm1 = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Controls.Add(this.MinimizeBtn);
            this.PnlHeader.Controls.Add(this.pbExit);
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(278, 30);
            this.PnlHeader.TabIndex = 0;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Termin hinzufügen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termin Titel";
            // 
            // txtTitel
            // 
            this.txtTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTitel.ForeColor = System.Drawing.Color.White;
            this.txtTitel.Location = new System.Drawing.Point(15, 72);
            this.txtTitel.MaxLength = 30;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(251, 18);
            this.txtTitel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 3;
            // 
            // chkGanz
            // 
            this.chkGanz.AutoSize = true;
            this.chkGanz.Depth = 0;
            this.chkGanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkGanz.ForeColor = System.Drawing.Color.White;
            this.chkGanz.Location = new System.Drawing.Point(237, 121);
            this.chkGanz.Margin = new System.Windows.Forms.Padding(0);
            this.chkGanz.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkGanz.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkGanz.Name = "chkGanz";
            this.chkGanz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkGanz.Ripple = true;
            this.chkGanz.Size = new System.Drawing.Size(26, 30);
            this.chkGanz.TabIndex = 5;
            this.chkGanz.UseVisualStyleBackColor = true;
            this.chkGanz.CheckedChanged += new System.EventHandler(this.ChkGanz_CheckedChanged);
            // 
            // lblGanz
            // 
            this.lblGanz.AutoSize = true;
            this.lblGanz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanz.ForeColor = System.Drawing.Color.White;
            this.lblGanz.Location = new System.Drawing.Point(12, 126);
            this.lblGanz.Name = "lblGanz";
            this.lblGanz.Size = new System.Drawing.Size(70, 17);
            this.lblGanz.TabIndex = 6;
            this.lblGanz.Text = "Ganztägig";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.ForeColor = System.Drawing.Color.White;
            this.lblVon.Location = new System.Drawing.Point(12, 171);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(32, 17);
            this.lblVon.TabIndex = 7;
            this.lblVon.Text = "Von";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBis.ForeColor = System.Drawing.Color.White;
            this.lblBis.Location = new System.Drawing.Point(12, 212);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(26, 17);
            this.lblBis.TabIndex = 8;
            this.lblBis.Text = "Bis";
            this.lblBis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(179, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 2);
            this.panel2.TabIndex = 10;
            // 
            // txtVon
            // 
            this.txtVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtVon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtVon.ForeColor = System.Drawing.Color.White;
            this.txtVon.Location = new System.Drawing.Point(179, 170);
            this.txtVon.MaxLength = 5;
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(84, 18);
            this.txtVon.TabIndex = 2;
            this.txtVon.Leave += new System.EventHandler(this.TxtVon_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(179, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 2);
            this.panel3.TabIndex = 12;
            // 
            // txtBis
            // 
            this.txtBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtBis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBis.ForeColor = System.Drawing.Color.White;
            this.txtBis.Location = new System.Drawing.Point(179, 211);
            this.txtBis.MaxLength = 5;
            this.txtBis.Name = "txtBis";
            this.txtBis.Size = new System.Drawing.Size(84, 18);
            this.txtBis.TabIndex = 3;
            this.txtBis.Leave += new System.EventHandler(this.TxtBis_Leave);
            // 
            // lblNotizen
            // 
            this.lblNotizen.AutoSize = true;
            this.lblNotizen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotizen.ForeColor = System.Drawing.Color.White;
            this.lblNotizen.Location = new System.Drawing.Point(12, 256);
            this.lblNotizen.Name = "lblNotizen";
            this.lblNotizen.Size = new System.Drawing.Size(56, 17);
            this.lblNotizen.TabIndex = 13;
            this.lblNotizen.Text = "Notizen";
            // 
            // txtNotizen
            // 
            this.txtNotizen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtNotizen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotizen.ForeColor = System.Drawing.Color.White;
            this.txtNotizen.Location = new System.Drawing.Point(15, 290);
            this.txtNotizen.MaxLength = 256;
            this.txtNotizen.Multiline = true;
            this.txtNotizen.Name = "txtNotizen";
            this.txtNotizen.Size = new System.Drawing.Size(245, 118);
            this.txtNotizen.TabIndex = 4;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(15, 427);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(245, 40);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Hinzufügen";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // TTalarm
            // 
            this.TTalarm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // pbAlarm2
            // 
            this.pbAlarm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAlarm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlarm2.Image = ((System.Drawing.Image)(resources.GetObject("pbAlarm2.Image")));
            this.pbAlarm2.Location = new System.Drawing.Point(153, 214);
            this.pbAlarm2.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbAlarm2.Name = "pbAlarm2";
            this.pbAlarm2.Padding = new System.Windows.Forms.Padding(2);
            this.pbAlarm2.Size = new System.Drawing.Size(20, 20);
            this.pbAlarm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarm2.TabIndex = 16;
            this.pbAlarm2.TabStop = false;
            this.TTalarm.SetToolTip(this.pbAlarm2, "Bitte verwenden Sie das Format hh:mm (bsp: 02:14)");
            this.pbAlarm2.Visible = false;
            // 
            // pbAlarm1
            // 
            this.pbAlarm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAlarm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlarm1.Image = global::Kalender.Properties.Resources.alarm;
            this.pbAlarm1.Location = new System.Drawing.Point(153, 171);
            this.pbAlarm1.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbAlarm1.Name = "pbAlarm1";
            this.pbAlarm1.Padding = new System.Windows.Forms.Padding(2);
            this.pbAlarm1.Size = new System.Drawing.Size(20, 20);
            this.pbAlarm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarm1.TabIndex = 10;
            this.pbAlarm1.TabStop = false;
            this.TTalarm.SetToolTip(this.pbAlarm1, "Bitte verwenden Sie das Format hh:mm (bsp: 02:14)");
            this.pbAlarm1.Visible = false;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::Kalender.Properties.Resources.minimize;
            this.MinimizeBtn.Location = new System.Drawing.Point(218, 3);
            this.MinimizeBtn.MinimumSize = new System.Drawing.Size(10, 10);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(7);
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBtn.TabIndex = 8;
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
            this.pbExit.Location = new System.Drawing.Point(250, 3);
            this.pbExit.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbExit.Name = "pbExit";
            this.pbExit.Padding = new System.Windows.Forms.Padding(7);
            this.pbExit.Size = new System.Drawing.Size(25, 25);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.PbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.PbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.PbExit_MouseLeave);
            // 
            // TerminHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(278, 479);
            this.Controls.Add(this.pbAlarm2);
            this.Controls.Add(this.pbAlarm1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtNotizen);
            this.Controls.Add(this.lblNotizen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtVon);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblGanz);
            this.Controls.Add(this.chkGanz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TerminHinzufuegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TerminHinzufuegen";
            this.Load += new System.EventHandler(this.TerminHinzufuegen_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox chkGanz;
        private System.Windows.Forms.Label lblGanz;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBis;
        private System.Windows.Forms.Label lblNotizen;
        private System.Windows.Forms.TextBox txtNotizen;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pbAlarm1;
        private System.Windows.Forms.PictureBox pbAlarm2;
        private System.Windows.Forms.ToolTip TTalarm;
    }
}