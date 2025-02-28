//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace WiproTraining.DAY8
//{
//    internal class lamdaexpression
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//IEnumerable<int> evenNumbers = numbers.Where(n=> n%2 == 0);
//Console.WriteLine("Even numbers:");
//foreach (int number in evenNumbers)
//{
//    Console.WriteLine(number);
//}


//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//IEnumerable<int> evenNumbers = numbers.Where(n => (n&2) != 0);
//Console.WriteLine("Even numbers:");
//foreach (int number in evenNumbers)
//{
//    Console.WriteLine(number);
//}

//IEnumerable<int> oddNumbers = numbers.Where(n => n % 2 == 0);
//Console.WriteLine("odd numbers:");
//foreach (int number in oddNumbers)
//{
//    Console.WriteLine(number);
//}


//IEnumerable<int> oddNumbers = numbers.Where(n => (n&1) != 0);
//Console.WriteLine("odd numbers:");
//foreach (int number in oddNumbers)
//{
//    Console.WriteLine(number);
//}


//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Person> people = new List<Person>
//        { 
//            new Person("Alice",20),
//            new Person("Bob",35),
//            new Person("Charl",30),
//            new Person("David",22)

//        };

//        //Lambda expre to filter people over 30
//        var filteredPeople = people.Where(p => p.Age > 30);
//        //Use lambda exxpre to transform list to include names
//        var names = filteredPeople.Select(p => p.Name);
//        Console.WriteLine("People over 30");
//        foreach ( var name in names)
//        {
//            Console.WriteLine(name);
//        }

//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Dog
//{
//    public string Name { get; set; }
//    public int Age { get; set;}
//}
//class demo
//{
//    static void Main()
//    {
//        List<Dog> dogs = new List<Dog>()
//        {
//            new Dog {Name = "Rex" , Age= 4},
//            new Dog {Name = "Sean" , Age= 0},
//            new Dog {Name = "Nancy" , Age= 3}

//        };

//        var names = dogs.Select(x => x.Name);

//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//        Console.Read();
//    }
//}