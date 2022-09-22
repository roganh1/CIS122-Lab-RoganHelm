// See https://aka.ms/new-console-template for more information

using SchoolFall2022;
List<Student> aListOfStudents = new List<Student>();
List<Person> aListOfPeople = new List<Person>();
Stack<Student> aStackOfStudents = new Stack<Student>();
aStackOfStudents.Push(aStudent1);
aStackOfStudents.Push(aStudent2);
//you may not create an abstract class
//Person aPerson1 = new Person();
Professor aProfessor1 = new Professor();
Student aStudent1 = new Student();
Student aStudent2 = new Student("a200", "Anna", "Buch", "202 Hope St", "Mankato", "MN", "56001", 200.00, "123-45-6789");


//aStudent1.StudentId = "a100";
//aStudent1.SocialSecurityNum = "123-45-678";
aStudent1.FirstName = "Anna";
aStudent1.LastName = "Doe";
aStudent1.Address = "101 Hope St";
aStudent1.City = "Mankato";
aStudent1.State = "Minnesota";
aStudent1.ZipCode = "56001";
aStudent1.DiningDollars = -1000.00;

aProfessor.TechId

//Add students to the list
aListOfStudents.Add(aStudent1);
aListOfStudents.Add(aStudent2);

foreach(var s in aListOfPeople)
{
    Console.WriteLine(s.ToString());
    Console.WriteLine(s.AddClass());
    Console.WriteLine("\n\n\n");
}

/*Console.WriteLine("Student ID: " + aStudent1.StudentId);
Console.WriteLine("First Name: " + aStudent1.FirstName);
Console.WriteLine("Last Name: " + aStudent1.LastName);
Console.WriteLine("Address: " + aStudent1.Address);
Console.WriteLine("City: " + aStudent1.City);
Console.WriteLine("State: " + aStudent1.State);
Console.WriteLine("Zip Code: " + aStudent1.ZipCode);
Console.WriteLine("Dining Dollars: " + aStudent1.DiningDollars);
Console.WriteLine("Social Security Number: " + aStudent1.SocialSecurityNum);

//ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine("This is ToString() before we change it: " + aStudent1.ToString());
Console.WriteLine("\n\n\n");
*/

int x = 10;
int y = 20;
int z = 30;

x = x + y;
y = z;
z = x + 10;
y = 20;
y = x;

Console.WriteLine("X: " + x);
Console.WriteLine("Y: " + y);
Console.WriteLine("Z: " + z);

Student aStudent1 = new Student("Anna", "Brown");
Student aStudent2 = new Student("Sam", "Steven");
Student aStudent3 = new Student("Gail", "Evans");

aStudent1 = aStudent2;
aStudent3 = aStudent1;
aStudent3.FirstName = "Natalie";
aStudent2.LastName = "Evans";

string aString1 = "Bob";
string aString2 = "Bob";
//Incorrect string comparison
/*if(aString1 == aString2)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not equal");
}*/
//Correct way to compare strings
if (aString1.Equals(aString2))
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not equal");
}
