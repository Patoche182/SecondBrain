// Les Tableaux ou  Array (Tirroir)
// on utilise les crochets [] => int[] = tableau de int
// on utilise des accolade pour indiquer la valeur dans ce tableeau {1, 2, 3, 96, 25, 8}
// Tout commence à l'index Zéro [0] == 5 ici;
// Boucle ForEach
using static System.Net.Mime.MediaTypeNames;

namespace Les_Tableaux
{
    internal class Tableaux
    {
        static void Main(string[] args)
        {
            int[] tabDeInts = { 5, 96, 12, 6, 11, 2 }; // int[] => tableau de type int // tabDeInts => Nom du tableau // { 1, 2, 3, 4, 5, 6 }; => Valeur présente dans notre tableau
            Console.WriteLine("Les Tableaux!");
            Console.WriteLine(tabDeInts[2]);
            Console.WriteLine(tabDeInts[1]);
            tabDeInts[1] = 64;                  // je change la valeur à l'index 1 : 96 passe à 64
            Console.WriteLine(tabDeInts[1]);

            // BOUCLE FOR  pour parcourir les valeur du tableau
            for (int i = 0; i < tabDeInts.Length; i++)
            {
                Console.WriteLine("i = " + i + " tab[i] = " + tabDeInts[i]);
            }
            MultiPar2(tabDeInts);

            foreach (int elementNombre in tabDeInts)  // foreach ==> 'pour chaque' Element DANS tableauDeInt
            {
                Console.WriteLine("elementNombre = " + elementNombre);
            }



            // BOUCLE FOR  pour parcourir les index du tableau
            Console.WriteLine("--- On Multiplie tout par 2 ---");
            for (int i = 0; i < tabDeInts.Length; i++)
            {
                Console.WriteLine("i = " + i + " tab[i] = " + tabDeInts[i]);
            }
        }



        // METHODE 
        static void MultiPar2(int[] tabDeInts)
        {
            for (int i = 0; i < tabDeInts.Length; i++)
            {
                tabDeInts[i] = tabDeInts[i] * 2;        //on multiplie toutes les valeurs du tableau par 2
            }
        }
    }
}