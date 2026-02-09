# meskjson

Applicazione Windows Forms in C# per gestire previsioni meteorologiche con serializzazione JSON.

## Descrizione

Un semplice gestore di previsioni meteo che permette di creare, modificare, eliminare e salvare previsioni in formato JSON utilizzando `System.Text.Json`.

## Funzionalità

- **Aggiungi** nuove previsioni (data, temperatura, descrizione)
- **Modifica** previsioni esistenti
- **Elimina** previsioni dalla lista
- **Salva** le previsioni su file JSON
- **Carica** previsioni da file JSON
- Visualizzazione in tempo reale del JSON generato

## Requisiti

- .NET Framework
- Windows OS
- Newtonsoft.Json (Json.NET)

## Utilizzo

1. Avvia l'applicazione
2. Inserisci data, temperatura e descrizione
3. Clicca "Aggiungi" per aggiungere una previsione
4. Usa "Salva" per salvare su `previsioni.json`
5. Usa "Carica" per caricare previsioni precedenti

## Struttura

- **Form1.cs** - Logica dell'interfaccia e gestione eventi
- **previsioni.cs** - Classe modello per le previsioni
- **previsioni.json** - File di salvataggio dati
