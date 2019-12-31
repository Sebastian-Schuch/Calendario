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
    public partial class TerminHinzufuegen : Form
    {
        public TerminHinzufuegen(int jahr, int monat, int tag)
        {
            InitializeComponent();
            this.jahr = jahr;
            this.monat = monat;
            this.tag = tag;
        }
        
        internal Form1 f1;
        internal Color grauMittel = ColorTranslator.FromHtml("#414141");
        internal Color Hauptfarbe1 = ColorTranslator.FromHtml("#ca3e47");
        internal Color HeaderGrau = ColorTranslator.FromHtml("#202225");
        internal Color grauDunkel2 = ColorTranslator.FromHtml("#252525");
        internal Color grauDunkel1 = ColorTranslator.FromHtml("#313131");

        bool rightDateVon = false;
        bool rightDateBis = false;
        bool GanzTag = false;
        int VonZahlinMin = 0;
        int BisZahlMin = 0;

        int jahr = 2019;
        int monat = 12;
        int tag = 30;
        private XmlSerializer serializer;

        private void TerminHinzufuegen_Load(object sender, EventArgs e)
        {
            this.BackColor = grauDunkel1;
            PnlHeader.BackColor = HeaderGrau;
            serializer = new XmlSerializer(f1.arrTermine.GetType());
        }

        //Dragable machen
        private bool mouseDown = false;
        private Point lastLocation;

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBtn.Image = Properties.Resources.minimize_hover;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtn.Image = Properties.Resources.minimize;
        }

        private void PbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.close_hover;
        }

        private void PbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.close;
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtVon_Leave(object sender, EventArgs e)
        {
            string txtVonString = txtVon.Text;
            
            if (txtVonString.Length == 5 && txtVonString[2].ToString().Equals(":"))
            {
                txtVon.ForeColor = Color.White;
                panel2.BackColor = Color.White;
                rightDateVon = true;
                pbAlarm1.Visible = false;
                VonZahlinMin = (Convert.ToInt32(txtVon.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtVon.Text.Substring(3, 2).ToString()));

                return;
            }
            try
            {
                if(Convert.ToInt32(txtVonString)>=0 && Convert.ToInt32(txtVonString) <= 24)
                {
                    if(Convert.ToInt32(txtVonString)>=0&& Convert.ToInt32(txtVonString) <= 9)
                    {
                        txtVon.Text = "0" + Convert.ToInt32(txtVonString).ToString() + ":00";
                    } else { 
                    txtVon.Text = txtVonString + ":00";
                    }
                    txtVon.ForeColor = Color.White;
                    panel2.BackColor = Color.White;
                    rightDateVon = true;
                    pbAlarm1.Visible = false;
                    VonZahlinMin = Convert.ToInt32(txtVonString) * 60;
                    return;
                }
                
            }
            catch { }
            txtVon.ForeColor = ColorTranslator.FromHtml("#ff867c");
            panel2.BackColor = ColorTranslator.FromHtml("#ff867c");
            rightDateVon = false;
            pbAlarm1.Visible = true;

        }

        private void TxtBis_Leave(object sender, EventArgs e)
        {
            string txtVonString = txtBis.Text;

            if (txtVonString.Length == 5 && txtVonString[2].ToString().Equals(":"))
            {
                txtBis.ForeColor = Color.White;
                panel3.BackColor = Color.White;
                rightDateBis = true;
                pbAlarm2.Visible = false;
                BisZahlMin = (Convert.ToInt32(txtBis.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtBis.Text.Substring(3, 2).ToString()));
                if (VonZahlinMin > BisZahlMin)
                {
                    txtBis.ForeColor = ColorTranslator.FromHtml("#ff867c");
                    panel3.BackColor = ColorTranslator.FromHtml("#ff867c");
                    rightDateBis = false;
                    pbAlarm2.Visible = true;
                }
                return;
            }
            try
            {
                if (Convert.ToInt32(txtVonString) >= 0 && Convert.ToInt32(txtVonString) <= 24)
                {
                    if (Convert.ToInt32(txtVonString) >= 0 && Convert.ToInt32(txtVonString) <= 9)
                    {
                        txtBis.Text = "0" + Convert.ToInt32(txtVonString).ToString() + ":00";
                    }
                    else
                    {
                        txtBis.Text = txtVonString + ":00";
                    }
                    
                    txtBis.ForeColor = Color.White;
                    panel3.BackColor = Color.White;
                    rightDateBis = true;
                    pbAlarm2.Visible = false;
                    BisZahlMin = Convert.ToInt32(txtVonString) * 60;
                    if (VonZahlinMin > BisZahlMin)
                    {
                        txtBis.ForeColor = ColorTranslator.FromHtml("#ff867c");
                        panel3.BackColor = ColorTranslator.FromHtml("#ff867c");
                        rightDateBis = false;
                        pbAlarm2.Visible = true;
                    }
                    return;
                }

            }
            catch { }
            txtBis.ForeColor = ColorTranslator.FromHtml("#ff867c");
            panel3.BackColor = ColorTranslator.FromHtml("#ff867c");
            rightDateBis = false;
            pbAlarm2.Visible = true;
        }

        private void ChkGanz_CheckedChanged(object sender, EventArgs e)
        {
            if(chkGanz.Checked == true) { 
                panel2.BackColor = ColorTranslator.FromHtml("#bfbfbf");
                panel3.BackColor = ColorTranslator.FromHtml("#bfbfbf");
                txtVon.Enabled = false;
                txtBis.Enabled = false;
                txtVon.Text = "";
                txtBis.Text = "";
                lblVon.ForeColor = ColorTranslator.FromHtml("#bfbfbf");
                lblBis.ForeColor = ColorTranslator.FromHtml("#bfbfbf");
                pbAlarm1.Visible = false;
                pbAlarm2.Visible = false;
                GanzTag = true;
            }
            if (chkGanz.Checked == false)
            {
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
                txtVon.Enabled = true;
                txtBis.Enabled = true;
                lblVon.ForeColor = Color.White;
                lblBis.ForeColor = Color.White;
                GanzTag = false;
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            if (!txtTitel.Equals("") || !txtTitel.Equals(" "))
            {
                if(rightDateVon == true && rightDateBis == true && GanzTag == false)
                {
                    int vonInMin = (Convert.ToInt32(txtVon.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtVon.Text.Substring(3, 2).ToString()));
                    int bisInMin = (Convert.ToInt32(txtBis.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtBis.Text.Substring(3, 2).ToString()));
                    f1.arrTermine.Add(new Termin(txtTitel.Text, txtNotizen.Text, jahr, monat, tag, false, vonInMin, bisInMin));
                    try
                    {
                        FileStream fs = new FileStream(Application.StartupPath + "\\Termine.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                        serializer.Serialize(fs, f1.arrTermine);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Close();
                } else if (GanzTag == true)
                {
                    f1.arrTermine.Add(new Termin(txtTitel.Text, txtNotizen.Text, jahr, monat, tag, true, 0, 0));
                    try
                    {
                        FileStream fs = new FileStream(Application.StartupPath + "\\Termine.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                        serializer.Serialize(fs, f1.arrTermine);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
                
            }
        }
    }
}
