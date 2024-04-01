using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

class LaPOO
{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Ceci est de la Programmation Orienté Objet");

    //    A_internal objet_a = new A_internal();
    //    A_internal objet_b = new A_internal();

    //    objet_a.x = 1;

    //    objet_a.Log();
    //    objet_b.Log();
    //    A_internal.y = 1;
    //    objet_a.Log();
    //    objet_b.Log();
    //}

    internal class A_internal
    {
        public int x = 0;
        static public int y = 0;

        public void Log()
        {
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class A_public
    {
        public int x = 0;
        static public int y = 0;

        public void Log()
        {
            Console.WriteLine("Ceci est de la Programmation Orienté Objet");
            Console.WriteLine("Ceci est de la Programmation Orienté Objet");
            Console.WriteLine("Ceci est de la Programmation Orienté Objet");
        }
    }



}
