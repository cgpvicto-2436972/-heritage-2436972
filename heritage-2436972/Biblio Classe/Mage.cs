using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    /// <summary>
    /// Classe créant un mage, qui lui est un héro
    /// </summary>
    public class Mage : Hero
    {
        private int _quantiteMana;

        /// <summary>
        /// Constructeur du mage
        /// </summary>
        /// <param name="nom">nom du mage</param>
        /// <param name="pv">points de vie du mage</param>
        /// <param name="quantiteMana">quantité de mana du mage</param>
        public Mage(string nom, int pv, int quantiteMana) : base(nom, pv)
        {
            Nom = nom;
            Pv = pv;
            QuantiteMana = quantiteMana;
        }

        /// <summary>
        /// Méthode qui attaque l'ennemi
        /// </summary>
        public override void Attaquer()
        {
            Console.WriteLine(Nom + " utilise un sort");
            _quantiteMana = _quantiteMana - 10;
        }

        /// <summary>
        /// Accesseur de la quantité de mana
        /// </summary>
        public int QuantiteMana 
        { 
            get => _quantiteMana;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La quantité de mana est négative");
                }
                _quantiteMana = value; 
            }
        }
    }
}
