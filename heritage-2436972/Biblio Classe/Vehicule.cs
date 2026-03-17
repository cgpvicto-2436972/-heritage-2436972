namespace Biblio_Classe
{
    /// <summary>
    /// Classe créant un véhicule
    /// </summary>
    public class Vehicule
    {
        private string _marque;

        /// <summary>
        /// Constructeur du véhicule
        /// </summary>
        /// <param name="marque">marque du véhicule</param>
        public Vehicule(string marque)
        {
            Marque = marque;
        }

        /// <summary>
        /// Méthode qui klaxonne d'autres véhicules
        /// </summary>
        public void Klaxonner() 
        {
            Console.WriteLine("Bip Bip !");
        }

        /// <summary>
        /// Accesseurs de la marque
        /// </summary>
        public string Marque 
        { 
            get => _marque;
            private set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("La marque est null et vide.");

                _marque = value; 
            }
        }
    }
}
