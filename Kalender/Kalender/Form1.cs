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
using System.Xml.Serialization;
using System.IO;

namespace Kalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private XmlSerializer serializer;

        private void Form1_Load(object sender, EventArgs e)
        {
            basicDesigns();
            combineForms();
            serializer = new XmlSerializer(arrTermine.GetType());
            try
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\Termine.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                arrTermine = (List<Termin>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmain.SuchListViewRefresh("");

        }
        internal List<Termin> arrTermine = new List<Termin>();
        //ColorScheme
        internal Color bunt1 = Color.FromArgb(95, 174, 87);
        internal Color grauDunkel1 = ColorTranslator.FromHtml("#313131");
        internal Color grauDunkel2 = ColorTranslator.FromHtml("#252525");
        internal Color grauHell1 = ColorTranslator.FromHtml("#525252");
        internal Color grauMittel = ColorTranslator.FromHtml("#414141");
        internal Color Hauptfarbe1 = ColorTranslator.FromHtml("#ca3e47");
        internal Color HeaderGrau = ColorTranslator.FromHtml("#202225");




        private void basicDesigns()
        {
            sideNav.Visible = true;
            this.BackColor = grauMittel;
            panHeader.BackColor = HeaderGrau;
            sideNav.BackColor = grauDunkel1;
            panUnterNav.BackColor = grauDunkel2;
            minimizeNav();

        }

        private main frmain;
        private Panel panMain1 = new Panel();
        private void combineForms()
        {

            this.Controls.Add(panMain1);
            panMain1.Size = new Size(1006, 764);
            panMain1.Location = new Point(54, 36);

            frmain = new main() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmain.frm = this;
            sideNav.BringToFront();
            panMain1.Controls.Add(frmain);
            frmain.Show();


        }



        private void pbExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void PbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.close;
        }

        private void PbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.close_hover;
        }



        //Dragable Header
        private bool mouseDown = false;
        private Point lastLocation;

        private void PanHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PanHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PanHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //Minimize Button

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBtn.Image = Properties.Resources.minimize_hover;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtn.Image = Properties.Resources.minimize;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SideNav verlinken

        private void tabVeraendern(string tabname)
        {

        }

        private void panTermin_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("uebersicht");
            minimizeNav();
        }

        private void panTag_Click(object sender, EventArgs e)
        {

            frmain.ChangeTab("tag");
            minimizeNav();

        }

        private void PanWoche_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("woche");
            minimizeNav();
        }

        private void PanMonat_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("monat");
            minimizeNav();
        }

        private void PanSuche_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("suche");
            minimizeNav();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (Termin t in arrTermine)
            {
                MessageBox.Show(t.Monat.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmain.SuchListViewRefresh("");
        }
    }

}
