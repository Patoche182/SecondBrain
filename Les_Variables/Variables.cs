// Variables=(conteneur) - Les variables doivent s'écrirent dans la Class....généralement
// Fonction .ToString()
// Fonction .Parse()
// fonction Console.ReadLine()

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Variables
{
    internal class Program
    {
        // Variables (dans la Class)
        string? name;    // Chaine de Caractère
        int age;        // Nombre entier
        float score;    // Nombre à virgule
        bool active;    // Boolean (true / false)

        // Fonctions
        static void Main(string[] args)
        {
            // Variables (dans la Fonction)
            string name2 = "Patrice";
            name2 = name2 + " HANNE";
            int age2 = 30;
            age2 = age2 + 7;
            float score2 = 12.5f;
            bool active2 = true;

            Console.WriteLine("Variables!");
            Console.WriteLine("Hello " + name2);

            Console.WriteLine("Again, Variables...");
            Console.WriteLine("Hello " + name2);

            Console.WriteLine(age2);
            Console.WriteLine("Age = " + age2.ToString()); // ToString pour transformer en chaine de caractère (et non pas en addition ici)
            Console.WriteLine(score2);
            Console.WriteLine(active2);

            string nombre = "152";
            int result = int.Parse(nombre);  //  int => type que je souhaite; nombre => chaine de caractère que je souhaite convertir avec Parse
            Console.WriteLine("le résultat est : " + result);

            int age3 = int.Parse(Console.ReadLine()); // On .Parse() la valeur écrite par l'utilisateur pour qu'elle corresponde à notre 'int'
            Console.WriteLine("l'age est : " + age3);
        }
    }
}