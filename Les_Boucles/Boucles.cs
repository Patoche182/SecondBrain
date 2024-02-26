// Boucles
// Attention aux condition de sortie pour éviter les boucles infinie

namespace Les_Boucles
{
    internal class Boucles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Boucles!");

            // Boucle FOR
            Console.WriteLine("\nBoucles For\n");
            for (int i = 1; i <= 10; i++)  // i = 0=> Etat de base // i < 10 => Condition (tant que) // i++ => Incrémentation
            {
                Console.WriteLine("coucou For " + i);
            }

            // Boucle WHILE
            Console.WriteLine("\nBoucles While\n");
            int j = 1;
            while (j <= 20)
            {
                Console.WriteLine("coucou While " + j);
                // ...
                j++;
            }

            // Récupérer un INPUT Utilisateur
            Console.WriteLine("Quel est le résultat de 3 + 4?");
            string result = Console.ReadLine();     // On récupère la valeur écrite par l'utilisateur
            while (result != "7")                   // Tant que la valeur récupéré n'est pas 7, on continue avec Essaye Encore
            {
                Console.WriteLine("essaye encore !");
                result = Console.ReadLine();
            }
            Console.WriteLine("Bravo!");
        }
    }
}