using System;

namespace eugenio.malenchi._4i.gelati
{
    public class Ingrediente
    {
        public enum TipoIngrediente
        {
            Nessuno,
            Panna,
            Colorante,
            Aroma,
            PannaSoia,
            Cacao,
            Latte,
            Caffe,
            Mascarpone,
            Uovo
        }

        private int idGelato;
        private string valore;
        private TipoIngrediente tipo;
        private string altro; // Nuovo campo

        public Ingrediente(int idGelato, TipoIngrediente tipo, string valore)
        {
            this.idGelato = idGelato;
            this.tipo = tipo;
            this.valore = valore;
        }

        public Ingrediente(int idGelato, TipoIngrediente tipo, string valore, string altro) // Costruttore aggiornato
        {
            this.idGelato = idGelato;
            this.tipo = tipo;
            this.valore = valore;
            this.altro = altro;
        }

        public Ingrediente() { }

        public Ingrediente(string s)
        {
            string[] s1 = s.Split(';');
            IdGelato = Convert.ToInt32(s1[0]);
            Enum.TryParse(s1[1], out tipo);
            valore = s1[2];
        }

        public int IdGelato
        {
            get { return idGelato; }
            set { idGelato = value; }
        }

        public TipoIngrediente Tipo
        {
            get { return tipo; }
        }

        public string Valore
        {
            get { return valore; }
        }

        public string Altro // Proprietà per accedere al nuovo campo
        {
            get { return altro; }
        }

        public static Ingrediente TrovaIngrediente(string s)
        {
            string[] s1 = s.Split(';');
            TipoIngrediente tipo;
            Enum.TryParse(s1[1], out tipo);
            return new Ingrediente(Convert.ToInt32(s1[0]), tipo, s1[2], s1[3]); // Costruzione dell'ingrediente con il nuovo campo
        }
    }


    public class IngredientePanna : Ingrediente
    {
        public string Tipo { get; set; }
        public int Quantita { get; set; }
    }
    public class IngredienteLatte : Ingrediente
    {
        public string Tipo { get; set; }
        public int Quantita { get; set; }
    }
    public class IngredienteColorante : Ingrediente
    {
        public string Tipo { get; set; }
        public int Quantita { get; set; }
    }
}
