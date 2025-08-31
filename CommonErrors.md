# Commom Errors in C#

## Here we will look some common errors we can encounter in C#

### Incorrect Syntax

```
     Missing ;
     Missing )
     Missing }     
```

**For Example**

```
Console.WriteLine("Hello! World") //Missing ;
```

### Wrong Case

```
Using Int instead of int
Using player instead of Player
Using True instead of true

Code is case sensitive!!
```

**For Example**

```
Int age = 35; //Error (int is the correct keyword)
```

### Variable not initialized  

Using a variable before assigning a value leads to this error

```
int a;
Console.WriteLine(a); //Error a is not initialized
```

### Cannot convert type

Trying to implicitly do some type conversion, You need to be explicit and also some types can't be converted

```csharp
float a = 50f;
int b = a; // Error Here, we are trying to implicitly convert float to int which is not possible
```

**To fix this** : We can just expliciltly type cast the float to int but by this we will have to lose some information 

```csharp
float a = 5.6f;
int b = (int)a; // Here, we have to lose the digits after the decimal
```

**Another Example**

```csharp
long a = 56;
int b = a; // Error : long stores data in 64 bits whereas int uses only 32 bits
          // So, int is not capable of storing the variable with data type long
```

### Different Scope  

Variables have a scope they do not exist outside their scope

```csharp
public static void Main(string[] args){
     Console.WriteLine("Hello, World);
     int age = 5;
}

public static myfunc(){
     age++;  // Error : Here, age is in different scope so myfunc() has not access of age variable
}
```

### Variable not changing : Working with a copy

#### Why a Variable Does Not Change – Working with a Copy in C#

In C#, when you pass a **value type** (like `int`, `float`, `bool`, `struct`) to a method or assign it to another variable, a **copy** of the value is created.  
This means changes to the copied value do not affect the original variable.

---

##### Example – Value Type Behavior

```csharp
using System;

class Program
{
    static void ModifyValue(int number)
    {
        number = 10; // Only modifies the local copy
    }

    static void Main()
    {
        int original = 5;
        ModifyValue(original);
        Console.WriteLine(original); // Output: 5 (not 10)
    }
}
```

int is a value type.  
When original is passed to ModifyValue, only a copy of original is used inside the method.  
Modifying number does not affect the original variable.  

##### Example – Reference Type Behavior

If you use a reference type (like class), changes can affect the original object:  

```csharp
class Box
{
    public int Value;
}

class Program
{
    static void ModifyValue(Box box)
    {
        box.Value = 10; // Modifies the object via reference
    }

    static void Main()
    {
        Box myBox = new Box { Value = 5 };
        ModifyValue(myBox);
        Console.WriteLine(myBox.Value); // Output: 10
    }
}
```

**How to Fix (If You Need to Modify Value Types)**  

Use ref or out keywords to pass variables by reference:

```csharp
static void ModifyValue(ref int number)
{
    number = 10;
}

static void Main()
{
    int original = 5;
    ModifyValue(ref original);
    Console.WriteLine(original); // Output: 10
}
```

Value types (e.g., int, float, struct) are copied by default.  
Reference types (e.g., class, array) are passed by reference.  
Use ref or out to modify value types directly within methods.  

### Requires an instance of that class

Accessing something through the class name itself, like player instead of and object of that type  

In C#, there are two types of members:  
- Instance Members – Require an object (instance) of the class to access.
- Static Members – Belong to the class itself and can be accessed directly using the class name.

Why Instance Members Require an Object?  
An instance member (like a non-static variable or method) exists inside a specific object.
If you try to access it using the class name (e.g., Player.Health), C# will give an error because:
The class itself does not hold the data for that member.
Each instance of the class has its own separate copy.

```csharp
class Player
{
    public int health = 100; // Instance variable
}

class Game
{
    static void Main()
    {
        // ❌ Wrong: Accessing instance variable using class name
        // Console.WriteLine(Player.health);  // ERROR

        // ✅ Correct: Create an instance first
        Player player1 = new Player();
        Console.WriteLine(player1.health); // Works: prints 100
    }
}
```

Static Members (Do Not Require an Instance)  
If you declare a member as static, it belongs to the class and not to any specific object.  

```csharp
class Player
{
    public static int maxHealth = 100; // Static member
}

class Game
{
    static void Main()
    {
        Console.WriteLine(Player.maxHealth); // Works without creating an object
    }
}
```

### Cannot access private

#### **Cannot Access Private Members**

In C#, members of a class can have different access levels.  
If a member is marked as `private`, it can only be accessed **within the same class**.

---

#### **Why the Error Occurs**
You are trying to access a `private` field, property, or method from:
- Another class
- Another file
- Outside the scope where it was defined

---

#### **Example**
```csharp
public class Player
{
    private int score = 50; // private member
}

class Program
{
    static void Main(string[] args)
    {
        Player p = new Player();
        // Console.WriteLine(p.score); // ❌ Error: 'score' is inaccessible due to its protection level
    }
}
```

Solution:  
Change the access modifier if needed:  
Use public, internal, or protected depending on your use case.  
Or provide a public method or property to access it.  

```csharp
public class Player
{
    private int score = 50;

    public int GetScore()   // Public method to access private field
    {
        return score;
    }
}
```

### Missing NameSpace (missing using)

In C#, classes are organized into namespaces.  
If you use a class from another namespace, you must:  
Import it with a using directive, or  
Use its fully qualified name.  

```csharp
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // ❌ Error: List not found
    }
}
```

Solution:  

```csharp
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // ✅ Works
    }
}
```