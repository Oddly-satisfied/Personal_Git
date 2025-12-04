using System;

class Student
{
    public string name;

    // Constructor
    public Student(string n)
    {
        name = n;
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Snigdha");
        s1.Display();
    }
}
