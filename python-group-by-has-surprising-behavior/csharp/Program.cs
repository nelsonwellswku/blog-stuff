namespace Octogami.GroupByDemo;

public class Person
{
    public int CoupleId { get; set; }
    public string? Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Person> friends = [
            new Person {CoupleId = 3, Name = "John"},
            new Person {CoupleId = 1, Name = "Thomas"},
            new Person {CoupleId = 2, Name = "Eugene"},
            new Person {CoupleId = 2, Name = "Beatrice"},
            new Person {CoupleId = 1, Name = "Imani"},
            new Person {CoupleId = 3, Name = "Mary"}
        ];

        var grouped_friends = friends.GroupBy(x => x.CoupleId);
        foreach (var group in grouped_friends)
        {
            var coupleId = group.Key;
            var names = string.Join(" loves ", group.Select(x => x.Name));
            Console.WriteLine($"{coupleId} --> {names}");
        }
    }
}
