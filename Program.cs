using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person("Hans", 20);
            Console.WriteLine("Hello {0}{1} {2}", person1.name, person1.age, "The End!");
            
            Person person2 = person1;
            person2.name = "Holly";
            person2.age = 18;
            Console.WriteLine("And hello to " + person2.name + person2.age + "Type a cool name");

            String text = Console.ReadLine();
            Console.WriteLine(text + " is the best!");
        }
    }
}
