using System;
using System.Collections.Generic;

public class Student : Person
{
    public int Grade { get; private set; }

    public Student(string name, int grade, DateTime birthday)
    {
        Name = name;
        Grade = grade;
        Birthday = birthday;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a student in grade {Grade}!";
    }

}

public class Teacher : Person
{
    public string Subject { get; private set; }

    public Teacher(string name, string subject, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
        Subject = subject;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a {Subject} teacher!";
    }

}

//Step 1
public class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }

    public string GetBirthday()
    {
        return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    }
}

// Create a school class that uses dependency injection by taking in a list of people.
public class School 
{ 
    List<Person> _people { get; set; }
    public School(List<Person> people)
    {
        _people = people;
    }

    public void ListBirthdays()
    {
        //For the extra goal I had to do a little research online, most of the linq I had already thought of but 'typeof()' was new to me, was previously trying to p.GetType(Student) or p.GetType() == Student
        var students = _people.Where(p => p.GetType() == typeof(Student));
        var teachers = _people.Where(p => p.GetType() == typeof(Teacher));
        Console.WriteLine("\nStudent's Birthdays\n");
        foreach (var student in students)
        {
            Console.WriteLine(student.GetBirthday());
        }
        Console.WriteLine("\nTeacher's Birthdays\n");
        foreach(var teacher in teachers)
        {
            Console.WriteLine(teacher.GetBirthday());
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //// Your solution should make the following code run without errors!

        //// Step 1:
        //// Creating instances of Student and Teacher
        Student studentAlice = new Student("Alice", 10, new DateTime(2007, 1, 20));
        Student studentEthan = new Student("Ethan", 12, new DateTime(2005, 3, 10));
        Teacher teacherJohnson = new Teacher("Mrs. Johnson", "Math", new DateTime(1980, 12, 10));

        //// Creating a list of people
        List<Person> people = new List<Person> { studentAlice, studentEthan, teacherJohnson };

        //// Step 2:
        //// Using dependency injection to create a School instance
        School school = new School(people);

        //// List all birthdays
        school.ListBirthdays();
    }
}
