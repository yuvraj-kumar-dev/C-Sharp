# Static : Defines if something belongs to the class itself or to the instance of that class

- What does the static keyword mean in C#?  
It indicates that a member (field, method, or class) belongs to the type itself rather than to a specific instance of the class.

---

- How does a static method differ from a non-static method?  
A static method belongs to the class and can be called without creating an object.
A non-static method belongs to an instance and requires an object to call it.

---

- How does a static field differ from a non-static field?  
A static field is shared across all instances of a class.
A non-static field has a separate value for each instance.

---

- How do you call a static function?  
`ClassName.MethodName();`

---

- How do you access a static field?  
`ClassName.FieldName;`

---

- How are static fields shared across all instances of a class?  
They are stored in a single memory location for the class, and all objects refer to the same value.

---

- Can static methods access non-static fields or methods in a class?  
No, because non-static fields or methods require an instance to access.

---

- Can non-static methods access static fields or methods in a class?  
Yes, non-static methods can access static members because static members are available at the class level.

---

- How do I decide when to make something static or non-static?  
Make it static if it does not depend on instance data.
Use non-static when each instance should have its own copy or behavior.
