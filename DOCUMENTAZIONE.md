# Documentazione MeskJSON

## Descrizione
Applicazione Windows Forms per gestire previsioni meteo in formato JSON.

## Funzionalità
- Aggiungi, modifica, elimina previsioni
- Salva/carica dati da file JSON
- Anteprima JSON in tempo reale

## Struttura Progetto

### previsioni.cs
Classe che rappresenta una previsione meteo:
```csharp
public class previsioni
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }
}
```

**Metodo ToString()**: Formatta la visualizzazione nella ListBox
```csharp
return $"{Date.ToString("dd/MM/yyyy")} - {TemperatureCelsius}°C - {Summary}";
```

### Form1.cs - Variabile principale
```csharp
public List<previsioni> elencoprev;
```
Lista in memoria che contiene tutte le previsioni.

## Operazioni CRUD

### CREATE - Aggiungi
```csharp
private void btnAggiungi_Click(object sender, EventArgs e)
{
    if (!ValidaCampi()) return;
    
    previsioni prev = new previsioni(
        new DateTimeOffset(dtpData.Value), 
        int.Parse(txtTemperatura.Text), 
        txtDescrizione.Text.Trim()
    );
    elencoprev.Add(prev);
    
    AggiornaLista();
    AggiornaJSON();
}
```

### READ - Carica
```csharp
private void btnCarica_Click(object sender, EventArgs e)
{
    string jsonString = System.IO.File.ReadAllText(fileName);
    // Converte JSON in oggetti C#
    elencoprev = JsonSerializer.Deserialize<List<previsioni>>(jsonString);
}
```

### UPDATE - Modifica
```csharp
private void btnModifica_Click(object sender, EventArgs e)
{
    // Cast: converte l'oggetto generico in tipo previsioni
    previsioni selected = (previsioni)lstPrevisioni.SelectedItem;
    
    selected.Date = new DateTimeOffset(dtpData.Value);
    selected.TemperatureCelsius = int.Parse(txtTemperatura.Text);
    selected.Summary = txtDescrizione.Text.Trim();
}
```

### DELETE - Elimina
```csharp
private void btnElimina_Click(object sender, EventArgs e)
{
    if (MessageBox.Show("Eliminare?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
    {
        elencoprev.Remove((previsioni)lstPrevisioni.SelectedItem);
    }
}
```

### Salva su File
```csharp
private void btnSalva_Click(object sender, EventArgs e)
{
    // Converte oggetti C# in JSON testuale
    string jsonString = JsonSerializer.Serialize(
        elencoprev, 
        new JsonSerializerOptions { WriteIndented = true }
    );
    System.IO.File.WriteAllText(fileName, jsonString);
}
```

## Validazione
```csharp
private bool ValidaCampi()
{
    // Controlla che temperatura sia un numero
    if (!int.TryParse(txtTemperatura.Text, out _)) 
        return false;
    
    // Controlla che descrizione non sia vuota
    if (string.IsNullOrWhiteSpace(txtDescrizione.Text)) 
        return false;
    
    return true;
}
```

## Metodi di Supporto

**AggiornaLista()**: Forza il refresh della ListBox
```csharp
lstPrevisioni.DataSource = null;
lstPrevisioni.DataSource = elencoprev;
```

**AggiornaJSON()**: Mostra JSON in tempo reale nell'anteprima

**PulisciCampi()**: Resetta tutti i campi di input

## Esempio JSON Generato
```json
[
  {
    "Date": "2026-02-15T00:00:00+01:00",
    "TemperatureCelsius": 22,
    "Summary": "Soleggiato"
  }
]
```

## Concetti Chiave

**Serializzazione**: Oggetti C# → JSON testuale  
**Deserializzazione**: JSON testuale → Oggetti C#  
**DataBinding**: Collega automaticamente lista a ListBox  
**Try-Catch**: Gestisce errori per evitare crash

## Note
- File salvato nella cartella dell'eseguibile
- Dati non salvati automaticamente
- Caricamento sostituisce dati in memoria
