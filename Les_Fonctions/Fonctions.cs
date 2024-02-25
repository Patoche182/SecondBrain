// Les Fonctions - Bien séparer les fonctions. Doivent être écrite dans la CLass
// Fonctions avec paramètres
// Modification d'une variable à partir d'une fonction


namespace Les_Fonctions
{
    internal class Fonction
    {
        static string monNom = "HANNE"; // Création d'une variable

        static void Main(string[] args) // Static => Permet d'être appler sans devoir instancier la class
        {
            Console.WriteLine("Lancement du programme avec la fonction Main()");

            Console.WriteLine("==========-==========");
            Console.WriteLine("Fonctions!");
            Console.WriteLine("==========-==========");

            DireBonjour();
            DireBonjourAvecParam("Patrice", monNom); // Utilisation de la variable

            ModifierNom();
            DireBonjourAvecParam("Patrice", monNom); // Utilisation de la variable modifié

            // int result = Calculer(3, 5); // int result = => pour justement stocké cette valeur résultat de Calculer
            Console.WriteLine("3 + 5 = " + Calculer(3, 5)); // Optimisation
            Console.WriteLine("1 + 5 = " + Calculer(1, 5));
            Console.WriteLine("9 + 5 = " + Calculer(9, 5));
            Console.WriteLine("168 + 2 = " + Calculer(168, 2)); // "168 + 2 = 170"
        }

        static void DireBonjour() // Static => Permet d'être appler sans devoir instancier la class
        {
            Console.WriteLine("Bonjour !");
        }

        static void DireBonjourAvecParam(string prenom, string nom)
        {
            Console.WriteLine("Bonjour " + prenom + " 1" + nom + " 2" + monNom);
        }

        static int Calculer(int nombre1, int nombre2)
        {
            int resultat = 0; // Initialisation 
            resultat = nombre1 + nombre2;
            return resultat;
        }

        static void ModifierNom()
        {
            monNom = "Toto";
        }
    }
}