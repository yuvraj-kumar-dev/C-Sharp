using System;

class Program
{

    Player Yuvraj = new Player();


    static void Main(string[] args)
    {
        //Access Modifiers manage how accessible a certain variable/ function should be

        //If something is private then it can only be accessible in the class where it is defined

        Test test = new Test();

        Test newTest = new Test();
        newTest.sayHello();  //sayHello was defined as public


    }

    class Test
    {

        string name = "testBot"; //private

        public Test()
        {

            sayMessage();

        }

        // sayMessage(); 

        //We can call the private method as it is being called inside the class where it 
        //was defined but In C#, statements (like method calls) cannot be placed directly 
        // in the class body; they must be inside a method, constructor, or property.

        private void sayMessage() //It is not necessary to explicilty define private if there is nothing
                                  //then by default it is private
        {
            Console.WriteLine("This is a Test");

        }

        public void sayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    private class Player
    {
        private string playerName = "Alex";

        private void greet(string name)
        {
            this.playerName = name;
            Console.WriteLine($"Hello {name}");

        }
        }
    }
