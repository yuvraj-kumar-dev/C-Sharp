// See https://aka.ms/new-console-template for more information


// A property in C# is a member of a class that provides a flexible way to read, write, or compute the value of a private field.
// It works like a variable but gives controlled access (through get and set).


class Player1
{
    public string Name { get; set; } // Auto property
}

class Program
{

    static void Main()
    {
        // Player1 - Auto property
        Player1 p1 = new Player1();
        p1.Name = "Yuvraj";
        Console.WriteLine($"Player1 Name: {p1.Name}");

        // Player2 - Backing field
        Player2 p2 = new Player2();
        p2.Score = 50;
        Console.WriteLine($"Player2 Score: {p2.Score}");

        // Player3 - Read-only
        Player3 p3 = new Player3();
        Console.WriteLine($"Player3 Game: {p3.Game}, Country: {p3.Country}");

        // Player4 - Write-only
        Player4 p4 = new Player4();
        p4.Secret = "Hidden message";  // can't read back

        // Player5 - With validation
        Player5 p5 = new Player5();
        p5.Age = -1; // Will print warning
        p5.Age = 20; // Correct value
        Console.WriteLine($"Player5 Age: {p5.Age}");
    
}

}

class Player2
{
    private int score; // backing field

    public int Score
    {
        get { return score; }        // read
        set { score = value; }       // write
    }
}

class Player3
{
    public string Game { get; } = "Cricket"; // read-only

    // OR using backing field
    private string country = "India";
    public string Country
    {
        get { return country; } // only getter
    }
}

class Player4
{
    private string secret;

    public string Secret
    {
        set { secret = value; } // write only
    }
}


class Player5
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0) age = value;
            else Console.WriteLine("Age must be positive!");
        }
    }
}
