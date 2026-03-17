using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    /// <summary>
    /// Classe creant un velo, lui étant un type de véhicule
    /// </summary>
    public class Velo : Vehicule
    {
        private string _typeDeGuidon;

        /// <summary>
        /// Constructeur du vélo
        /// </summary>
        /// <param name="marque">marque du vélo</param>
        /// <param name="typeDeGuidon">type du guidon de vélo</param>
        public Velo(string marque, string typeDeGuidon) : base(marque)
        {
            TypeDeGuidon = typeDeGuidon;
        }

        /// <summary>
        /// accesseurs du type de guidon
        /// </summary>
        public string TypeDeGuidon 
        { 
            get => _typeDeGuidon;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Type de guidon null ou vide");

                _typeDeGuidon = value;
            }
        }
    }
}
