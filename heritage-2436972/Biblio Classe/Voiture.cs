using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    public class Voiture : Vehicule
    {
        private int _nbPortes;

        public Voiture(string marque, int nbPortes) : base(marque)
        {
            NbPortes = nbPortes;
        }

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
