using System;

class Program
{
    // Class Scope: b is available to all methods in this class
    int b = 100;

    static void Main(string[] args)
    {
        Program obj = new Program();
        obj.BlockScope();
        obj.MethodScope();
        obj.ClassScope();
        obj.Shadowing();
    }

    // 1. Block Scope Example
    void BlockScope()
    {
        Console.WriteLine("=== Block Scope ===");
        int x = 10; // x is accessible in this method
        {
            int y = 20; // y is accessible only inside this block
            Console.WriteLine(x); // Works
            Console.WriteLine(y); // Works
        }
        Console.WriteLine(x); // Works
        // Console.WriteLine(y); // ERROR: y not accessible here
    }

    // 2. Method Scope Example
    void MethodScope()
    {
        Console.WriteLine("\n=== Method Scope ===");
        int a = 5;
        Console.WriteLine(a); // Works only in this method
    }

    // 3. Class Scope Example
    void ClassScope()
    {
        Console.WriteLine("\n=== Class Scope ===");
        Console.WriteLine(b); // Works because b is class-level
    }

    // 4. Shadowing Example
    void Shadowing()
    {
        Console.WriteLine("\n=== Shadowing ===");
        int x = 10;
        Console.WriteLine(x); // Prints 10

        {
            int x2 = 20; // New variable, different name
            Console.WriteLine(x2); // Prints 20
        }
    }
}
