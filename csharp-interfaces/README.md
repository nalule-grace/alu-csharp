C# Interfaces Exercises - README
This repository contains exercises exploring Abstract Classes, Interfaces, and Generics in C#.

Project Structure:

Each folder represents a separate exercise building upon the previous one. Inside each folder, you'll find:

0-main.cs: This file contains the main program that demonstrates the functionalities of the exercise.
X-X.cs: This file contains the class definitions and implementations for the exercise (X being the exercise number).
Exercises:

Abstract Thinking:

Creates an abstract class called Base with a public string property name and a ToString method that returns a formatted string.
Creates a class called SoftwareEngineer inheriting from Base.
User Interface:

Creates interfaces called IInteractive, IBreakable, and ICollectable with their respective methods and properties.
Creates a class called TestObject inheriting from Base and implementing all three interfaces (Note: Methods are not fully implemented here).
Escape Room:

Replaces TestObject with a Door class inheriting from Base and IInteractive.
Implements the Interact method for Door to print a message indicating it's locked.
Interior Decorating:

Creates a class called Decoration inheriting from Base, IInteractive, and IBreakable.
Adds properties and a constructor for Decoration handling default values and validation.
Implements Interact and Break methods to interact with the decoration based on its state.
Key Collecting:

Creates a class called Key inheriting from Base and ICollectable.
Adds a constructor and implements the Collect method to handle picking up the key.
Iterate and Act:

Creates a generic class called Objs<T> that implements IEnumerable<T>, allowing iteration through a collection of type T.
Modifies the main program to use Objs<T> for iterating through different object types based on interfaces.
Running the Exercises:

Clone this repository.
Navigate to the desired exercise directory (e.g., 1-user_interface).
Run dotnet run in the terminal to execute the program.