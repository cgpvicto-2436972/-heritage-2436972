using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    /// <summary>
    /// Classe voiture, considéré comme un véhicule
    /// </summary>
    public class Voiture : Vehicule
    {
        private int _nbPortes;

        /// <summary>
        /// Constructeur de la voiture
        /// </summary>
        /// <param name="marque">marque de la voiture</param>
        /// <param name="nbPortes">nombre de portières à la voiture</param>
        public Voiture(string marque, int nbPortes) : base(marque)
        {
            NbPortes = nbPortes;
        }

        /// <summary>
        /// Accesseurs de la voiture
        /// </summary>
        public int NbPortes
        {
            get => _nbPortes;
            private set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentOutOfRangeException("Trop de portes");

                _nbPortes = value;
            }
        }
    }
}
