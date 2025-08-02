# dcit318-assignment2-11253505

# DCIT318 Assignment 2 - 11253505

This repository contains three separate C# console applications demonstrating core Object-Oriented Programming (OOP) principles:

## Applications

### 1. Inheritance and Method Overriding

* **Objective**: Demonstrate class inheritance and method overriding.
* **Details**:

  * Base class `Animal` with method `MakeSound()` that prints `"Some generic sound"`.
  * Derived class `Dog` overrides `MakeSound()` to print `"Bark"`.
  * Derived class `Cat` overrides `MakeSound()` to print `"Meow"`.
  * The `Main` method creates instances of each class and calls `MakeSound()`.
* **Path**: `/InheritanceAndOverriding`

### 2. Abstract Classes and Methods

* **Objective**: Demonstrate use of abstract classes and methods.
* **Details**:

  * Abstract class `Shape` with abstract method `GetArea()`.
  * Derived class `Circle` implements `GetArea()` to compute area of a circle.
  * Derived class `Rectangle` implements `GetArea()` to compute area of a rectangle.
  * The `Main` method creates instances and prints their area.
* **Path**: `/AbstractClasses`

### 3. Interfaces

* **Objective**: Demonstrate use of interfaces.
* **Details**:

  * Interface `IMovable` with method `Move()`.
  * Class `Car` implements `Move()` to print `"Car is moving"`.
  * Class `Bicycle` implements `Move()` to print `"Bicycle is moving"`.
  * The `Main` method creates and runs instances.
* **Path**: `/Interfaces`

## Setup Instructions

1. Clone the repository:

   ```bash
   git clone https://github.com/<your-username>/dcit318-assignment2-11253505.git
   cd dcit318-assignment2-11253505
   ```

2. Each folder contains an independent C# project:

   ```bash
   cd InheritanceAndOverriding
   dotnet run

   cd ../AbstractClasses
   dotnet run

   cd ../Interfaces
   dotnet run
   ```

## Commit Structure

* Each application was committed separately with clear messages:

  * `feat: Add Inheritance and Method Overriding app`
  * `feat: Add Abstract Classes and Methods app`
  * `feat: Add Interfaces app`

---

> Developed by **David Asare (11253505)** as part of DCIT318 assignment 2.
