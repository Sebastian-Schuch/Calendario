using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Kalender
{
    public partial class main : Form
    {
        internal Form1 frm;
        public main()
        {
            InitializeComponent();
        }

        private XmlSerializer serializer;
        private void main_Load(object sender, EventArgs e)
        {
            design();
            lblJahr.Text = DateTime.Today.Year.ToString();
            lblwJahr.Text = DateTime.Today.Year.ToString();
            lblwMonat.Text = DateTime.Today.Month.ToString();

            datumAufButtons();
            datumAufButtonsWoche();
            farblichHinterlegen("lbl" + selectedMonat.ToString());
            SuchListViewRefresh("");
            AddClickEventToButtons();
            serializer = new XmlSerializer(frm.arrTermine.GetType());
            /*
            tblLayout.ColumnCount = 3;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblLayout.RowStyles[0] = (new RowStyle(SizeType.Absolute, 30F));
            */
            TagRefresh(selectedJahr, selectedMonat, selectedTag);


        }


        private void AddClickEventToButtons()
        {
            for (int i = 1; i <= 42; i++)
            {
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Click += (sender, args) => ButtonPressRefreshTag(Convert.ToInt32(btn.Text));
            }
        }

        internal void ChangeTab(string tab)
        {
            if (tab.Equals("tag"))
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
                txtSuche.Focus();
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

        private int jahr, monat, tag, selectedTag = DateTime.Today.Day, tageAnzahlMonat;

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



        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int selectedMonat = DateTime.Today.Month;
        private int wochentag;

        private void datumAufButtons()
        {

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

        private int start1;
        private int datumsTag;
        private void datumAufButtonsWoche()
        {

            tageAnzahlMonat = Convert.ToInt32(DateTime.DaysInMonth(selectedJahr, selectedMonat));
            DateTime datum = new DateTime(selectedJahr, selectedMonat, 1);
            wochentag = Convert.ToInt16(datum.DayOfWeek);

            for (int i = 1; i <= 7; i++)
            {
                Button btn = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = true;
            }

            //MessageBox.Show(wochentag.ToString());
            if (wochentag == 0)
            {
                wochentag = 7;
            }

            for (int i = 1; i < wochentag; i++)
            {
                Button btn = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }

            start1 = wochentag;
            datumsTag = 1;
            for (int b = 1; b <= 8 - wochentag; b++)
            {
                Button btn = this.Controls.Find("btnm" + start1.ToString(), true).FirstOrDefault() as Button;
                btn.Text = b.ToString();
                start1++;
                datumsTag++;
            }
        }

        private void datumAufButtonsWocheRueckwaerts()
        {
            tageAnzahlMonat = Convert.ToInt32(DateTime.DaysInMonth(selectedJahr, selectedMonat));
            DateTime datum = new DateTime(selectedJahr, selectedMonat, 1);
            wochentag = Convert.ToInt16(datum.DayOfWeek);

            for (int i = 1; i <= 7; i++)
            {
                Button btn = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = true;
            }

            if (wochentag == 0)
            {
                wochentag = 7;
            }

            int zahl = (wochentag - 1) + tageAnzahlMonat;
            int begin = zahl % 7;

            for (int i = 7; i > begin; i--)
            {
                Button btn = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }

            for (int b = begin; b >= 1; b--)
            {
                Button btn = this.Controls.Find("btnm" + b.ToString(), true).FirstOrDefault() as Button;
                btn.Text = tageAnzahlMonat.ToString();
                tageAnzahlMonat--;
            }
        }

        private void pbWochePlus_Click(object sender, EventArgs e)
        {
            if (btnm7.Visible == false || Convert.ToInt32(btnm7.Text) >= tageAnzahlMonat)
            {
                if (selectedMonat == 12)
                {
                    selectedMonat = 1;
                    selectedJahr++;
                }
                else
                {
                    selectedMonat++;
                }
                lblwMonat.Text = selectedMonat.ToString();
                lblwJahr.Text = selectedJahr.ToString();
                datumAufButtonsWoche();
            }
            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    Button btn1 = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                    btn1.Visible = true;

                }
                for (int b = 1; b <= 7; b++)
                {
                    if (datumsTag > tageAnzahlMonat)
                    {
                        Button btn1 = this.Controls.Find("btnm" + b.ToString(), true).FirstOrDefault() as Button;
                        btn1.Visible = false;
                        datumsTag++;
                    }
                    else
                    {
                        Button btn = this.Controls.Find("btnm" + b.ToString(), true).FirstOrDefault() as Button;
                        btn.Text = datumsTag.ToString();
                        datumsTag++;

                    }
                }
            }
        }
        private void pbWocheMinus_Click(object sender, EventArgs e)
        {

            int tagletzte = Convert.ToInt16(btnm1.Text) - 1;

            if (btnm1.Visible == false || Convert.ToInt32(btnm1.Text) == 1)
            {
                if (selectedMonat == 1)
                {
                    selectedMonat = 12;
                    selectedJahr--;
                }
                else
                {
                    selectedMonat--;
                }
                lblwMonat.Text = selectedMonat.ToString();
                lblwJahr.Text = selectedJahr.ToString();
                datumAufButtonsWocheRueckwaerts();
            }


            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    Button btn1 = this.Controls.Find("btnm" + i.ToString(), true).FirstOrDefault() as Button;
                    btn1.Visible = true;

                }

                for (int b = 1; b <= 7; b++)
                {
                    if (tagletzte < 1)
                    {
                        Button btn1 = this.Controls.Find("btnm" + (8 - b).ToString(), true).FirstOrDefault() as Button;
                        btn1.Visible = false;
                        tagletzte--;
                    }
                    else
                    {
                        Button btn = this.Controls.Find("btnm" + (8 - b).ToString(), true).FirstOrDefault() as Button;
                        btn.Text = tagletzte.ToString();
                        tagletzte--;

                    }
                }
            }
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        internal void SuchListViewRefresh(string filter)
        {
            if (filter.Equals(""))
            {
                ListViewItem lsItem;
                LVsuche.Items.Clear();
                foreach (Termin t in frm.arrTermine)
                {
                    lsItem = new ListViewItem("");
                    lsItem.SubItems.Add(t.TerNname);
                    lsItem.SubItems.Add(t.ToString());

                    LVsuche.Items.Add(lsItem);
                }
            }
            else
            {
                ListViewItem lsItem;
                LVsuche.Items.Clear();
                foreach (Termin t in frm.arrTermine)
                {
                    if (t.TerNname.ToLower().StartsWith(filter.ToLower()))
                    {


                        lsItem = new ListViewItem("");
                        lsItem.SubItems.Add(t.TerNname);
                        lsItem.SubItems.Add(t.ToString());

                        LVsuche.Items.Add(lsItem);
                    }
                }
            }

        }

        private List<Termin> tempListe = new List<Termin>();

        private void BearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Notizen nt = new Notizen(tempListe[ListViewTag.FocusedItem.Index].TerBeschreibung, tempListe[ListViewTag.FocusedItem.Index].TerNname);
                nt.ShowDialog();
            }
            catch { }
        }

        private void ListViewTag_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.ListViewTag.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void BearbeitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int iD = tempListe[ListViewTag.FocusedItem.Index].TerID;
                TerminHinzufuegen th = new TerminHinzufuegen(true, iD);
                th.f1 = frm;
                th.ShowDialog();
                TagRefresh(selectedJahr, selectedMonat, selectedTag);

            }
            catch { }


        }

        private void LöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int iD = tempListe[ListViewTag.FocusedItem.Index].TerID;

                for (int i = 0; i < frm.arrTermine.Count; i++)
                {
                    if (frm.arrTermine[i].TerID == iD)
                    {
                        frm.arrTermine.RemoveAt(i);
                    }
                }
                try
                {
                    FileStream fs = new FileStream(Application.StartupPath + "\\Termine.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                    serializer.Serialize(fs, frm.arrTermine);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                TagRefresh(selectedJahr, selectedMonat, selectedTag);

            }
            catch { }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            TerminHinzufuegen th = new TerminHinzufuegen(selectedJahr, selectedMonat, selectedTag);
            th.f1 = frm;
            th.ShowDialog();
            TagRefresh(selectedJahr, selectedMonat, selectedTag);
        }



        internal void TagRefresh(int jahr, int monat, int tag)
        {
            tempListe.Clear();
            /*tblLayout.Controls.Clear();
            tblLayout.RowStyles.Clear();
            tblLayout.RowCount = 0;*/

            ListViewItem lsItem;
            ListViewTag.Items.Clear();
            foreach (Termin t in frm.arrTermine)
            {
                if (t.Jahr == jahr && t.Monat == monat && t.Tag == tag)
                {
                    tempListe.Add(t);

                    /*tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                    tblLayout.Controls.Add(new Label() { Text = t.TerNname }, 0, tblLayout.RowCount - 1);
                    tblLayout.Controls.Add(new Label() { Text = t.Tag+"."+t.Monat+"."+t.Jahr }, 1, tblLayout.RowCount - 1);

                    Button edit = new Button();
                    edit.Text = "Bearbeiten";
                    edit.Click += (sender, args) => EditTermin(t.TerID);
                    tblLayout.Controls.Add(edit, 2, tblLayout.RowCount - 1);
                    tblLayout.RowCount = tblLayout.RowCount + 1;*/


                    lsItem = new ListViewItem("");
                    lsItem.SubItems.Add(t.TerNname);
                    lsItem.SubItems.Add(t.ToString());
                    int stunden = t.VonInMin / 60;
                    int minuten = t.VonInMin % 60;
                    string uhrzeit;
                    if (stunden < 10)
                    {
                        uhrzeit = "0" + stunden;
                    }
                    else
                    {
                        uhrzeit = stunden.ToString();
                    }
                    if (minuten < 10)
                    {
                        uhrzeit += ":0" + minuten;
                    }
                    else
                    {
                        uhrzeit += ":" + minuten;
                    }

                    stunden = t.BisInMin / 60;
                    minuten = t.BisInMin % 60;

                    if (stunden < 10)
                    {
                        uhrzeit += " - 0" + stunden;
                    }
                    else
                    {
                        uhrzeit += " - " + stunden.ToString();
                    }
                    if (minuten < 10)
                    {
                        uhrzeit += ":0" + minuten;
                    }
                    else
                    {
                        uhrzeit += ":" + minuten;
                    }

                    lsItem.SubItems.Add(uhrzeit);



                    if (t.TerGanztaegig == true)
                    {
                        lsItem.SubItems.Add("\u2611");
                    }
                    else
                    {
                        lsItem.SubItems.Add("\u2610");
                    }

                    ListViewTag.Items.Add(lsItem);



                }
            }
            lblTag.Text = tag + "." + monat + "." + jahr;




        }


        private void EditTermin(int id)
        {
            MessageBox.Show(id.ToString());
        }


        private void ButtonPressRefreshTag(int tag)
        {
            if (Convert.ToInt32(tag) >= 1 && Convert.ToInt32(tag) < 32)
            {
                tabControlMain.SelectedTab = tabTag;
                TagRefresh(selectedJahr, selectedMonat, tag);
                selectedTag = tag;
            }

        }


        private void TxtVon_TextChanged(object sender, EventArgs e)
        {
            SuchListViewRefresh(txtSuche.Text);
        }
    }
}
