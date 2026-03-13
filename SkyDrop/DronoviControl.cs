using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDrop
{
    public partial class DronoviControl : UserControl
    {
        public DronoviControl()
        {
            InitializeComponent();
        }

        private void DronoviControl_Load(object sender, EventArgs e)
        {
            UcitajDronove();
        }

        private void UcitajDronove()
        {
            using (var db = new SkyDropEntities())
            {
                var dronovi = db.Dron
                    .OrderBy(d => d.Model)
                    .ToList();

                cmbDronovi.DataSource = dronovi;
                cmbDronovi.DisplayMember = "Model";
                cmbDronovi.ValueMember = "DronId";
                cmbDronovi.SelectedIndex = -1;
            }

            txtModel.Clear();
        }

        private void cmbDronovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDronovi.SelectedItem is Dron odabraniDron)
            {
                txtModel.Text = odabraniDron.Model;
            }
            else
            {
                txtModel.Clear();
            }
        }

        private bool ValidirajNaziv(string naziv)
        {
            if (string.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Naziv drona je obavezan.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (naziv.Length > 50)
            {
                MessageBox.Show("Naziv smije imati najviše 50 znakova.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(naziv, @"^[\p{L}\p{N} ]+$"))
            {
                MessageBox.Show("Naziv smije sadržavati samo slova, brojke i razmake.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cmbDronovi.SelectedValue == null)
            {
                MessageBox.Show("Odaberite dron.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string noviNaziv = txtModel.Text.Trim();

            if (!ValidirajNaziv(noviNaziv))
                return;

            int dronId = (int)cmbDronovi.SelectedValue;

            using (var db = new SkyDropEntities())
            {
                var dron = db.Dron.FirstOrDefault(d => d.DronId == dronId);

                if (dron == null)
                {
                    MessageBox.Show("Dron nije pronađen.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dron.Model = noviNaziv;
                db.SaveChanges();
            }

            MessageBox.Show("Promjene su uspješno spremljene.", "Obavijest",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            UcitajDronove();
            cmbDronovi.SelectedValue = dronId;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            var glavnaForma = this.FindForm() as Form1;
            if (glavnaForma != null)
            {
                glavnaForma.PrikaziPocetniEkran();
            }
        }
    }
}
