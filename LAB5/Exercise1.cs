using System;

public enum Department
{
    ComputerScience,
    Mathematics,
    Physics
}

public class Person
{
    public string Name { get; set; }

 
    public Person()
    {
        Name = ""; /
    }

  
    public Person(string name)
    {
        Name = name;
    }
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

 
    public Student()
    {
        RegNo = "";
        Age = 0;
        Program = Department.ComputerScience;
    }

    
    public Student(string name, string regNo, int age, Department program)
    {
        Name = name;
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Console.WriteLine($"Student 1: Name={student1.Name}, RegNo={student1.RegNo}, Age={student1.Age}, Program={student1.Program}");

        Student student2 = new Student("Alice", "S123", 22, Department.Physics);
        Console.WriteLine($"Student 2: Name={student2.Name}, RegNo={student2.RegNo}, Age={student2.Age}, Program={student2.Program}");
    }
}
