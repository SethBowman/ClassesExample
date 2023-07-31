using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Person
    {
        //Field - a variable inside of a class
        public int money;
        public string clothes;

        //Properties 
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public string HairColor { get; set; }

        //Constructor

        //Default Constructor
        public Person()
        {

        }

        //Custom constructor
        public Person(string name, int age, bool isMarried, string hairColor)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
            HairColor = hairColor;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methods in a class (non static)
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

    }
}
