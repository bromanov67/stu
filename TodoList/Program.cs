Person tom = new Person("Tom", 10);

tom.Print();

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, age: {Age}");
    }
}