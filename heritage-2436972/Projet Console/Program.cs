using Biblio_Classe;
namespace Projet_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule monAuto = new Voiture("toyota", 4);

            monAuto.Klaxonner();
        }
    }
}
