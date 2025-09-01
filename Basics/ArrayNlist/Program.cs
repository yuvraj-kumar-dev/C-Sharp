using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Arrays

        int[] newArray = new int[5] { 1, 3, 5, 7, 9 };
        Console.WriteLine(newArray.Length);
        Console.WriteLine(System.Array.IndexOf(newArray, 1)); //returns the index of the given element

        int[] numArray = new int[3];
        Console.WriteLine(numArray.Length);
        numArray[0] = 6;
        numArray[1] = 5;
        numArray[2] = 9;
        Console.WriteLine(numArray[0]);
        Console.WriteLine(numArray[1]);
        Console.WriteLine(numArray[2]);


        //List

        List<int> numList = new List<int>();
        numList.Add(5);
        numList.Add(10);
        numList.Remove(5);
        Console.WriteLine(numList[0]);
        Console.WriteLine(numList.IndexOf(10));
        
    }
}