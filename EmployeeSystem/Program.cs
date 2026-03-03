using System;
using System.Runtime.InteropServices;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 직원 급여 시스템 ===\n");

Manager manager = new Manager("김부장", 5000000, 1000000);
manager.PrintInfo();
Developer developer = new Developer("이개발", 4000000, 10);
developer.PrintInfo();
Intern intern = new Intern("박인턴", 1500000);
intern.PrintInfo();

class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }
    public string Getname()
    {
        return _name;
    }
    public int GetbaseSalary()
    {
        return _baseSalary;
    }
    public int CalculatePay()
    {
        return _baseSalary;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"기본급: {_baseSalary}");
        Console.WriteLine($"총급여: {_baseSalary}");
    }
}
class Manager : Employee
{
    public int _bonus;
    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _bonus = bonus;
    }
    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}");
        Console.WriteLine($"보너스: {_bonus}");
        Console.WriteLine($"총급여: {CalculatePay()}");
    }
}

class Developer : Employee
{
    public int _overtimeHours;
    public Developer(string name, int baseSalary, int overtimehours) : base(name, baseSalary)
    {
        _overtimeHours = overtimehours;
    }
    public new int CalculatePay()
    {
        return _baseSalary + _overtimeHours * 20000;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}");
        Console.WriteLine($"초과근무: {_overtimeHours}");
        Console.WriteLine($"총급여: {CalculatePay()}");
    }
}
class Intern : Employee
{
    public Intern(string name, int baseSalary) : base(name, 1500000)
    {

    }
    public new int CalculatePay()
    {
        return _baseSalary;
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}");
        Console.WriteLine($"총급여: {CalculatePay()}");
    }
}