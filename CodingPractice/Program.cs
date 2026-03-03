using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
Child child = new Child();
child.Greet();  
child.Study();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Dog dog = new Dog();
dog.Name = "초코";
dog.Eat();
dog.Bark();

Cat cat = new Cat();
cat.Name = "나비";
cat.Eat();
cat.Meow();

Console.WriteLine("'''\n");

class Parent
{
    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
}

class Child : Parent
{
    public void Study()
    {
        Console.WriteLine("공부합니다.");
    }
}

class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}