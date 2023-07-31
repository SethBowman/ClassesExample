using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Classroom
    {
        //Properties can be of type List or Array
        public List<Person> OurClass { get; set; } = new List<Person>();

        //Method in clas (non static)
        public void GetDetails()
        {
            //Looping through every person in our List property called "OurClass"
            foreach(Person person in OurClass)
            {
                //Calling method from Person class using variable called "person"
                //"person" takes the place of every thing in the "OurClass" list when looping through
                person.Greet();
            }
        }
    }
}
