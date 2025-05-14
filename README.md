# Syllabus: C# Profwsional

## 1. Basic Data Types
### C# Data Types
### Variables & constants.
### Array, Multidimensional Array, Jagged Array.
### Input / Output processing.
## 2.Statements & Operators
### Conditional Statements.
### Arithmetic Operators.
### Bitwise Operators.
### Logical Operators.
### Loops.
## 3.Operations With Text
### Important String methods.
###  String formatting.
###  Character methods.
## 4. Working with Class
### Class.
### Namespaces.
### Field, properties.
### Access Modifiers.
#### public	:  The code is accessible for all classes
#### private : 	 The code is only accessible within the same class
#### protected :  The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
#### internal	:  The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
### Auto properties.
### Method Overloading.
### Constructor, Destructor/Finalizer.
### Constructor chaining.
### Readonly, const keywords.
## 5.Working More with Classes.
### Static Class.
### Abstract Class.
### Interface.
### Method Override, virtual, new, sealed keywords.
### Partial Class.

## 6. Other Types.
### Structure.
### Enum.
### DateTime.
### StringBuilder.
### Parameter Modifier.
### Tuple.
### Nullable type.
### Anonymous object.
### dynamic keyword.

## 7.Using Generics.
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
# 📦 Generic List Example in C#

This repository demonstrates a basic implementation of a generic-style list in C#. It shows how to add values, retrieve them, and perform a sample transformation on integer values stored in a list.

---

## 🧰 Features

- Add items to a custom generic list  
- Retrieve an item by index  
- Modify an integer value using a custom rule:  
  `value * 10 + 5`
- Demonstrates usage of generics for code reusability and flexibility

---

## 🧾 Code Example

```csharp
using System;
using System.Collections.Generic; // Generic collection in C#

// A simple generic-style list class
// T defines that it can accept any type of data
public class GenericList<T> {
    private List<T> list = new List<T>(); 

    // Adds an item to the list
    public void Add(T item) {
        list.Add(item);
    }

    // Gets an item from the list by index
    public T Get(int index) {
        return list[index];
    }

    // Converts item at the given index to int, modifies it, and returns the result
    public int ModifyVal(int index) {
        // Convert T to int using Convert.ToInt32
        int item = Convert.ToInt32(list[index]) * 10 + 5;
        return item;
    }
}

public class HelloWorld {
    public static void Main(string[] args) {
        // Declare a generic list for integers
        GenericList<int> intList = new GenericList<int>();
        intList.Add(10);
        intList.Add(20);

        // Retrieve and modify values
        int item = intList.Get(0);
        int item1 = intList.ModifyVal(1);

        Console.WriteLine(item1); // Output: 205
    }
}
```

---

## 💽 Real-World Use Case: Generic Repository for Database Access

Generics are widely used in building reusable and type-safe components like repositories.

```csharp
public class Repository<T>
{
    public T GetById(int id)
    {
        // Retrieve and return an entity of type T from the database
    }

    public void Save(T entity)
    {
        // Save an entity of type T to the database
    }
}
```

### Example Usage

- **User Repository**
```csharp
Repository<User> userRepository = new Repository<User>();
User user = userRepository.GetById(1);
```

- **Product Repository**
```csharp
Repository<Product> productRepository = new Repository<Product>();
Product product = new Product {
    Name = "Laptop",
    Price = 999
};
productRepository.Save(product);
```

✅ This approach reduces code duplication and promotes **code reusability**.

---

## 🔍 Advanced Concepts in Generics

### ✅ Generic Classes  
Classes that can operate on data of any type.

### ✅ Generic Methods  
Methods that introduce their own type parameters.

### ✅ Constraints  
Define requirements for the type parameters used in generics.

### ✨ Common Constraints

1. **`where T : class`** — T must be a reference type  
   ```csharp
   public class MyClass<T> where T : class { }
   ```

2. **`where T : struct`** — T must be a value type  
   ```csharp
   public class MyStruct<T> where T : struct { }
   ```

3. **`where T : new()`** — T must have a parameterless constructor  
   ```csharp
   public class MyGenericClass<T> where T : new() {
       public T CreateInstance() => new T();
   }
   ```

4. **`where T : BaseClass`** — T must inherit from a specific base class  
   ```csharp
   public class MyGenericClass<T> where T : BaseClass {
       public void DoSomething(T instance) {
           instance.BaseMethod();
       }
   }
   ```

5. **`where T : IMyInterface`** — T must implement a specific interface  
   ```csharp
   public class MyGenericClass<T> where T : IMyInterface {
       public void DoSomething(T instance) {
           instance.InterfaceMethod();
       }
   }
   ```

---

## 🚫 Avoid Tight Coupling

Avoid creating overly complex generic classes that are tightly coupled with various types. Tight coupling reduces flexibility and maintainability.

---

## ✅ Summary

Using generics in C#:

- Increases **code reusability**
- Provides **type safety**
- Enables **cleaner architecture** with concepts like the repository pattern
- Can be enhanced with **constraints** to guide acceptable types

---

👨‍💻 Happy Coding!

### Default keyword.
### Built in Generic data structures.
### Non-generics collection.

## 8.Working with Data Access.
### ADO.NET intro.
### CRUD operations.
### SQL Server basics.

## 9.Working with Entity Framework.
### DbContext configuration.
### Entity relationship using fluent API.
### Migrations.
### Data Annotations.

## 10.File & Streams
### Use of FileInfo & File
### Use of DirectoryInfo & Directory
### File read & write operations
### Use of Streams
### Use of “using” keyword

## 11.Important Interfaces.
### In C#, an interface is similar to abstract class.
### All methods of an interface are fully abstract (method without body).
### By convention, interface starts with I so that we can identify it just by seeing its name.
### We cannot use access modifiers inside an interface
### We cannot create objects of an interface
### EXAmple:
**interface IPolygon {
    // method without body
    void calculateArea(int l, int b);

  }**
### Advantage
- Similar to abstract classes, interfaces help us to achieve abstraction in C#
- Interfaces provide specifications that a class (which implements it) must follow.
- Interfaces are used to achieve multiple inheritance in C#
-  Interfaces provide loose coupling(having no or least effect on other parts of code when we change one part of a code).
## 1. ICloneable
- ICloneable is an interface that defines a method for cloning an object
- To implement ICloneable, a class must define a Clone() method that returns an object of the same type as the original object
- 
### IEnumerable.
### ICloneable.
### IDisposable.
### ICollection.

## 12.Learn OOP Principles.
### Encapsulation.
### Inheritance.
### Abstraction.
### Polymorphism.

## 13.Learn SOLID Principles.
### Single Responsibility Principle.
### Open Closed Principle.
### Liskov Substitution Principle.
### Interface Segregation Principle.
### Dependency Inversion Principle.

## 14.C# Advance Features.
### Delegates.
### Events.
### Func & Action.
### Lambda method.
### Linq.

## 15.More Advanced Features.
### Threading.
### Async.
### Exception Handling.
### Indexers.
### Reflection.
### Extension method.
### Expression.

## 16.New Features in C#.
### New switch statements.
### Interface default implementation.
### Inverse indexing.
### Records.
