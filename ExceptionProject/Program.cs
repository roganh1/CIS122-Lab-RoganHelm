using ExceptionProject;

int id = -1;
string firstName = "n/a";
string lastName = "n/a";
Person[] anArrayOfPeople = new Person[4];
Person aNullPerson = null;

Person aPerson;
int index = 0;

try
{
    while (index < 4)
    {
        Console.WriteLine("Please enter an ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Please enter a first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Please enter a last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine();

        aPerson = new Person(id, firstName, lastName);

        anArrayOfPeople[index] = aPerson;

        index = index + 1;
    }
    foreach (var p in anArrayOfPeople)
    {
        Console.WriteLine(p.ToString());
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Catch FormatException");
}
catch(NullReferenceException ex)
{
    Console.WriteLine("Catch NullReferenceException");
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Catch IndexOutOfRangeException");
}
