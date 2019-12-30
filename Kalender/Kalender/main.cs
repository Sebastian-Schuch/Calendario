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
    public partial class main : Form
    {
        private Form1 frm = new Form1();
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            design();
            datumAufButtons();
            farblichHinterlegen("lbl" + selectedMonat.ToString());
        }




        internal void ChangeTab(string tab)
        {

            if (tab.Equals("uebersicht"))
            {
                tabControlMain.SelectedTab = tabTerminuebersicht;
            }
            else if (tab.Equals("tag"))
            {
                tabControlMain.SelectedTab = tabTag;
            }
            else if (tab.Equals("woche"))
            {
                tabControlMain.SelectedTab = tabWoche;
            }
            else if (tab.Equals("monat"))
            {
                tabControlMain.SelectedTab = tabMonat;
            }
            else if (tab.Equals("suche"))
            {
                tabControlMain.SelectedTab = tabSuche;
            }
            this.Update();

        }
        private void design()
        {
            TabControl.TabPageCollection pages = tabControlMain.TabPages;
            foreach (TabPage page in pages)
            {
                page.BackColor = frm.grauMittel;
            }

            panMonatswahl.BackColor = frm.grauDunkel1;

        }

        private int jahr, monat, tag, selectedTag, tageAnzahlMonat;

        private void farblichHinterlegen(string lblName)
        {

            for (int i = 1; i <= 12; i++)
            {
                Label lbl1 = this.Controls.Find("lbl" + i.ToString(), true).FirstOrDefault() as Label;
                lbl1.BackColor = frm.grauDunkel1;
            }

            Label lbl = this.Controls.Find(lblName, true).FirstOrDefault() as Label;
            lbl.BackColor = frm.bunt1;
        }



        private void lbl1_Click(object sender, EventArgs e)
        {
            selectedMonat = 1;
            farblichHinterlegen("lbl1");
            datumAufButtons();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            selectedMonat = 2;
            farblichHinterlegen("lbl2");
            datumAufButtons();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            selectedMonat = 3;
            farblichHinterlegen("lbl3");
            datumAufButtons();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            selectedMonat = 4;
            farblichHinterlegen("lbl4");
            datumAufButtons();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            selectedMonat = 5;
            farblichHinterlegen("lbl5");
            datumAufButtons();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            selectedMonat = 6;
            farblichHinterlegen("lbl6");
            datumAufButtons();
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            selectedMonat = 7;
            farblichHinterlegen("lbl7");
            datumAufButtons();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            selectedMonat = 8;
            farblichHinterlegen("lbl8");
            datumAufButtons();
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            selectedMonat = 9;
            farblichHinterlegen("lbl9");
            datumAufButtons();
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            selectedMonat = 10;
            farblichHinterlegen("lbl10");
            datumAufButtons();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            selectedMonat = 11;
            farblichHinterlegen("lbl11");
            datumAufButtons();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            selectedMonat = 12;
            farblichHinterlegen("lbl12");
            datumAufButtons();
        }


        private void pbmzurueck_Click(object sender, EventArgs e)
        {
            selectedJahr--;
            lblJahr.Text = selectedJahr.ToString();
            datumAufButtons();
        }

        private void pbmVorwaerts_Click(object sender, EventArgs e)
        {
            selectedJahr++;
            lblJahr.Text = selectedJahr.ToString();
            datumAufButtons();
        }

        private int selectedJahr = DateTime.Today.Year;
        private int selectedMonat = DateTime.Today.Month;
        private int wochentag;

        private void datumAufButtons()
        {
            selectedJahr = Convert.ToInt16(lblJahr.Text);
            tageAnzahlMonat = Convert.ToInt32(DateTime.DaysInMonth(selectedJahr, selectedMonat));
            DateTime datum = new DateTime(selectedJahr, selectedMonat, 1);
            wochentag = Convert.ToInt16(datum.DayOfWeek);

            for (int i = 1; i <= 42; i++)
            {
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = true;
            }

            //MessageBox.Show(wochentag.ToString());
            if (wochentag == 0)
            {
                wochentag = 7;
            }

            for (int i = 1; i < wochentag; i++)
            {
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }

            int start = wochentag;
            for (int b = 1; b <= tageAnzahlMonat; b++)
            {

                Button btn = this.Controls.Find("button" + start.ToString(), true).FirstOrDefault() as Button;
                btn.Text = b.ToString();
                start++;
            }

            for (int i = start; i <= 42; i++)
            {
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }
        }
    }
}
