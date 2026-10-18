using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Calcul du produit des entiers
        /// </summary>
        /// <param name="valeurDepart">valeur de depart du calcul</param>
        /// <param name="valeurArrivée">valeur d'arrivée du calcul</param>
        /// <returns>le produit des entiers</returns>

        static long ProduitEntiers(int valeurDepart, int valeurArrivée)
        {
            long produit = 1;
            for (int k = valeurDepart; k <= valeurArrivée; k++)
            {
                produit *= k;
            }
            return produit;
        }
        
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = (Console.ReadLine());

                // choix excluant le choix de quitter
                

                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());

                        // choix permutation
                        if (choix == "1")
                        {
                            long permutation = ProduitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            // calcul de l'arrangement qui sert aussi au calcul de combinaison
                            long arrangement = ProduitEntiers(nbTotal - nbSousEnsemble + 1, nbTotal);

                            // choix arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") = " + arrangement);
                            }
                            // choix combinaison
                            else
                            {
                                long combinaison = arrangement / ProduitEntiers(1, nbSousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible : saisie incorrecte ou valeur trop grande.");
                    }
                    
                }
                
            }
            Console.ReadLine();
        }
    }
}
