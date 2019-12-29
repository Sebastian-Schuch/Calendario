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
