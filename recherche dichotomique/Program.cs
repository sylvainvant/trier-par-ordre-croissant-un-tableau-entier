using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherche_dichotomique
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            int swap;
            int i;
            char reponse;

            Console.WriteLine("combien de nombre voulais vous tirer?");
            int valTab = Int32.Parse(Console.ReadLine());				// on demande le nombre d'élément a trier.
            int[] tabl = new int[valTab];
            Console.WriteLine("vous voulez trier:"+valTab );
      
            int n = 0;
            while (n != valTab)											// et on remplit le tableau.
            {
                int a = n + 1;
                Console.WriteLine("Valeur no" + a + " :");
                tabl[n] = Int32.Parse(Console.ReadLine());
                n++;
            }
            	do															// tant que le tri  n'est pas finit (nbr) on continue.
				{
					nbr = 0;
					i = 0;
                    while (i < tabl.GetLength(0)-1)								//Boucle pour le swap
				    {
					    if(tabl[i] > tabl[i+1])									//le Swap
					    {                         
						        swap = tabl[i];
						        tabl[i] = tabl[i+1];
						        tabl[i+1] = swap;
						        nbr++;
					    }
					   
					i++;
				    }

				        }while(nbr != 0);
	
				Console.WriteLine("\n\nRésultat : ");
				    foreach(int show in tabl) //on affiche le résultat.
			            {
                            Console.Write(show+"\t");
                        }
                // demande de trie par oredre decroissant
                Console.WriteLine("\n\t voulait vous les trier par odre decroissant o/n");
                reponse = Convert.ToChar(Console.ReadLine());
           
    while (Char.ToUpper(reponse) == 'o')
    {
        while (n != valTab)											// et on remplit le tableau.
        {
            int a = n + 1;
            Console.WriteLine("Valeur no" + a + " :");
            tabl[n] = Int32.Parse(Console.ReadLine());
            n++;
        }
        do															// tant que le tri  n'est pas finit (nbr) on continue.
        {
            nbr = 0;
            i = 0;
            while (i < tabl.GetLength(0) - 1)								//Boucle pour le swap
            {
                if (tabl[i] < tabl[i + 1])									//le Swap
                {
                    swap = tabl[i];
                    tabl[i] = tabl[i + 1];
                    tabl[i + 1] = swap;
                    nbr++;
                }

                i++;
            }

        } while (nbr != 0);

        Console.WriteLine("\n\nRésultat : ");
        foreach (int show in tabl) //on affiche le résultat.
        {
            Console.Write(show + "\t");
        }


    }

                System.Console.WriteLine(" \n Appuier sur n'importe quel touche pour quitter");
                System.Console.ReadKey();
				
			}      
        }      
    }

