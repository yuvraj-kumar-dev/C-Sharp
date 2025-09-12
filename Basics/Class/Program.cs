using System;

class Program
{
    static void Main(string[] args)
    {

        Player Yuvraj = new Player();
        Yuvraj.sayHello();
        Yuvraj.age = 20;
        Console.WriteLine(Yuvraj.age);

        Player Ram = new Player("Ram");
        Ram.sayHello();
        Player.name = "Yuvraj";

    }

    class Player
    {

        public int age = 19;
        string name = "Player"; //private + non static
        public Player(string name="Player")
        {
            this.name = name;
            Console.WriteLine($"Player {name} created!!");
        }

        public void sayHello()
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}