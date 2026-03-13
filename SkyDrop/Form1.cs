using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrikaziPocetniEkran();
        }

        public void UcitajEkran(UserControl control)
        {
            panelSadrzaj.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelSadrzaj.Controls.Add(control);
            
        }

        private void panelSadrzaj_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDronovi_Click(object sender, EventArgs e)
        {
            UcitajEkran(new DronoviControl());
        }

        internal void PrikaziPocetniEkran()
        {
            UcitajEkran(new PocetniControl());
        }

        private void btnRute_Click(object sender, EventArgs e)
        {
            UcitajEkran(new RuteControl());
        }

        private void btnPaketi_Click(object sender, EventArgs e)
        {
            UcitajEkran(new PaketiControl());
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            UcitajEkran(new IzvjestajiControl());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UcitajEkran(new DronoviControl());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UcitajEkran(new RuteControl());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UcitajEkran(new PaketiControl());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UcitajEkran(new IzvjestajiControl());
        }
    }
}
