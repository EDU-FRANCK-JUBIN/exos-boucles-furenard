using System;
using System.Collections.Generic;

namespace ExoBoucle
{
    class Program
    {

        // QUESTION 4
        public static void CalculSommeEntiers(int x, int y)
        {
            int resultat = 0;
            while (x < y+1)
            {
                resultat += x;
                x++;
            }
            Console.WriteLine("\n\nQUESTION 4\n\n");
            Console.WriteLine("Le resultat est de : " + resultat);
        }

        //QUESTION 5
        public static void CalculMoyenne(List<double> listNb)
        {
            double somme = 0;
            int length = listNb.Count;
            foreach (double nb in listNb)
            {
                somme += nb;
            }
            double resultat = somme / length;
            Console.WriteLine("La moyenne de la liste est de : " + resultat);
        }

        // QUESTION 6
        public static void QuestionSix()
        {
            var multipleTrois = new List<double>();
            var multipleCinq = new List<double>();
            var listNb = new List<double>();

            int iterateur;
            double somme = 0;

            Console.WriteLine("\n\nQUESTION 6\n\n");

            // Construction de la liste multipleTrois et multipleCinq
            for (iterateur = 1; iterateur<=100; iterateur ++)
            {
                if (iterateur%3 == 0)
                {
                    multipleTrois.Add(iterateur);
                }

                if (iterateur%5 == 0)
                {
                    multipleCinq.Add(iterateur);
                }
            }

            // affichage des listes obtenues pour vérification
            Console.WriteLine("Liste des multiples de trois : ");
            foreach (var trois in multipleTrois)
            {
                Console.Write(trois + " ");
            }
            Console.WriteLine("\nListe de smultiples de cinq :");
            foreach (var cinq in multipleCinq)
            {
                Console.Write(cinq + " ");
            }

            // Construction de la listeNb
            foreach (var trois in multipleTrois)
            {
                foreach (var cinq in multipleCinq)
                {
                    if (trois == cinq)
                    {
                        listNb.Add(trois);
                    }
                }
            }

            // Affichage de lisNb et construction de l'addition
            Console.WriteLine("\nListe des nombres multiple de trois et de cinq : ");
            foreach (var nb in listNb)
            {
                Console.WriteLine(nb);
                somme += nb;
            }

            // Affichage de la somme
            Console.WriteLine("\nL'addition des nombres multiples de trois et cinq est de : " + somme);



        }


        static void Main(string[] args)
        {
            // QUESTION 1
            
            int i;

            Console.WriteLine("\n\nQUESTION 1\n\n");
            Console.WriteLine("Boucle for\n");
            for (i =0; i<21; i++)
            {
                Console.Write(2 * i + " ");
                if (2*i == 20)
                {
                    i = 21;
                }
            }
           
            i = 0;
            Console.WriteLine("\n\nBoucle while\n");
            while (i<21)
            {
                Console.Write(2 * i + " ");
                if (2 * i == 20)
                {
                    i = 21;
                }
                i++;
            }


            //QUESTION 2

            Console.WriteLine("\n\nQUESTION 2\n\n");
            Console.WriteLine("Veuillez saisir un nombre : ");
            string saisie2 = Console.ReadLine();
            int nb = int.Parse(saisie2);
            i = 0;
            int resultat = 0;
            while (i < nb +1)
            {
                resultat += i;
                i++;
            }

            Console.WriteLine("Le resultat est : " + resultat);
            


            // QUESTION 3
            
            Console.WriteLine("\n\nQUESTION 3\n\n");
            Console.WriteLine("Veuillez saisir 5 chiffres : ");
            string saisie3 = Console.ReadLine();

            int[] tabResult = new int[5];
            char[] arr = saisie3.ToCharArray(0, 5);
            for (i=0; i<5; i++)
            {
                Console.WriteLine("arr : " + arr[i]);
                tabResult[i] = arr[i]-48;
            }

            int somme = 0;
            foreach (int re in tabResult)
            {
                Console.WriteLine(re);
                somme += re;
            }
            Console.WriteLine("La somme des resultats est de : " + somme);
            int moyenne = somme / 5;
            Console.WriteLine("La moyenne des resultats est de : " + moyenne);
            

            
            //QUESTION 4
            CalculSommeEntiers(1, 5);
            CalculSommeEntiers(10, 50);
            CalculSommeEntiers(1, 100);


            // QUESTION 5

            Console.WriteLine("\n\nQUESTION 5\n\n");
            var listNb = new List<double>
            {
                1.0,
                5.6,
                10.8,
                25.1,
                3.2
            };

            var listNb2 = new List<double> {1.0, 5.5, 9.9, 2.8, 9.6};

            CalculMoyenne(listNb);
            CalculMoyenne(listNb2);
            

            // QUESTION 6
            QuestionSix();


        }
    }
}
