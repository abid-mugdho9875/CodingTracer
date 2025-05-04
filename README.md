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

This repository demonstrates a basic implementation of a generic-style list in C#. The program shows how to add values, retrieve them, and perform a sample transformation on an integer value stored in the list.

## 🧰 Features

- Add items to a custom list  
- Retrieve an item by index  
- Modify an integer value using a custom rule:  
  `value * 10 + 5`

## 🧾 Code Example

```csharp
using System;
using System.Collections.Generic;

// A simple generic-style list class
public class GenericList {
    private List<object> list = new List<object>();

    // Adds an item to the list
    public void Add(object item) {
        list.Add(item);
    }

    // Gets an item from the list by index
    public object Get(int index) {
        return list[index];
    }

    // Converts item at the given index to int, modifies it, and returns the result
    public int ModifyVal(int index) {
        int item = Convert.ToInt32(list[index]) * 10 + 5;
        return item;
    }
}

public class HelloWorld {
    public static void Main(string[] args) {
        GenericList intList = new GenericList();
        intList.Add(10);
        intList.Add(20);

        // Retrieve and modify values
        int item = Convert.ToInt32(intList.Get(0));
        int item1 = intList.ModifyVal(1);

        Console.WriteLine(item1); // Output: 205
    }
}

### Generic Class.
### Generic Method.
### Constraints.
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
