using System;


class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public virtual double CalculateBonus()
    {
        return 0; 
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary:C}, Department: {Department}");
    }
}


class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.20; 
    }
}


class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.10; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Manager Adı: ");
        string managerName = Console.ReadLine();

        Console.Write("Developer Adı: ");
        string developerName = Console.ReadLine();

        Manager manager = new Manager(1, managerName, 10000, "IT", 10);
        Developer developer = new Developer(2, developerName, 8000, "Software", "Full Stack Developer");

        manager.DisplayInfo();
        Console.WriteLine($"Bonus: {manager.CalculateBonus():C}\n");

        developer.DisplayInfo();
        Console.WriteLine($"Bonus: {developer.CalculateBonus():C}\n");
    }
}


