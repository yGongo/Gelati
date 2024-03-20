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

        public Ingrediente(int idGelato, TipoIngrediente tipo, string valore)
        {
            this.idGelato = idGelato;
            this.tipo = tipo;
            this.valore = valore;
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



        public static Ingrediente TrovaIngrediente(string s)
        {
            string[] s1 = s.Split(';');
            TipoIngrediente tipo;
            Enum.TryParse(s1[1], out tipo);
            if (TipoIngrediente.Panna == tipo)
                return new IngredientePanna(s);
            if (TipoIngrediente.Colorante == tipo)
                return new IngrdienteColorante(s);
            if (TipoIngrediente.Latte == tipo)
                return new IngredienteLatte(s);
            return new Ingrediente(s);
        }
    }


    public class IngredientePanna : Ingrediente
    {
        public string Calorie { get; set; }
        public IngredientePanna(string s) : base(s) 
        {
            string[] s1 = s.Split(';');
            IdGelato = Convert.ToInt32(s1[0]);
            Calorie = s1[3];
        }

    }
    public class IngrdienteColorante : Ingrediente
    {
        public string Colore { get; set; }
        public IngrdienteColorante(string s) : base(s)
        {
            string[] s1 = s.Split(';');
            IdGelato = Convert.ToInt32(s1[0]);
            Colore = s1[3];
        }

    }
    public class IngredienteLatte : Ingrediente
    {
        public string Lattosio { get; set; }
        public IngredienteLatte(string s) : base(s)
        {
            string[] s1 = s.Split(';');
            IdGelato = Convert.ToInt32(s1[0]);
            Lattosio = s1[3];
        }

    }
}
