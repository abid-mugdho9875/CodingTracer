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
# 📂 File and Directory Operations in C#

This repository demonstrates basic **file and directory handling** in C# using the .NET `System.IO` namespace.

---

## 🚀 What You'll Learn

- ✅ Using `File` and `FileInfo` for reading/writing and accessing metadata
- ✅ Creating directories and listing files using `Directory` and `DirectoryInfo`
- ✅ Reading from and writing to files using `StreamReader` and `StreamWriter`
- ✅ Proper use of the `using` statement for automatic resource management

---

## 🧠 Summary of Concepts

| Concept            | Description |
|--------------------|-------------|
| `File.WriteAllText()` | Static method to write all content at once |
| `File.ReadAllText()` | Static method to read full content at once |
| `FileInfo`         | Object-based file metadata (size, path, etc.) |
| `Directory.CreateDirectory()` | Creates a folder if it doesn’t exist |
| `DirectoryInfo.GetFiles()` | Lists all files in a directory |
| `StreamWriter`     | Writes to a file line-by-line efficiently |
| `StreamReader`     | Reads from a file line-by-line efficiently |
| `using`            | Automatically disposes file handles to prevent memory leaks |

---

## 📁 Project Structure

fileandpractice/
├── Program.cs
├── Directory_learn.cs
└── StreamWriteExamples.cs
✅ 1. File.WriteAllText & File.ReadAllText
**File.WriteAllText(filePath, content);
string content = File.ReadAllText(filePath);

Examples:
string path = "test.txt";
File.WriteAllText(path, "Hello World!");
string content = File.ReadAllText(path);
Console.WriteLine(content);


**
✅ 2. FileInfo 
```
FileInfo file = new FileInfo(filePath);
long size = file.Length;
string fullName = file.FullName;

Examples:
FileInfo file = new FileInfo("test.txt");
Console.WriteLine("File Size: " + file.Length);
```
**
✅ 3. Directory.CreateDirectory & Directory.Exists 
```
Directory.CreateDirectory(folderPath);
bool exists = Directory.Exists(folderPath);

Examples:
string path = "myFolder";
if (!Directory.Exists(path))
    Directory.CreateDirectory(path);
```
**
✅ 4. DirectoryInfo.GetFiles
```
DirectoryInfo dir = new DirectoryInfo(folderPath);
FileInfo[] files = dir.GetFiles();

Examples:
DirectoryInfo dir = new DirectoryInfo("myFolder");
foreach (FileInfo file in dir.GetFiles())
    Console.WriteLine(file.Name);
```
**
✅ 5. StreamWriter
**
```
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("text");
}

Examples:
using (StreamWriter writer = new StreamWriter("stream.txt"))
{
    writer.WriteLine("Line 1");
    writer.WriteLine("Line 2");
}
```
**
✅ 6. StreamReader
**
```
using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

Examples:
using (StreamReader reader = new StreamReader("stream.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
        Console.WriteLine(line);
}
```
**
✅ 7. using 
**
```
using (StreamWriter writer = new StreamWriter("log.txt"))
{
    writer.WriteLine("Logging this.");
}
```
**

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
# 🧬 Deep Cloning in C# with ICloneable

A hands-on C# project demonstrating **shallow vs deep cloning** using the `ICloneable` interface — including inheritance, object composition, and custom clone behavior. Ideal for learning object-oriented programming concepts and safe object copying.

---

## 🚀 Project Features

- ✅ Implements `ICloneable` in multiple classes
- 🔁 Deep copies nested reference objects (like `Address`)
- 🧑‍🎓 Clones derived `Student` class with unique `StudentId`
- 💡 Demonstrates object independence after cloning
- 🧪 Console app with clear visual output

---

## 📁 Project Structure

CloneableExample/
├── Address.cs // Address class with deep clone
├── Person.cs // Base class implementing ICloneable
├── Student.cs // Derived class with custom Clone()
└── Program.cs // Main method demonstrating cloning


---

## 🧾 Code Summary

| File        | Description |
|-------------|-------------|
| `Program.cs` | Main method — creates, clones, and modifies objects to show deep copy in action. |
| `Person.cs`  | Base class with `Name`, `Age`, and `Address`. Implements deep cloning. |
| `Address.cs` | Simple reference type class. Implements its own `Clone()` method. |
| `Student.cs` | Inherits from `Person`, adds `StudentId`, and overrides `Clone()` to generate a new ID. |

---

## 📚 Learning Objectives

- Understand the difference between **shallow** and **deep** copying
- Learn how to implement and override the `Clone()` method safely
- Explore object-oriented practices like inheritance and polymorphism
- Avoid common pitfalls like `InvalidCastException` during cloning


---

## 🧠 Full Source Code

### 📄 `Address.cs`

```csharp
using System;

public class Address : ICloneable
{
    public string City { get; set; }
    public string Street { get; set; }

    public object Clone()
    {
        return new Address
        {
            City = this.City,
            Street = this.Street
        };
    }

    public override string ToString()
    {
        return $"{Street}, {City}";
    }
}
## Person.cs

using System;

public class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    public virtual object Clone()
    {
        return new Person
        {
            Name = this.Name,
            Age = this.Age,
            Address = (Address)this.Address.Clone()
        };
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}";
    }
}

## Student.cs
using System;

public class Student : Person
{
    public Guid StudentId { get; set; }

    public Student()
    {
        StudentId = Guid.NewGuid();
    }

    public override object Clone()
    {
        return new Student
        {
            Name = this.Name,
            Age = this.Age,
            Address = (Address)this.Address.Clone(),
            StudentId = Guid.NewGuid() // new unique ID
        };
    }

    public override string ToString()
    {
        return base.ToString() + $", Student ID: {StudentId}";
    }
}
## Program.cd
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🧬 Deep Cloning Demo in C#\n");

        Student student = new Student
        {
            Name = "John",
            Age = 22,
            Address = new Address
            {
                City = "Chicago",
                Street = "Lake Shore Dr"
            }
        };

        Student clonedStudent = (Student)student.Clone();

        Console.WriteLine("Original Student: " + student);
        Console.WriteLine("Cloned Student:   " + clonedStudent);

        // Modify the original
        student.Name = "Mike";
        student.Address.Street = "Michigan Ave";

        Console.WriteLine("\n🔁 After modifying original:");
        Console.WriteLine("Original Student: " + student);
        Console.WriteLine("Cloned Student:   " + clonedStudent);

        Console.ReadLine();
    }
}
```




### IEnumerable.
# 📚 LibraryProject — Exploring `IEnumerable` and Custom Iterators in C#

This is a simple C# console application that demonstrates how to build a custom iterable collection using `IEnumerable<T>` and `IEnumerator<T>`. It walks through how iteration works under the hood using a basic `Library` and `Book` model.

You can copy and paste the full code below into a single `Program.cs` file and run it directly in Visual Studio.

---

## 🚀 Features

- ✅ Custom iterable class (`Library`)
- ✅ Manual implementation of `IEnumerator<T>` (`LibraryEnumerator`)
- ✅ LINQ support
- ✅ Filtering, sorting, and iteration via `foreach`

---

## ✅ Full Code Example (Paste into Program.cs)

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject
{---BOOK Class
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublishedYear { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({PublishedYear}) - Rating: {Rating}/5";
        }
    }
----Libary_class 
    public class Library : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);

        public void RemoveBook(string title) =>
            books.RemoveAll(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Book> FindByAuthor(string author) =>
            books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Book> GetTopRatedBooks(int count) =>
            books.OrderByDescending(b => b.Rating).Take(count);

        public IEnumerator<Book> GetEnumerator() => new LibraryEnumerator(books);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    
---main program 
    class Program
    {
        static void Main()
        {
            Library library = new Library();

            library.AddBook(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937, Rating = 4.8 });
            library.AddBook(new Book { Title = "C# in Depth", Author = "Jon Skeet", Genre = "Programming", PublishedYear = 2019, Rating = 4.9 });
            library.AddBook(new Book { Title = "Clean Code", Author = "Robert C. Martin", Genre = "Programming", PublishedYear = 2008, Rating = 4.7 });
            library.AddBook(new Book { Title = "Harry Potter", Author = "J.K. Rowling", Genre = "Fantasy", PublishedYear = 1997, Rating = 4.5 });

            Console.WriteLine("📚 All Books:");
            foreach (var book in library)
                Console.WriteLine(book);

            Console.WriteLine("\n🔍 Top 2 Rated Books:");
            foreach (var book in library.GetTopRatedBooks(2))
                Console.WriteLine(book);

            Console.WriteLine("\n🎯 Books Published after 2010:");
            var recentBooks = library.Where(b => b.PublishedYear > 2010);
            foreach (var book in recentBooks)
                Console.WriteLine(book);
        }
    }
}


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
