// 정적 필드 static
class Person
{
    static public int CountOfInstance;
    public string _name;

    public Person(string name)
    {
        CountOfInstance ++;
        _name = name;
    }
}

/* class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine(Person.CountOfInstance);

        Person person1 = new Person("홍길동");
        Person person2 = new Person("홍길순");

        Console.WriteLine(Person.CountOfInstance);
    }
} */