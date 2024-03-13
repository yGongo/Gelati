namespace eugenio.malenchi._4i.gelati
{
    internal class Ingrediente
    {
        public enum TipoIngrediente  // Modificato l'accesso a public
        {
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
        private TipoIngrediente tipo;  // Aggiunto il campo per il tipo

        public Ingrediente(int idGelato, TipoIngrediente tipo, string valore)
        {
            this.idGelato = idGelato;
            this.tipo = tipo;
            this.valore = valore;
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
    }
}
