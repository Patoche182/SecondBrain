// Les conditions -  Permet de tester des opérations pour suivre la logique de votre Code
// Fonctionnement des statement : If - Else If - Else (Else If autant que nécéssaire)
// Double égal pour VERIFIER une égalité et non l' ATTRIBUER   ==
// Exclamation égale ==> 'différent de'  !=
// Switch Case Break, If - Else If - Else


namespace Les_Conditions
{
    internal class Condition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========-==========");
            Console.WriteLine("Condition!");
            Console.WriteLine("==========-==========");

            Console.WriteLine("Age =  " + age);
            if (age >= 18 && solde > 0) // Bien comprendre qu'ici on attend un Boolean
            {
                Console.WriteLine("Majeur, solde > 0");
            }
            else if (age > 18 && solde <= 0)
            {
                Console.WriteLine("Majeur, solde < 0");
            }
            else
            {
                Console.WriteLine("Mineur");
            }

            // if(nom = "toto") // Bien comprendre qu'ici on attend un Boolean, un string ne peut pas être convertie en bool (=) et non (==)
            if (nom == "toto")
            {
                Console.WriteLine("Nom = toto");
                Console.WriteLine("Nom = toto");
                Console.WriteLine("Nom = toto");
            }

            switch (age)
            {
                case 1:
                    Console.WriteLine("1 an");
                    break;
                case 2:
                    Console.WriteLine("2 ans");
                    break;
                case 3:
                    Console.WriteLine("3 ans");
                    break;
                // ...
                default:
                    Console.WriteLine("autre");
                    break;
            }
            Console.WriteLine("Solde =  " + solde);
            AcheterProduit(50);
            Console.WriteLine("Solde =  " + solde);
            AcheterProduit(10);
            Console.WriteLine("Solde =  " + solde);
            AcheterProduit(50);
            Console.WriteLine("Solde =  " + solde);
        }

        static float solde = 100;
        static int age = 25;
        static string nom = "toto";

        static void AcheterProduit(float prix)
        {
            if (solde >= prix)
            {
                Console.WriteLine("Achat OK");
                solde = solde - prix;
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }
        }
    }
}