using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Grey800,
                Primary.Grey200,
                Accent.LightBlue200,
                TextShade.WHITE
            );*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basicDesigns();
        }

        //ColorScheme
        private Color bunt1 = Color.FromArgb(95, 174, 87);
        private Color grauDunkel1 = ColorTranslator.FromHtml("#313131");
        private Color grauDunkel2 = ColorTranslator.FromHtml("#252525");
        private Color grauHell1 = ColorTranslator.FromHtml("#525252");
        private Color grauMittel = ColorTranslator.FromHtml("#414141");
        private Color Hauptfarbe1 = ColorTranslator.FromHtml("#ca3e47");


        private void basicDesigns()
        {
            sideNav.Visible = true;
            this.BackColor = grauMittel;
            panHeader.BackColor = bunt1;
            sideNav.BackColor = grauDunkel1;
            panUnterNav.BackColor = grauDunkel2;
            minimizeNav();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pbSideMenu1_Click(object sender, EventArgs e)
        {



            //sideNav.Visible = false;
        }

        private void pbSideMenu1_Click_1(object sender, EventArgs e)
        {
            if (pbSideMenu1.Location.Equals(new Point(12, 6)))
            {
                maximizeNav();
            }
            else
            {
                minimizeNav();
            }
        }

        private void minimizeNav()
        {
            sideNav.Size = new Size(54, 758);
            pbSideMenu1.Location = new Point(12, 6);
        }

        private void maximizeNav()
        {
            sideNav.Size = new Size(263, 758);
            pbSideMenu1.Location = new Point(225, 6);
        }
    }
}
