﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ecris_vite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rndNumber;
            string strmotsaisie;
            int points = 0;
            bool fin = false;
            int temps = 0;
            
            do
            {
                /*mots aléatoire normal*/
                string[] secretWordNormal =
                            {
               "trouillard", "rock", "voix", "clavier", "insect", "appendicite", "anticonstitutionnellement", "salutations", "trottinette"
                            };
                /*aléatoire normal*/
                rndNumber = rand.Next(0, secretWordNormal.Length);
                /*aléatoire*/
                string motAleatoireNormal = secretWordNormal[rndNumber];
                /*mots aleatoire normal*/

                Console.WriteLine("\nRegles: vous devez écrire les mots qui s'afficheront a l'écran le plus vite possible.");

                /*mots aléatoire normal*/
                Console.WriteLine("\n{0}", motAleatoireNormal);
                /*mots aléatoire normal*/
                Console.Write("\nECRIS:");
               strmotsaisie = Console.ReadLine();
              
             do
            {
                Thread.Sleep(4000);
                Console.Clear();
                Console.Write("\nLost");
                temps = 0;
            } while (temps != 0);
                


                if (strmotsaisie == motAleatoireNormal)
                {
                    Console.Clear();
                    Console.Write("\nPoints ");
                    points++;
                    Console.WriteLine(points);
                    if (points == 10)
                    {
                        fin = true;
                        Console.WriteLine("\n Vous avez Gagné, bien joué");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("\nPoints ");
                    points--;
                    Console.WriteLine(points);
                    if (points == -10)
                    {
                        fin = true;
                        Console.WriteLine("\n Vous avez PERDU");
                    }

                }
            } while (fin != true);

            
            
            /*quitter le programme*/
            Console.Write("\nPresser sur End deux fois pour terminer le programme");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                if (result.Key == ConsoleKey.End)
                {
                    Console.ReadKey();
                    break;
                }

            }
            /*quitter le programme*/
           

        }
    }
}
