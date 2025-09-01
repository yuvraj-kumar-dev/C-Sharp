# Static 

- What does the static keyword mean in C#?  
It means the member belongs to the class rather than an instance.

---

- Can a static method in a class access non-static fields of the same class?  
No, because non-static fields belong to specific instances.

---

- How do you call a static function?  
ClassName.FunctionName();

---

- What happens if you declare a class as static?  
It cannot be instantiated and can only contain static members.

---

- What is a correct way to access a static field named score in a class named Game?  
Game.score;

---

- Why might you use a static field in a class?  
To store data that should be shared across all instances, such as a counter for the number of objects created.

---