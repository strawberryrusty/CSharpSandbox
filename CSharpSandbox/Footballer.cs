using System;
namespace CSharpSandbox
{
    public class Footballer
    {
     public string Name { get; set; }
     public string Club { get; set; }
     public int Value { get; set; }

    public Footballer(string name, string club, int value)
    {
            this.Name = name;
            this.Club = club;
            this.Value = value;
    }
    }
}
