namespace Kalender
{
    partial class main
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
            this.tabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabTerminuebersicht = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabTag = new System.Windows.Forms.TabPage();
            this.tabWoche = new System.Windows.Forms.TabPage();
            this.tabMonat = new System.Windows.Forms.TabPage();
            this.tabSuche = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabTerminuebersicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabTerminuebersicht);
            this.tabControlMain.Controls.Add(this.tabTag);
            this.tabControlMain.Controls.Add(this.tabWoche);
            this.tabControlMain.Controls.Add(this.tabMonat);
            this.tabControlMain.Controls.Add(this.tabSuche);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1004, 764);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabTerminuebersicht
            // 
            this.tabTerminuebersicht.Controls.Add(this.button1);
            this.tabTerminuebersicht.Location = new System.Drawing.Point(4, 22);
            this.tabTerminuebersicht.Name = "tabTerminuebersicht";
            this.tabTerminuebersicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerminuebersicht.Size = new System.Drawing.Size(996, 738);
            this.tabTerminuebersicht.TabIndex = 0;
            this.tabTerminuebersicht.Text = "Terminübersicht";
            this.tabTerminuebersicht.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 161);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabTag
            // 
            this.tabTag.Location = new System.Drawing.Point(4, 22);
            this.tabTag.Name = "tabTag";
            this.tabTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabTag.Size = new System.Drawing.Size(996, 738);
            this.tabTag.TabIndex = 1;
            this.tabTag.Text = "Tag";
            this.tabTag.UseVisualStyleBackColor = true;
            // 
            // tabWoche
            // 
            this.tabWoche.Location = new System.Drawing.Point(4, 22);
            this.tabWoche.Name = "tabWoche";
            this.tabWoche.Size = new System.Drawing.Size(996, 738);
            this.tabWoche.TabIndex = 2;
            this.tabWoche.Text = "Woche";
            this.tabWoche.UseVisualStyleBackColor = true;
            // 
            // tabMonat
            // 
            this.tabMonat.Location = new System.Drawing.Point(4, 22);
            this.tabMonat.Name = "tabMonat";
            this.tabMonat.Size = new System.Drawing.Size(996, 738);
            this.tabMonat.TabIndex = 3;
            this.tabMonat.Text = "Monat";
            this.tabMonat.UseVisualStyleBackColor = true;
            // 
            // tabSuche
            // 
            this.tabSuche.Location = new System.Drawing.Point(4, 22);
            this.tabSuche.Name = "tabSuche";
            this.tabSuche.Size = new System.Drawing.Size(996, 738);
            this.tabSuche.TabIndex = 4;
            this.tabSuche.Text = "Suche";
            this.tabSuche.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 761);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabTerminuebersicht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        internal MaterialSkin.Controls.MaterialTabControl tabControlMain;
        internal System.Windows.Forms.TabPage tabTerminuebersicht;
        internal System.Windows.Forms.TabPage tabTag;
        internal System.Windows.Forms.TabPage tabWoche;
        internal System.Windows.Forms.TabPage tabMonat;
        internal System.Windows.Forms.TabPage tabSuche;
    }
}