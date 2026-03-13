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
    public partial class DodajPaketForm : Form
    {
        private readonly int _rutaId;

        public DodajPaketForm(int rutaId)
        {
            InitializeComponent();
            _rutaId = rutaId;
        }

        private void DodajPaketForm_Load(object sender, EventArgs e)
        {
            UcitajSlobodnePakete();
        }

        private void UcitajSlobodnePakete()
        {
            using (var db = new SkyDropEntities())
            {
                var zauzetiPaketIds = db.RutaPaket
                    .Select(rp => rp.PaketId)
                    .ToList();

                var slobodniPaketi = db.Paket
                    .Where(p => !zauzetiPaketIds.Contains(p.PaketId))
                    .OrderBy(p => p.Naziv)
                    .ToList()
                    .Select(p => new
                    {
                        p.PaketId,
                        Prikaz = p.Naziv + " (" + p.TezinaKg + " kg " + p.TezinaG + " g)"
                    })
                    .ToList();

                cmbPaketi.DataSource = slobodniPaketi;
                cmbPaketi.DisplayMember = "Prikaz";
                cmbPaketi.ValueMember = "PaketId";
                cmbPaketi.SelectedIndex = slobodniPaketi.Any() ? 0 : -1;

                btnDodaj.Enabled = slobodniPaketi.Any();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbPaketi.SelectedValue == null)
            {
                MessageBox.Show("Nema dostupnih paketa za dodavanje.", "Obavijest",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int paketId = (int)cmbPaketi.SelectedValue;

            using (var db = new SkyDropEntities())
            {
                int zadnjiRedoslijed = db.RutaPaket
                    .Where(rp => rp.RutaId == _rutaId)
                    .Select(rp => (int?)rp.Redoslijed)
                    .Max() ?? 0;

                var novi = new RutaPaket
                {
                    RutaId = _rutaId,
                    PaketId = paketId,
                    Redoslijed = zadnjiRedoslijed + 1
                };

                db.RutaPaket.Add(novi);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
