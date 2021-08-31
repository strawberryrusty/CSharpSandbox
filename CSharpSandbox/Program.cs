using System;

namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prash!");

            Footballer Ronaldo = new Footballer("Ronaldo", "Manchester United", 25000000);

            Console.WriteLine(Ronaldo.Club);
            Console.WriteLine($"{Ronaldo.Name} plays for {Ronaldo.Club} and is worth {Ronaldo.Value + 10000000}");
        }
    }
}
