# Week 4 Assessment

### Setup
* Fork and clone this repository
* Open your forked repo in Visual Studio.
* Complete the two exercises and the questions

## Exercise 1: Inheritance and Dependency Injection (8 points)

Open up `Program.cs` and run your program. It should run with no errors, if you get an error reach out to your instructor.

This exercise involves some refactoring and some new features.

**Step 1:** Currently there are two classess `Student` and `Teacher` that have a lot of repeated code between them. Create a new class `Person` that will be the base class. Then update `Student` and `Teacher` to be derived from `Person`. Include as much in your `Person` class as you can to keep your code DRY (Don't Repeat Yourself). 

**Testing Step 1:** Uncomment the code under "Step 1:" in the Main method. That code should now run without error.

**Step 2:** Implement a new class called `School` that uses dependency injection and takes in a list of people as a dependency. Implement a method called `ListBirthdays` in your school class that calls the `GetBirthday` method and prints to the console each student and teacher's birthday.

**Testing Step 2:** Uncomment the code under "Step 2:" in the Main method. That code should now run without error and output a bunch of names and birthdays.

Ungraded extra challenge: If you have time, improve the way the birthdays are output. Can you group them by month or by Student/Teacher?

### Exercise 2: Interfaces (4 points)
Open up `InterfacePractice.cs`. You should not need to run this file, you will just edit it.

**Step 1:** Take a look at the two classes `Car` and `Bicycle`. They both implement an interface called `InterfaceNameHere`. Replace all three uses of `InterfaceNameHere` with a fitting name for this interface.

**Step 2:** The interface has already been created for you on line 5. Fill in the details for any methods and/or properties that make sense based on the two classes implementing this interface.

## Questions (8 points)

Edit this file with your answers.

1. What are some of the benefits of using inheritance? (1 point)
    * < Reusing code, inheriting the methods and properties of a very large base class could be beneficial when creating a related class as you wont have to re-write all of those methods and properties. Polymorphism is extremely useful. Like in the program.cs file of this test both student and teacher now inherit from the base class person which allows us to add them both to a List<Person>. If we needed to in the future we could now call methods or access properties that they both share.  >  
2. What might be some of the disadvantages of using inheritance? (1 point)
    * < Tight coupling, now that a class is inherited potentially by multiple other classes, any changes made to the base class will require refactoring in all of those that inherit from it. Dependency caused by inheritance is something that can make code harder to reuse in other programs potentially. As without the base class or a lot of refactoring any classes that inherit will not function properly on their own.  >  

3. How would you describe the difference between the base class and the derived class when working with inheritance? (1 point)
	* < The base class stands on it's own with it's own properties and methods. The derived class well... derives from the base class and extends the base classes functionality. >  

4.  What happens if you define the same method in the parent class and the child class? (1 point)
	* < The method is overrided in the child class. Anytime that method is called for the child class, the method that is defined in the child class is what is called. > 

5. In your own words, how would you define an Interface? (1 point)
    * < As a class is a blueprint for objects an interface is a blueprint for classes. It provides the outline for how a class should be built but does not define it's exact functionality. > 

6. Does a class implementing an interface need to implement all of the methods in that interface? Why or why not? (1 point)
    * < Yes it does. That is the purpose of an interface, to define a contract by which the classes that implement it must obide.  > 

7. Both Inheritance and Interfaces use the `:` symbol after a class name. If you're looking at a class, what's one thing that can help you determine if the class is implementing an interface of extending a base class? (1 point)
	* < Interfaces are named in a way that indentifies them, they start with 'I'. >  

8. If asked in an interview, how would you describe the purpose of the IOC container in a .NET application? (1 point)
	* < IoC stands for "inversion of control". An IoC container is a framework to allow for automatic construction of objects with their dependencies. >  


## Rubric

This assessment has a total of 20 points.  A score of 15 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
