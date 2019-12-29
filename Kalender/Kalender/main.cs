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

            
        }
        internal void ChangeTab(string tab) {

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

        }
    }
}
