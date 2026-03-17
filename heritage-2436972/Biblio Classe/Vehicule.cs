namespace Biblio_Classe
{
    public class Vehicule
    {
        private string _marque;

        public Vehicule(string marque)
        {
            Marque = marque;
        }

        public void Klaxonner() 
        {
            Console.WriteLine("Bip Bip !");
        }

        public string Marque 
        { 
            get => _marque;
            private set 
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("La marque est null et vide.");

                _marque = value; 
            }
        }
    }
}
