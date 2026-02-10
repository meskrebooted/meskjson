namespace meskjson
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtJSON = new System.Windows.Forms.TextBox();
            this.btnCarica = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.lstPrevisioni = new System.Windows.Forms.ListBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.grpJSON = new System.Windows.Forms.GroupBox();
            this.grpDati = new System.Windows.Forms.GroupBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.grpJSON.SuspendLayout();
            this.grpDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSalva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSalva.Location = new System.Drawing.Point(20, 486);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(220, 45);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "💾 Salva su File";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtJSON
            // 
            this.txtJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtJSON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJSON.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtJSON.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtJSON.Location = new System.Drawing.Point(12, 25);
            this.txtJSON.Multiline = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.ReadOnly = true;
            this.txtJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSON.Size = new System.Drawing.Size(416, 285);
            this.txtJSON.TabIndex = 1;
            // 
            // btnCarica
            // 
            this.btnCarica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCarica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCarica.Location = new System.Drawing.Point(250, 486);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(220, 45);
            this.btnCarica.TabIndex = 2;
            this.btnCarica.Text = "📂 Carica da File";
            this.btnCarica.UseVisualStyleBackColor = false;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperatura.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtTemperatura.Location = new System.Drawing.Point(135, 75);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(209, 27);
            this.txtTemperatura.TabIndex = 4;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescrizione.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescrizione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDescrizione.Location = new System.Drawing.Point(135, 111);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(209, 50);
            this.txtDescrizione.TabIndex = 5;
            // 
            // lstPrevisioni
            // 
            this.lstPrevisioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lstPrevisioni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPrevisioni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstPrevisioni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lstPrevisioni.FormattingEnabled = true;
            this.lstPrevisioni.ItemHeight = 17;
            this.lstPrevisioni.Location = new System.Drawing.Point(20, 70);
            this.lstPrevisioni.Name = "lstPrevisioni";
            this.lstPrevisioni.Size = new System.Drawing.Size(450, 410);
            this.lstPrevisioni.TabIndex = 6;
            this.lstPrevisioni.SelectedIndexChanged += new System.EventHandler(this.lstPrevisioni_SelectedIndexChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAggiungi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAggiungi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAggiungi.Location = new System.Drawing.Point(72, 170);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(95, 38);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "➕ Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dtpData
            // 
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpData.Location = new System.Drawing.Point(135, 42);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(209, 25);
            this.dtpData.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblData.Location = new System.Drawing.Point(15, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(68, 19);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "📅 Data:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTemperatura.Location = new System.Drawing.Point(15, 75);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(106, 19);
            this.lblTemperatura.TabIndex = 9;
            this.lblTemperatura.Text = "🌡️ Temp. (°C):";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescrizione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblDescrizione.Location = new System.Drawing.Point(15, 111);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(114, 19);
            this.lblDescrizione.TabIndex = 10;
            this.lblDescrizione.Text = "📝 Descrizione:";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnModifica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnModifica.Location = new System.Drawing.Point(182, 170);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(95, 38);
            this.btnModifica.TabIndex = 11;
            this.btnModifica.Text = "✏️ Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnElimina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnElimina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnElimina.Location = new System.Drawing.Point(293, 170);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(95, 38);
            this.btnElimina.TabIndex = 12;
            this.btnElimina.Text = "🗑️ Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // grpJSON
            // 
            this.grpJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.grpJSON.Controls.Add(this.txtJSON);
            this.grpJSON.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.grpJSON.Location = new System.Drawing.Point(490, 70);
            this.grpJSON.Name = "grpJSON";
            this.grpJSON.Size = new System.Drawing.Size(440, 325);
            this.grpJSON.TabIndex = 14;
            this.grpJSON.TabStop = false;
            this.grpJSON.Text = "📋 Anteprima JSON";
            // 
            // grpDati
            // 
            this.grpDati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.grpDati.Controls.Add(this.lblData);
            this.grpDati.Controls.Add(this.dtpData);
            this.grpDati.Controls.Add(this.txtTemperatura);
            this.grpDati.Controls.Add(this.lblTemperatura);
            this.grpDati.Controls.Add(this.txtDescrizione);
            this.grpDati.Controls.Add(this.lblDescrizione);
            this.grpDati.Controls.Add(this.btnAggiungi);
            this.grpDati.Controls.Add(this.btnElimina);
            this.grpDati.Controls.Add(this.btnModifica);
            this.grpDati.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.grpDati.Location = new System.Drawing.Point(490, 401);
            this.grpDati.Name = "grpDati";
            this.grpDati.Size = new System.Drawing.Size(440, 220);
            this.grpDati.TabIndex = 15;
            this.grpDati.TabStop = false;
            this.grpDati.Text = "⚙️ Modifica Dati";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTitolo.Location = new System.Drawing.Point(15, 15);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(400, 37);
            this.lblTitolo.TabIndex = 16;
            this.lblTitolo.Text = "🌤️ Gestione Previsioni Meteo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(945, 640);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.grpDati);
            this.Controls.Add(this.grpJSON);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lstPrevisioni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeskJSON - Gestione Previsioni Meteo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpJSON.ResumeLayout(false);
            this.grpJSON.PerformLayout();
            this.grpDati.ResumeLayout(false);
            this.grpDati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtJSON;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.ListBox lstPrevisioni;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.GroupBox grpJSON;
        private System.Windows.Forms.GroupBox grpDati;
        private System.Windows.Forms.Label lblTitolo;
    }
}

