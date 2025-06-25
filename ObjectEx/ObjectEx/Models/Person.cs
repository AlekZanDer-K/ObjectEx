namespace ObjectEx.Models;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    public static bool operator ==(Person a, Person b)
    {
        if (a.Name == b.Name && a.Age == b.Age)
        {
            return true;
        }

        return false;
    }

    public static bool operator !=(Person a, Person b)
    {
        if (a.Name != b.Name || a.Age != b.Age)
        {
            return true;
        }

        return false;
    }

    public static bool operator <(Person a, Person b)
    {
        if (a is null || b is null)
        {
            return false;
        }

        if (a.Age < b.Age)
        {
            return true;
        }

        return false;
    }

    public static bool operator >(Person a, Person b)
    {
        if (a is null || b is null)
        {
            return false;
        }

        if (a.Age > b.Age)
        {
            return true;
        }

        return false;
    }

    public static void GetResultOfOperation(Person a, Person b)
    {
        if (a is null || b is null)
        {
            Console.WriteLine("Невозможно провести сравнение с пустым полем данных.");
        }
        else
        {
            Console.WriteLine($"Проведем проверку следующих объектов:\t{a}\t{b}");
            Console.WriteLine("Сравнение возраста:");
            if (a.Name == b.Name)
            {
                Console.WriteLine($"{a.Name} ровесник {b.Name}");
            }
            else
            {
                Console.WriteLine(a < b ? $"{a.Name} младше чем {b.Name}" : $"{a.Name} старше чем {b.Name}");
            }

            Console.WriteLine("\nПроверка на полное совпадение имени и возраста (==):");
            Console.WriteLine(a == b ? "Имя и возраст совпадают" : $"Нет полного совпадения");

            Console.WriteLine("\nПроверка на полное совпадение имени и возраста (Equals):");
            Console.WriteLine(a.Equals(b) ? "Имя и возраст совпадают" : $"Нет полного совпадения");

            Console.WriteLine("\nХеш-коды сравниваемых объектов");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(new string('-', 50));
        }
    }
}
