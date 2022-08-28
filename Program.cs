using System;
using System.IO;
namespace oop
{


    // class Program
    // {

    //     // string name = "Toyota";
    //     // int year = 2022;

    //     // string name;

    //     // class methods
    //     // public void greetings()
    //     // {
    //     //     Console.Write("hekko");
    //     // }


    //     // public string carname;
    //     // public int year;



    //     //example of constructor
    //     // public Program()
    //     // {
    //     //     carname = "Toyota";
    //     // }

    //     //example of constructor with parameters
    //     // public Program(string cars, int years)
    //     // {
    //     //     carname = cars;
    //     //     year = years;
    //     // }


    //     // private string name;

    //     // public string Name
    //     // {
    //     //     get { return name; }
    //     //     set { name = value; }

    //     // }



    //     static void Main(string[] args)
    //     {
    //         //single object
    //         // Program obj = new Program();
    //         // Console.WriteLine($"The car name is {obj.name} and the year i bought this is {obj.year}");

    //         //multiple object
    //         // Program obj1 = new Program();
    //         // Program obj2 = new Program();

    //         // Console.WriteLine(obj1.name);
    //         // Console.WriteLine(obj2.name);

    //         //modifying object they are created
    //         // Program obj1 = new Program();

    //         // obj1.name = "Toyota";
    //         // obj1.year = 2022;

    //         // Console.WriteLine($"The car name is {obj1.name} and the year i bought this is {obj1.year}");

    //         // Program obj2 = new Program();

    //         // obj2.name = "Ford";
    //         // obj2.year = 2021;

    //         // Console.WriteLine($"The car name is {obj2.name} and the year i bought this is {obj2.year}");

    //         // Program obj = new Program("Toyota", 2020);

    //         // //calling class methods
    //         // // obj.greetings();

    //         // Console.WriteLine($"{obj.carname} {obj.year}");

    //         // Program obj = new Program();

    //         // obj.Name = "Joe";

    //         // Console.WriteLine(obj.Name);
    //     }
    // }

    //example of inheritance
    // class Person
    // {
    //     public string name;
    // }

    // class Student : Person
    // {
    //     public string schoolname = "UEP";
    // }

    //polymorphism

    // class Person
    // {
    //     public void gretting()
    //     {
    //         Console.WriteLine("Hello person");
    //     }
    // }

    // class Student : Person
    // {
    //     public void gretting()
    //     {
    //         Console.WriteLine("Hello student");
    //     }
    // }

    // abstract class Person
    // {
    //     public abstract void asking();
    //     public void gretting()
    //     {
    //         Console.WriteLine("Hello person");
    //     }

    // }

    // class Student : Person
    // {
    //     public override void asking()
    //     {
    //         Console.WriteLine("How are you?");
    //     }
    // }


    //example of interface
    interface Iperson
    {
        void asking();
    }

    interface Ichild
    {
        void game();
    }

    class Student : Iperson, Ichild
    {
        public void asking()
        {
            Console.WriteLine("How are you?");

        }

        public void game()
        {
            Console.WriteLine("Hi hello?");

        }
    }

    //enums example
    // enum Tshirt
    // {
    //     small,
    //     medium,
    //     large = 9
    // }




    // class Program
    // {

    //     enum Friend
    //     {
    //         Bestfriend,
    //         Friend,
    //         Schoolmates
    //     }
    //     static void Main(string[] args)
    //     {


    //         // // Person person = new Person();
    //         // Student student = new Student();



    //         // // Console.WriteLine(person.name);
    //         // // Console.WriteLine($"{student.name} {student.schoolname}");


    //         // // person.gretting();
    //         // student.gretting();
    //         // student.asking();
    //         // student.game();

    //         Tshirt tshirt = Tshirt.small;
    //         int tshirts = (int)Tshirt.large;

    //         Console.WriteLine(tshirts);
    //         Console.WriteLine(tshirt);


    //         Friend friend = Friend.Bestfriend;
    //         Console.WriteLine(friend);


    //     }
    // }

    class Program
    {

        static void Main(string[] args)
        {

            //write text
            // string text = "Hello World";
            // File.WriteAllText("txt.txt", text);

            // //read text
            // string readtext = File.ReadAllText("txt.txt");
            // Console.WriteLine(readtext);

            // Console.WriteLine("Enter something:");
            // string text = Console.ReadLine();

            // File.WriteAllText("txt.txt", text);

            Console.WriteLine("Enter something:");
            string text = Console.ReadLine();

            try
            {
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Pls. Complete");

            }



        }
    }
}