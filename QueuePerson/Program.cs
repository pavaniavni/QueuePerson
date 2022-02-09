using System;
using System.Collections;

public class QueuePerson
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();

        int total = 3;
        for (int i = 0; i < total; i++)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            q.Enqueue(new Person()
            {
                Name = name,
                Age = age
            });
        }

        foreach (Person p in q)
        {
            Console.WriteLine(p.ToString());
        }

        Console.ReadLine();
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
