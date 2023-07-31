using ClassesExample;

//Instance of the Classroom class so we can use the list it holds as a property
var classroom = new Classroom();

//Instance of a class (use the class to make a person)

Person seth = new Person();

//Dot notation to fill the properties
seth.Name = "Seth";
seth.Age = 29;
seth.IsMarried = true;
seth.HairColor = "Brown";

//Adding to the list
classroom.OurClass.Add(seth);

//Object initializer syntax
var john = new Person() 
{ 
    Name = "John",
    Age = 31,
    IsMarried = false,
    HairColor = "blonde" 
};

//Adding to the list
classroom.OurClass.Add(john);

//Custom constructor
var ross = new Person("Ross", 34, true, "brown");

//Adding to the list
classroom.OurClass.Add(ross);

//Since all the instances are now in our list and the GetDetails method calls the Greet method from Person
//we will now see every single person's greeting

classroom.GetDetails();


//If you wanted to remove something from the list
//classroom.OurClass.Remove(ross);