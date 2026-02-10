using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;

namespace meskjson
{
    public partial class Form1 : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public List<previsioni> elencoprev;
        public bool modificato;
        public Form1()
        {
            InitializeComponent();
            elencoprev = new List<previsioni>();
            AggiornaLista();
            AbilitaBordoScuro();
            modificato = false;
        }

        private void AbilitaBordoScuro()
        {
            try
            {
                int useImmersiveDarkMode = 1;
                DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PulisciCampi();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            previsioni prev = new previsioni(
                new DateTimeOffset(dtpData.Value), 
                int.Parse(txtTemperatura.Text), 
                cmbDescrizione.Text
            );
            elencoprev.Add(prev);
            modificato = true;
            AggiornaLista();
            AggiornaJSON();
            PulisciCampi();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.Combine(Application.StartupPath, "previsioni.json");
            string jsonString = System.IO.File.ReadAllText(fileName);
            elencoprev = JsonSerializer.Deserialize<List<previsioni>>(jsonString) ?? new List<previsioni>();
            txtJSON.Text = jsonString;
            AggiornaLista();
            modificato = false;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstPrevisioni.SelectedItem == null)
            {
                MessageBox.Show("Seleziona una previsione da modificare.");
            }
            if (MessageBox.Show("Vuoi modificare questa previsione?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previsioni selected = (previsioni)lstPrevisioni.SelectedItem;
                selected.Date = new DateTimeOffset(dtpData.Value);
                selected.TemperatureCelsius = int.Parse(txtTemperatura.Text);
                selected.Summary = cmbDescrizione.Text;
                modificato = true;
                AggiornaLista();
                AggiornaJSON();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi eliminare questa previsione?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                elencoprev.Remove((previsioni)lstPrevisioni.SelectedItem);
                modificato = true;
                AggiornaLista();
                AggiornaJSON();
                PulisciCampi();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.Combine(Application.StartupPath, "previsioni.json");
            string jsonString = JsonSerializer.Serialize(elencoprev, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(fileName, jsonString);
            txtJSON.Text = jsonString;
            modificato = false;
        }

        private void lstPrevisioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrevisioni.SelectedItem != null)
            {
                previsioni p = (previsioni)lstPrevisioni.SelectedItem;
                dtpData.Value = p.Date.DateTime;
                txtTemperatura.Text = p.TemperatureCelsius.ToString();
                cmbDescrizione.Text = p.Summary;
                
                string desc = p.Summary.ToLower();
                if (desc.Contains("infernale") || desc.Contains("hell"))
                    lblEmojiGrande.Text = "🔥";
                else if (desc.Contains("sottozero") || desc.Contains("subzero"))
                    lblEmojiGrande.Text = "🥶";
                else if (desc.Contains("soleggiato") || desc.Contains("sole") || desc.Contains("sunny") || desc.Contains("clear"))
                    lblEmojiGrande.Text = "☀️";
                else if (desc.Contains("nuvoloso") || desc.Contains("nuvol") || desc.Contains("cloudy") || desc.Contains("cloud") || desc.Contains("coperto") || desc.Contains("overcast"))
                    lblEmojiGrande.Text = "☁️";
                else if (desc.Contains("parzial") || desc.Contains("partly") || desc.Contains("partial"))
                    lblEmojiGrande.Text = "⛅";
                else if (desc.Contains("piogg") || desc.Contains("rain") || desc.Contains("drizzle"))
                    lblEmojiGrande.Text = "🌧️";
                else if (desc.Contains("temporal") || desc.Contains("tuoni") || desc.Contains("storm") || desc.Contains("thunder"))
                    lblEmojiGrande.Text = "⛈️";
                else if (desc.Contains("nev") || desc.Contains("snow"))
                    lblEmojiGrande.Text = "❄️";
                else if (desc.Contains("nebbia") || desc.Contains("fog") || desc.Contains("mist"))
                    lblEmojiGrande.Text = "🌫️";
                else if (desc.Contains("vento") || desc.Contains("vent") || desc.Contains("wind"))
                    lblEmojiGrande.Text = "💨";
                else
                    lblEmojiGrande.Text = "🌤️";
            }
        }

        private void AggiornaLista()
        {
            lstPrevisioni.DataSource = null;
            lstPrevisioni.DataSource = elencoprev;
            AggiornaTemperaturaMedia();
        }

        private void AggiornaTemperaturaMedia()
        {
            if (elencoprev.Count == 0)
            {
                lblTempMedia.Text = "📊 Temperatura Media: --";
                lblTempMedia.BackColor = Color.FromArgb(15, 15, 15);
            }
            else
            {
                double media = elencoprev.Average(p => p.TemperatureCelsius);
                lblTempMedia.Text = $"📊 Temperatura Media: {media:F1}°C";
                
                if (media > 18)
                    lblTempMedia.BackColor = Color.FromArgb(180, 50, 30);
                else if (media >= 8)
                    lblTempMedia.BackColor = Color.FromArgb(180, 140, 30);
                else
                    lblTempMedia.BackColor = Color.FromArgb(30, 100, 180);
            }
        }

        private void lstPrevisioni_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            previsioni item = (previsioni)lstPrevisioni.Items[e.Index];
            Color backColor;
            
            if (item.TemperatureCelsius > 18)
                backColor = Color.FromArgb(180, 50, 30);
            else if (item.TemperatureCelsius >= 8)
                backColor = Color.FromArgb(180, 140, 30);
            else
                backColor = Color.FromArgb(30, 100, 180);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backColor = Color.FromArgb(Math.Min(backColor.R + 40, 255), 
                                          Math.Min(backColor.G + 40, 255), 
                                          Math.Min(backColor.B + 40, 255));
            }

            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
            e.Graphics.DrawString(item.ToString(), e.Font, Brushes.White, e.Bounds.Left + 5, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
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
            cmbDescrizione.SelectedIndex = -1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificato==true)
            {
                if (MessageBox.Show("Ci sono dati non salvati, vuoi salvare prima di uscire?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.btnSalva_Click(null, null);
                }
            }
        }
    }
}
