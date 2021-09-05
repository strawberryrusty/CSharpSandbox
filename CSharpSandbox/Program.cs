using System;

namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prash!");

            Footballer Ronaldo = new Footballer("Ronaldo", "Manchester United", 25000000);
            Footballer VanPersie = new Footballer("Van Persie", "Arsenal", 130000);

            Console.WriteLine(Ronaldo.Club);
            Console.WriteLine($"{VanPersie.Name} plays for {Ronaldo.Club} and is worth {Ronaldo.Value + 10000000}");
        }
    }
}
