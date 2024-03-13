using System;

namespace eugenio.malenchi._4i.gelati
{

        internal class Gelato
        {
            private int idGelato;
            private string nome;
            private string prezzo;
            private string descrizione;

            public Gelato(string s)
            {
                string[] s1 = s.Split(';');
                IdGelato = Convert.ToInt32(s1[0]);
                Nome = s1[1];
                Descrizione = s1[2];
                Prezzo = s1[3];
        }


        public int IdGelato { get => idGelato; set => idGelato = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public string Prezzo { get => prezzo; set => prezzo = value; }
        
    }
}
