using System;
using System.Net.Sockets;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");

Animal[] animal = new Animal[3];
animal[0] = new Lion("시바", 5, "으르렁");
Lion lion = (Lion)animal[0];
animal[1] = new Elephant("덤보", 10, "뿌우");
Elephant elephant = (Elephant)animal[1];
animal[2] = new Penguin("뽀로로", 3, "꽥꽥");
Penguin penguin = (Penguin)animal[2];

Console.WriteLine("[동물 정보]");
lion.DisplayInfo();
elephant.DisplayInfo();
penguin.DisplayInfo();

Console.WriteLine("[동물 소리]");
lion.MakeSound();
elephant.MakeSound();
penguin.MakeSound();

Console.WriteLine("[동물 행동]");
lion.Eat();
lion.Hunt();
elephant.Eat();
elephant.SprayWater();
penguin.Eat();
penguin.Swim();


class Animal
{
    public string Name;
    public int Age;
    protected string _sound;

    public Animal(string name, int age , string sound)
    {
        Name = name;
        Age = age;
        _sound = sound;
    }
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다");
    }
    public void MakeSound()
    {
        Console.WriteLine(_sound);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름:{Name} 나이: {Age}");
    }
}
class Lion : Animal
{

    public Lion (string name, int age, string sound) : base(name, age, sound)
    {

    }
    public void Hunt()
    {
        Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
    }
}
class Elephant : Animal
{
    public Elephant(string name, int age, string sound) : base(name, age, sound)
    {

    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}
class Penguin : Animal
{
    public Penguin(string name, int age, string sound) : base(name, age, sound)
    {

    }
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}