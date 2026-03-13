using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDrop
{
    public partial class RuteControl : UserControl
    {
        public RuteControl()
        {
            InitializeComponent();
        }

        private void RuteControl_Load(object sender, EventArgs e)
        {
            PostaviPocetniRaspon();
            UcitajRute();
        }

        private void PostaviPocetniRaspon()
        {
            using (var db = new SkyDropEntities())
            {
                if (db.Ruta.Any())
                {
                    var minDatum = db.Ruta.Min(r => r.PlaniranPolazak);
                    var maxDatum = db.Ruta.Max(r => r.PlaniranPolazak);

                    dtpOd.Value = minDatum.Date;
                    dtpDo.Value = maxDatum.Date;
                }
            }
        }

        private void UcitajRute()
        {
            DateTime datumOd = dtpOd.Value.Date;
            DateTime datumDo = dtpDo.Value.Date.AddDays(1).AddTicks(-1);

            using (var db = new SkyDropEntities())
            {
                var rute = db.Ruta
                    .Where(r => r.PlaniranPolazak >= datumOd && r.PlaniranPolazak <= datumDo)
                    .Select(r => new
                    {
                        r.Naziv,
                        Dron = r.Dron.Model,
                        r.PlaniranPolazak,
                        r.PlaniranPovratak
                    })
                    .ToList()
                    .Select(r => new RutaGridModel
                    {
                        Naziv = r.Naziv,
                        Dron = r.Dron,
                        PlaniraniPolazak = r.PlaniranPolazak.ToString("dd.MM.yyyy. HH:mm", new CultureInfo("hr-HR")),
                        PlaniraniPovratak = r.PlaniranPovratak.ToString("dd.MM.yyyy. HH:mm", new CultureInfo("hr-HR")),
                        Trajanje = FormatirajTrajanje(r.PlaniranPovratak - r.PlaniranPolazak),
                        PlaniranPolazakRaw = r.PlaniranPolazak,
                        PlaniranPovratakRaw = r.PlaniranPovratak
                    })
                    .OrderBy(r => r.PlaniranPolazakRaw)
                    .ToList();

                dgvRute.DataSource = rute;

                if (dgvRute.Columns["PlaniranPolazakRaw"] != null)
                    dgvRute.Columns["PlaniranPolazakRaw"].Visible = false;

                if (dgvRute.Columns["PlaniranPovratakRaw"] != null)
                    dgvRute.Columns["PlaniranPovratakRaw"].Visible = false;

                dgvRute.Columns["Naziv"].HeaderText = "Naziv";
                dgvRute.Columns["Dron"].HeaderText = "Dron";
                dgvRute.Columns["PlaniraniPolazak"].HeaderText = "Planirani polazak";
                dgvRute.Columns["PlaniraniPovratak"].HeaderText = "Planirani povratak";
                dgvRute.Columns["Trajanje"].HeaderText = "Trajanje";
            }
        }

        private string FormatirajTrajanje(TimeSpan trajanje)
        {
            int sati = (int)trajanje.TotalHours;
            int minute = trajanje.Minutes;

            if (sati == 0)
                return $"{minute}min";

            return $"{sati}hr {minute}min";
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (dtpOd.Value.Date > dtpDo.Value.Date)
            {
                MessageBox.Show("Datum od ne može biti veći od datuma do.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UcitajRute();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            if (dgvRute.Rows.Count == 0)
            {
                MessageBox.Show("Nema podataka za izvoz.", "Obavijest",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV datoteke (*.csv)|*.csv|Sve datoteke (*.*)|*.*";
                sfd.Title = "Spremi CSV";
                sfd.FileName = "rute.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();

                    using (var db = new SkyDropEntities())
                    {
                        DateTime datumOd = dtpOd.Value.Date;
                        DateTime datumDo = dtpDo.Value.Date.AddDays(1).AddTicks(-1);

                        var rute = db.Ruta
                            .Where(r => r.PlaniranPolazak >= datumOd && r.PlaniranPolazak <= datumDo)
                            .OrderBy(r => r.PlaniranPolazak)
                            .Select(r => new
                            {
                                r.Naziv,
                                r.PlaniranPolazak,
                                r.PlaniranPovratak,
                                Dron = r.Dron.Model
                            })
                            .ToList();

                        foreach (var ruta in rute)
                        {
                            sb.AppendLine(
                                $"{ruta.Naziv};{ruta.PlaniranPolazak:dd.MM.yyyy. HH:mm};{ruta.PlaniranPovratak:dd.MM.yyyy. HH:mm};{ruta.Dron}");
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("CSV datoteka je uspješno spremljena.", "Uspjeh",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

    public class RutaGridModel
    {
        public string Naziv { get; set; }
        public string Dron { get; set; }
        public string PlaniraniPolazak { get; set; }
        public string PlaniraniPovratak { get; set; }
        public string Trajanje { get; set; }

        public DateTime PlaniranPolazakRaw { get; set; }
        public DateTime PlaniranPovratakRaw { get; set; }
    }
}
