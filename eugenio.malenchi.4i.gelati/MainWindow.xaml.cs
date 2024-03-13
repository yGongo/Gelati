using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace eugenio.malenchi._4i.gelati
{
    public partial class MainWindow : Window
    {
        private List<Gelato> elencoGelati;
        private List<Ingrediente> elencoIngredienti;

        public MainWindow()
        {
            InitializeComponent();

            //creo le due liste
            elencoGelati = new List<Gelato>();
            elencoIngredienti = new List<Ingrediente>();

            //creo il lettore di Gelati
            StreamReader lettoreGelati = new StreamReader("Gelati.csv");
            lettoreGelati.ReadLine();

            //con un ciclo while scorro il file Gelati.csv
            while (!lettoreGelati.EndOfStream)
            {
                //salvo la riga del file dentro a rigaGelato
                string rigaGelato = lettoreGelati.ReadLine();
                if (rigaGelato.Split(';').Length == 4)
                {
                    //usando il costruttore di Gelato che accetta una stringa creo e aggiungo un nuovo Gelato alla lista elencoGelati
                    elencoGelati.Add(new Gelato(rigaGelato));
                }
            }
            //creo il lettore di Gelati
            StreamReader lettoreIngredienti = new StreamReader("Ingredienti.csv");
            lettoreIngredienti.ReadLine();

            //con un ciclo while scorro il file Ingredienti.csv
            while (!lettoreIngredienti.EndOfStream)
            {
                string rigaIngredienti = lettoreIngredienti.ReadLine();
                if (rigaIngredienti.Split(';').Length == 3)
                {
                    //usando il costruttore di Gelato che accetta una stringa creo e aggiungo un nuovo Ingrediente alla lista elencoGelati
                    elencoIngredienti.Add(new Ingrediente(rigaIngredienti));
                }
            }
            dg.ItemsSource = elencoGelati;
        }

        private void dg1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = e.AddedItems[0] as Gelato;
            int pk = p.IdGelato;
            List<Ingrediente> elencoListaIngredienti = new List<Ingrediente>();
            foreach (Ingrediente ingrediente in elencoIngredienti)
            {
                try
                {
                    if (ingrediente.IdGelato == pk)
                    {
                        elencoListaIngredienti.Add(ingrediente);
                    }
                }
                catch { }
            }
            dg1.ItemsSource = elencoListaIngredienti;
        }
    }
}
