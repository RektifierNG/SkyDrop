using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SkyDrop
{
    public partial class IzvjestajiControl : UserControl
    {
        public IzvjestajiControl()
        {
            InitializeComponent();
  
        }

        private void IzvjestajiControl_Load(object sender, EventArgs e)
        {
            UcitajPopisIzvjestaja();
            PostaviChart();
        }

        private void UcitajPopisIzvjestaja()
        {
            cmbIzvjestaji.Items.Clear();
            cmbIzvjestaji.Items.Add("Izvještaj 1 - Korisnici po godinama rođenja");
            cmbIzvjestaji.Items.Add("Izvještaj 2 - Rute s ukupnom težinom paketa");
            cmbIzvjestaji.Items.Add("Izvještaj 3 - Dronovi s brojem ruta (tablica)");
            cmbIzvjestaji.Items.Add("Izvještaj 4 - Dronovi s brojem ruta (grafikon)");
            cmbIzvjestaji.SelectedIndex = 0;
        }

        private void PostaviChart()
        {
            chartIzvjestaj.Series.Clear();
            chartIzvjestaj.ChartAreas.Clear();
            chartIzvjestaj.Titles.Clear();

            var area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.Title = "Dron";
            area.AxisY.Title = "Broj ruta";
            chartIzvjestaj.ChartAreas.Add(area);
        }

        private void cmbIzvjestaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIzvjestaji.SelectedIndex)
            {
                case 0:
                    PrikaziIzvjestaj1();
                    break;
                case 1:
                    PrikaziIzvjestaj2();
                    break;
                case 2:
                    PrikaziIzvjestaj3();
                    break;
                case 3:
                    PrikaziIzvjestaj4();
                    break;
            }
        }

        private void PrikaziGrid<T>(List<T> podaci)
        {
            chartIzvjestaj.Visible = false;
            dgvIzvjestaj.Visible = true;
            dgvIzvjestaj.DataSource = null;
            dgvIzvjestaj.DataSource = podaci;
        }

        private void PrikaziIzvjestaj1()
        {
            using (var db = new SkyDropEntities())
            {
                var brojPoGodinama = db.Korisnik
                    .Where(k => k.DatumRodjenja.HasValue)
                    .GroupBy(k => k.DatumRodjenja.Value.Year)
                    .Select(g => new
                    {
                        Godina = g.Key,
                        Broj = g.Count()
                    })
                    .ToList()
                    .ToDictionary(x => x.Godina, x => x.Broj);

                var rezultat = new List<Izvjestaj1Model>();

                for (int godina = 1950; godina <= 2015; godina++)
                {
                    rezultat.Add(new Izvjestaj1Model
                    {
                        Godina = godina,
                        RodenoKorisnika = brojPoGodinama.ContainsKey(godina) ? brojPoGodinama[godina] : 0
                    });
                }

                PrikaziGrid(rezultat);

                dgvIzvjestaj.Columns["Godina"].HeaderText = "Godina";
                dgvIzvjestaj.Columns["RodenoKorisnika"].HeaderText = "Rođeno korisnika";
            }
        }

        private void PrikaziIzvjestaj2()
        {
            using (var db = new SkyDropEntities())
            {
                var rezultat = db.Ruta
                    .Select(r => new
                    {
                        Ruta = r.Naziv,
                        Dron = r.Dron.Model,
                        UkupnoGrama = r.RutaPaket.Sum(rp => (int?)((rp.Paket.TezinaKg * 1000) + rp.Paket.TezinaG)) ?? 0
                    })
                    .ToList()
                    .Select(x => new Izvjestaj2Model
                    {
                        Ruta = x.Ruta,
                        Dron = x.Dron,
                        UkupnaTezina = FormatirajTezinu(x.UkupnoGrama)
                    })
                    .ToList();

                PrikaziGrid(rezultat);

                dgvIzvjestaj.Columns["Ruta"].HeaderText = "Ruta";
                dgvIzvjestaj.Columns["Dron"].HeaderText = "Dron";
                dgvIzvjestaj.Columns["UkupnaTezina"].HeaderText = "Ukupna težina";
            }
        }

        private void PrikaziIzvjestaj3()
        {
            using (var db = new SkyDropEntities())
            {
                var rezultat = db.Dron
                    .Select(d => new Izvjestaj3Model
                    {
                        Dron = d.Model,
                        BrojRuta = d.Ruta.Count()
                    })
                    .Where(x => x.BrojRuta >= 2)
                    .OrderByDescending(x => x.BrojRuta)
                    .ThenBy(x => x.Dron)
                    .ToList();

                PrikaziGrid(rezultat);

                dgvIzvjestaj.Columns["Dron"].HeaderText = "Dron";
                dgvIzvjestaj.Columns["BrojRuta"].HeaderText = "Broj ruta";
            }
        }

        private void PrikaziIzvjestaj4()
        {
            dgvIzvjestaj.Visible = false;
            chartIzvjestaj.Visible = true;

            using (var db = new SkyDropEntities())
            {
                var podaci = db.Dron
                    .Select(d => new
                    {
                        Dron = d.Model,
                        BrojRuta = d.Ruta.Count()
                    })
                    .Where(x => x.BrojRuta >= 2)
                    .OrderByDescending(x => x.BrojRuta)
                    .ThenBy(x => x.Dron)
                    .ToList();

                chartIzvjestaj.Series.Clear();
                chartIzvjestaj.Titles.Clear();
                chartIzvjestaj.Titles.Add("Dronovi s brojem ruta");

                var series = new Series("Broj ruta");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;

                foreach (var item in podaci)
                {
                    series.Points.AddXY(item.Dron, item.BrojRuta);
                }

                chartIzvjestaj.Series.Add(series);
            }
        }

        private string FormatirajTezinu(int ukupnoGrama)
        {
            int kg = ukupnoGrama / 1000;
            int g = ukupnoGrama % 1000;
            return $"{kg} kg {g} g";
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

    public class Izvjestaj1Model
    {
        public int Godina { get; set; }
        public int RodenoKorisnika { get; set; }
    }

    public class Izvjestaj2Model
    {
        public string Ruta { get; set; }
        public string Dron { get; set; }
        public string UkupnaTezina { get; set; }
    }

    public class Izvjestaj3Model
    {
        public string Dron { get; set; }
        public int BrojRuta { get; set; }
    }
}
