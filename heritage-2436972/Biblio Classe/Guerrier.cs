using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    /// <summary>
    /// Classe céant un guerrier, étant un héro
    /// </summary>
    public class Guerrier : Hero
    {
        private string _arme;

        /// <summary>
        /// constructeur du guerrier
        /// </summary>
        /// <param name="nom">nom du guerrier</param>
        /// <param name="pv">points de vie du guerrier</param>
        /// <param name="arme">arme du guerrier</param>
        public Guerrier(string nom, int pv, string arme) : base(nom, pv)
        {
            Nom = nom;
            Pv = pv;
            Arme = arme;
        }

        /// <summary>
        /// Méthode qui attaque l'ennemi
        /// </summary>
        public override void Attaquer()
        {
            Console.WriteLine(Nom + " donne un coup de " + _arme);
        }

        /// <summary>
        /// Accesseur de l'arme
        /// </summary>
        public string Arme
        {
            get => _arme;
            set 
            { 
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Le nom de l'arme utilisée est null ou vide");

                _arme = value; 
            }
        }
    }
}
