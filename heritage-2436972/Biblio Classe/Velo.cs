using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    public class Velo : Vehicule
    {
        private string _typeDeGuidon;

        public Velo(string marque, string typeDeGuidon) : base(marque)
        {
            TypeDeGuidon = typeDeGuidon;
        }

        public string TypeDeGuidon 
        { 
            get => _typeDeGuidon;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Type de guidon null ou vide");

                _typeDeGuidon = value;
            }
        }
    }
}
