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
    public partial class Notizen : Form
    {
        public Notizen(string notizen, string termin)
        {
            InitializeComponent();
            this.notizen = notizen;
            this.termin = termin;
        }
        string notizen, termin;
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown = false;
        private Point lastLocation;

        private void Notizen_Load(object sender, EventArgs e)
        {
            lblTermin.Text = "Notizen für " + termin;
            if(!notizen.Equals(""))
            lblNotizen.Text = notizen;
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LblTermin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LblTermin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LblTermin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
