using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cours
{
    internal class Cours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int monAge = 1;
            monAge += 1;
            Console.WriteLine(monAge);
            function additionner(int a, int b): int { return a + b; }

            function afficher(int c): void { echo c; }

            calc = new Calculatrice();
            c = calc->additionner(1, 4);
            calc->afficher(c);
        }
        public static void AfficherPerimetre(int longueur, int largeur)
        {
            int perimetre = 2 * (longueur + largeur);
            Console.WriteLine(perimetre); // -> La valeur affichée dépend de la longueur et la largeur
        }

        private AfficherPerimetre(10, 11); // -> 42
        private AfficherPerimetre(2, 2); // -> 8
    }
}