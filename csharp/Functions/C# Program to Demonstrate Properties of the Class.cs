/*
 *  C# Program to Demonstrate Properties of the Class
 */
using System;
class Student
{
    private string myName = "N/A";
    private int myAge = 0;
    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }
    public int Age
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }

    public static void Main()
    {
        Student Student = new Student();
        Console.WriteLine("Student details - {0}", Student);
        Student.Name = "BOB";
        Student.Age = 99;
        Console.WriteLine("Student details - {0}", Student);
        Student.Age += 1;
        Console.WriteLine("Student details - {0}", Student);
        Console.ReadLine();
    }
}

/*

Student details - Name = N/A, Age = 0
Student details - Name = BOB, Age = 99
Student details - Name = BOB, Age = 100