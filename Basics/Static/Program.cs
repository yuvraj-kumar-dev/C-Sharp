using System;

class Program
{
    static void Main(string[] args)
    {
        //Static : Defines if something belongs to the class itself or to the instance of that class

        //Inside any static function we can only access static fields

        Player.sayHello();

        Player Yuvraj = new Player("Yuvraj");

        Player Ram = new Player("Ram");

        Player.sayHello();

        Player.name = "newName";  //public access modifier + static 

        Player.sayHello();

        // Output:Hello Default!!
        //         Player Yuvraj created!
        //         Player Ram created!
        //         Hello Ram!!

    }

    class Player
    {
        public static string name = "Default";

        public Player(string name)
        {
            Player.name = name;
            Console.WriteLine($"Player {name} created!");
        }

        public static void sayHello()
        {
            Console.WriteLine($"Hello {name}!!");
        }
    }
}