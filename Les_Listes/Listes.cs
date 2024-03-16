// Les listes - Ressemble aux Tableaux
// Avec les listes on peut ajouter des éléments
// Les listes sont très puissantes
// Opérations possible sur les listes : Add AddRange BinarySearch Clear Contains Find Foreach Insert InsertRange Remove RemoveAt RemoveRange Sort TrimExcess TrueForAll

namespace Les_Listes
{
    internal class Listes
    {
        // LES LISTES
        static void Main(string[] args)
        {
            Console.WriteLine("Les Listes!");
            List<string> nomDeMaListe = new List<string>(); // Je crée une liste de <type string>, qui s'apelle 'nomDeMaListe' qui est égale à Nouvelle Liste de <type string>

            // On ajoute des Produits dans ma liste
            nomDeMaListe.Add("Lait");
            nomDeMaListe.Add("Oeuf");
            nomDeMaListe.Add("Crème");
            nomDeMaListe.Add("Beurre");

            foreach (string produit in nomDeMaListe)
            {
                Console.WriteLine(produit);
            }

            if (nomDeMaListe.Contains("Beurre") && nomDeMaListe.Contains("Lait"))
            {
                Console.WriteLine("C'est partie les Cookies !!!");
            }
        }
    }
}