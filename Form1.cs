using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;

namespace meskjson
{
    public partial class Form1 : Form
    {
        public List<previsioni> elencoprev;
        
        public Form1()
        {
            InitializeComponent();
            elencoprev = new List<previsioni>();
            AggiornaLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PulisciCampi();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (!ValidaCampi()) return;

            try
            {
                previsioni prev = new previsioni(
                    new DateTimeOffset(dtpData.Value), 
                    int.Parse(txtTemperatura.Text), 
                    txtDescrizione.Text.Trim()
                );
                elencoprev.Add(prev);
                
                AggiornaLista();
                AggiornaJSON();
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.Combine(Application.StartupPath, "previsioni.json");
            
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("File non trovato");
                return;
            }
            
            try
            {
                string jsonString = System.IO.File.ReadAllText(fileName);
                elencoprev = JsonSerializer.Deserialize<List<previsioni>>(jsonString) ?? new List<previsioni>();
                
                txtJSON.Text = jsonString;
                AggiornaLista();
                MessageBox.Show($"Caricati {elencoprev.Count} previsioni");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstPrevisioni.SelectedItem == null)
            {
                MessageBox.Show("Seleziona una previsione");
                return;
            }

            if (!ValidaCampi()) return;

            try
            {
                previsioni selected = (previsioni)lstPrevisioni.SelectedItem;
                selected.Date = new DateTimeOffset(dtpData.Value);
                selected.TemperatureCelsius = int.Parse(txtTemperatura.Text);
                selected.Summary = txtDescrizione.Text.Trim();
                
                AggiornaLista();
                AggiornaJSON();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lstPrevisioni.SelectedItem == null)
            {
                MessageBox.Show("Seleziona una previsione");
                return;
            }

            if (MessageBox.Show("Eliminare questa previsione?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                elencoprev.Remove((previsioni)lstPrevisioni.SelectedItem);
                AggiornaLista();
                AggiornaJSON();
                PulisciCampi();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (elencoprev.Count == 0)
            {
                MessageBox.Show("Nessuna previsione da salvare");
                return;
            }

            try
            {
                string fileName = System.IO.Path.Combine(Application.StartupPath, "previsioni.json");
                string jsonString = JsonSerializer.Serialize(elencoprev, new JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(fileName, jsonString);
                txtJSON.Text = jsonString;
                
                MessageBox.Show("File salvato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void lstPrevisioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrevisioni.SelectedItem == null)
            {
                PulisciCampi();
            }
            else
            {
                previsioni p = (previsioni)lstPrevisioni.SelectedItem;
                dtpData.Value = p.Date.DateTime;
                txtTemperatura.Text = p.TemperatureCelsius.ToString();
                txtDescrizione.Text = p.Summary;
            }
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            PulisciCampi();
            lstPrevisioni.SelectedIndex = -1;
        }

        private bool ValidaCampi()
        {
            if (string.IsNullOrWhiteSpace(txtTemperatura.Text) || !int.TryParse(txtTemperatura.Text, out _))
            {
                MessageBox.Show("Inserisci una temperatura valida");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescrizione.Text))
            {
                MessageBox.Show("Inserisci una descrizione");
                return false;
            }

            return true;
        }

        private void AggiornaLista()
        {
            lstPrevisioni.DataSource = null;
            lstPrevisioni.DataSource = elencoprev;
        }

        private void AggiornaJSON()
        {
            if (elencoprev.Count > 0)
                txtJSON.Text = JsonSerializer.Serialize(elencoprev, new JsonSerializerOptions { WriteIndented = true });
            else
                txtJSON.Text = "";
        }

        private void PulisciCampi()
        {
            dtpData.Value = DateTime.Now;
            txtTemperatura.Text = "";
            txtDescrizione.Text = "";
        }
    }
}
