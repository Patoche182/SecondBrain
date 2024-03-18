/*
About Booleans
Booleans in C# are represented by the bool type, which values can be either true or false.

C# supports four boolean operators: ! (NOT), && (AND), || (OR), and ^ (XOR). The && and || operators use short-circuit evaluation, which means that the right-hand side of the operator is only evaluated when needed.

true || false // => true
true && false // => false
true ^ false  // => true
true ^ true   // => false
The three boolean operators each have a different operator precedence. As a consequence, they are evaluated in this order: not first, && second, ^ third, and finally ||. If you want to 'escape' these rules, you can enclose a boolean expression in parentheses (()), as the parentheses have an even higher operator precedence.

!true && false   // => false
!(true && false) // => true
*/




namespace Les_Booleens
{
    internal class Boolean
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Bool!");
        }
    }
}
