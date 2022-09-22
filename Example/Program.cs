// See https://aka.ms/new-console-template for more information
using Example;

Console.WriteLine("Hello, World!");

Person aPerson1 = new Person();
Barber aBarber1 = new Barber();
Director aDirector1 = new Director();
Butcher aButcher1 = new Butcher();
Surgeon aSurgeon1 = new Surgeon();

List<ICut> aListOfPeople = new List<ICut>();
aListOfPeople.Add(aPerson1);
aListOfPeople.Add(aBarber1);
aListOfPeople.Add(aDirector1);
aListOfPeople.Add(aButcher1);
aListOfPeople.Add(aSurgeon1);

//This is called polymorphism
foreach(var p in aListOfPeople)
{
    //This method is shared via inheritance
    Console.WriteLine(p.ToString());
    //This method is shared via an interface
    Console.WriteLine(p.Cut() + "\n\n");
}
