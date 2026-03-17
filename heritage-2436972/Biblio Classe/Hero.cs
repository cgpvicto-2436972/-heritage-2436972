using System;
using System.Collections.Generic;
using System.Text;

namespace Biblio_Classe
{
    /// <summary>
    /// Classe d'un héro
    /// </summary>
    public class Hero
    {
        private string _nom;
        protected int _pv;

        /// <summary>
        /// Constructeur du héro
        /// </summary>
        /// <param name="nom">nom du héro</param>
        /// <param name="pv">Nombre de points de vie</param>
        public Hero(string nom, int pv)
        {
            Nom = nom;
            Pv = pv;
        }

        /// <summary>
        /// Méthode attaquant un ennemi
        /// </summary>
        public virtual void Attaquer()
        {
            Console.WriteLine(_nom + " donne un coup de poing !");
        }

        /// <summary>
        /// Accesseurs du nom
        /// </summary>
        public string Nom
        {
            get => _nom;
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Le nom est null ou vide");

                _nom = value; 
            }
        }

        /// <summary>
        /// Accesseurs des points de vie
        /// </summary>
        public int Pv 
        { 
            get => _pv;
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Le nombre des points de vie est négative");

                _pv = value; 
            }
        }
    }
}
