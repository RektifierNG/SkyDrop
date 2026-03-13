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
    public partial class PaketiControl : UserControl
    {
        public PaketiControl()
        {
            InitializeComponent();
        
            dgvPaketi.CellContentClick += dgvPaketi_CellContentClick;
        }

        private void PaketiControl_Load(object sender, EventArgs e)
        {
            UcitajRute();
            PostaviGrid();
        }

        private void UcitajRute()
        {
            using (var db = new SkyDropEntities())
            {
                var rute = db.Ruta
                    .OrderBy(r => r.PlaniranPolazak)
                    .ToList();

                cmbRute.DataSource = rute;
                cmbRute.DisplayMember = "Naziv";
                cmbRute.ValueMember = "RutaId";

                if (rute.Any())
                    cmbRute.SelectedIndex = 0;
            }
        }

        private void PostaviGrid()
        {
            dgvPaketi.AutoGenerateColumns = false;
            dgvPaketi.Columns.Clear();

            dgvPaketi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Redoslijed",
                HeaderText = "Redoslijed",
                DataPropertyName = "Redoslijed"
            });

            dgvPaketi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Naziv",
                HeaderText = "Naziv",
                DataPropertyName = "Naziv",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPaketi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tezina",
                HeaderText = "Težina",
                DataPropertyName = "Tezina"
            });

            dgvPaketi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Korisnik",
                HeaderText = "Korisnik",
                DataPropertyName = "Korisnik",
                Width = 180
            });

            dgvPaketi.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Gore",
                HeaderText = "",
                Text = "GORE",
                UseColumnTextForButtonValue = true,
                Width = 70
            });

            dgvPaketi.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Dolje",
                HeaderText = "",
                Text = "DOLJE",
                UseColumnTextForButtonValue = true,
                Width = 70
            });

            dgvPaketi.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Ukloni",
                HeaderText = "Ukloni",
                Text = "UKLONI",
                UseColumnTextForButtonValue = true,
                Width = 90
            });

            dgvPaketi.ReadOnly = true;
            dgvPaketi.AllowUserToAddRows = false;
            dgvPaketi.AllowUserToDeleteRows = false;
            dgvPaketi.RowHeadersVisible = false;
            dgvPaketi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPaketeZaRutu();
        }

        private void UcitajPaketeZaRutu()
        {
            if (cmbRute.SelectedValue == null)
                return;

            if (!int.TryParse(cmbRute.SelectedValue.ToString(), out int rutaId))
                return;

            using (var db = new SkyDropEntities())
            {
                var paketi = db.RutaPaket
                    .Where(rp => rp.RutaId == rutaId)
                    .OrderBy(rp => rp.Redoslijed)
                    .Select(rp => new PaketRutaGridModel
                    {
                        RutaPaketId = rp.RutaPaketId,
                        Redoslijed = rp.Redoslijed,
                        Naziv = rp.Paket.Naziv,
                        Tezina = rp.Paket.TezinaKg + " kg " + rp.Paket.TezinaG + " g",
                        Korisnik = rp.Paket.Narudzba.Korisnik.Ime + " " + rp.Paket.Narudzba.Korisnik.Prezime
                    })
                    .ToList();

                dgvPaketi.DataSource = paketi;
            }
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            if (cmbRute.SelectedValue == null)
            {
                MessageBox.Show("Odaberite rutu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rutaId = (int)cmbRute.SelectedValue;

            using (var forma = new DodajPaketForm(rutaId))
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    UcitajPaketeZaRutu();
                }
            }
        }

        private void dgvPaketi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var red = dgvPaketi.Rows[e.RowIndex].DataBoundItem as PaketRutaGridModel;
            if (red == null)
                return;

            string nazivStupca = dgvPaketi.Columns[e.ColumnIndex].Name;

            if (nazivStupca == "Ukloni")
            {
                UkloniPaket(red.RutaPaketId);
            }
            else if (nazivStupca == "Gore")
            {
                PomakniGore(red.RutaPaketId);
            }
            else if (nazivStupca == "Dolje")
            {
                PomakniDolje(red.RutaPaketId);
            }
        }

        private void UkloniPaket(int rutaPaketId)
        {
            var potvrda = MessageBox.Show(
                "Jeste li sigurni da želite ukloniti paket s rute?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda != DialogResult.Yes)
                return;

            using (var db = new SkyDropEntities())
            {
                var zaBrisanje = db.RutaPaket.FirstOrDefault(rp => rp.RutaPaketId == rutaPaketId);
                if (zaBrisanje == null)
                    return;

                int rutaId = zaBrisanje.RutaId;

                db.RutaPaket.Remove(zaBrisanje);
                db.SaveChanges();

                PresloziRedoslijed(db, rutaId);
                db.SaveChanges();
            }

            UcitajPaketeZaRutu();
        }

        private void PomakniGore(int rutaPaketId)
        {
            using (var db = new SkyDropEntities())
            {
                var trenutni = db.RutaPaket.FirstOrDefault(rp => rp.RutaPaketId == rutaPaketId);
                if (trenutni == null || trenutni.Redoslijed == 1)
                    return;

                var iznad = db.RutaPaket.FirstOrDefault(rp =>
                    rp.RutaId == trenutni.RutaId &&
                    rp.Redoslijed == trenutni.Redoslijed - 1);

                if (iznad == null)
                    return;

                int temp = trenutni.Redoslijed;
                trenutni.Redoslijed = iznad.Redoslijed;
                iznad.Redoslijed = temp;

                db.SaveChanges();
            }

            UcitajPaketeZaRutu();
        }

        private void PomakniDolje(int rutaPaketId)
        {
            using (var db = new SkyDropEntities())
            {
                var trenutni = db.RutaPaket.FirstOrDefault(rp => rp.RutaPaketId == rutaPaketId);
                if (trenutni == null)
                    return;

                var ispod = db.RutaPaket.FirstOrDefault(rp =>
                    rp.RutaId == trenutni.RutaId &&
                    rp.Redoslijed == trenutni.Redoslijed + 1);

                if (ispod == null)
                    return;

                int temp = trenutni.Redoslijed;
                trenutni.Redoslijed = ispod.Redoslijed;
                ispod.Redoslijed = temp;

                db.SaveChanges();
            }

            UcitajPaketeZaRutu();
        }

        private void PresloziRedoslijed(SkyDropEntities db, int rutaId)
        {
            var paketiNaRuti = db.RutaPaket
                .Where(rp => rp.RutaId == rutaId)
                .OrderBy(rp => rp.Redoslijed)
                .ToList();

            for (int i = 0; i < paketiNaRuti.Count; i++)
            {
                paketiNaRuti[i].Redoslijed = i + 1;
            }
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

    public class PaketRutaGridModel
    {
        public int RutaPaketId { get; set; }
        public int Redoslijed { get; set; }
        public string Naziv { get; set; }
        public string Tezina { get; set; }
        public string Korisnik { get; set; }
    }
}
