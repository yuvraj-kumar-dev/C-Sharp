using System;

class Program
{
    static void Main(string[] args)
    {

        //Loops : There are 4 types of loops in C#

        // 1) while loop

        // while (condition)
        // {
        //     //Do Something
        // }

        //-------------------------

        // 2) do while loop

        // do
        // {
        //     //Do Something
        // } while (condition);

        //--------------------------

        // 3) for loop

        // for (initialize; condition; increment)
        // {
        //     //Do Something
        // }

        //--------------------------

        // 4) foreach loop

        // foreach (iterator in collection) {
        //     //Do Something
        // }

        //--------------------------

        int i = 1;
        while (i < 11)
        {
            Console.WriteLine($"2*{i}={2 * i}");
            i++;
        }

        int j = 5;

        do
        {
            Console.WriteLine("Inside do while loop: " + j);
        } while (j < 3);

        //do while loop will run atleast once no matter if condition is true or not

        string[] newString = new string[5] {
            "Ram",
            "Shyam",
            "Ghanshyam",
            "Lakhan",
            "Mohan"
        };

        for (int k = 0; k < newString.Length; k++)
        {
            Console.WriteLine(newString[k]);
        }

        Console.WriteLine("-----------");
        
        foreach (string names in newString)
        {
            Console.WriteLine(names);
        }


    }
}