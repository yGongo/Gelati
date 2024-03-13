# Gelateria App

## Descrizione
Questo è un'applicazione per la gestione di una gelateria. Carica i dati sui gelati e sugli ingredienti da file CSV e li visualizza in due tabelle separate. Selezionando un gelato dalla tabella principale, verranno visualizzati gli ingredienti associati a quel gelato nella tabella secondaria.

## Utilizzo
1. Avviare l'applicazione.
2. I dati sui gelati e sugli ingredienti verranno caricati automaticamente dai file CSV.
3. Nella tabella principale, selezionare un gelato per visualizzare gli ingredienti associati nella tabella secondaria.

## Requisiti
- Windows
- .NET Framework

## Eseguire il Codice
1. Clonare o scaricare il repository.
2. Aprire il progetto in Visual Studio.
3. Compilare ed eseguire l'applicazione.

## Struttura dei File CSV
- **Gelati.csv**: Contiene i dati sui gelati con le seguenti colonne: ID Gelato, Nome Gelato, Prezzo, e Descrizione.
- **Ingredienti.csv**: Contiene i dati sugli ingredienti con le seguenti colonne: ID Ingrediente, Nome Ingrediente, e ID Gelato (riferimento al gelato associato).
