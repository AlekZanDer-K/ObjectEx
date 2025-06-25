using ObjectEx.Models;

namespace ObjectEx;

internal class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person { Name = "Дмитрий", Age = 41 };
        var person2 = new Person { Name = "Владимир", Age = 33 };
        var person3 = new Person { Name = "Дмитрий", Age = 41 };
        var person4 = new Person { Name = "Ольга", Age = 27 };

        Person.GetResultOfOperation(person1, person2);
        Person.GetResultOfOperation(person1, person3);
        Person.GetResultOfOperation(person4, person2);
        Person.GetResultOfOperation(person4, null);
    }
}
