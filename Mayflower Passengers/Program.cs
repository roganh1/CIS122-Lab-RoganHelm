// Written by Rogan Helm
// 11/15/22
using Mayflower_Passengers;

FileGateway aGateway = new FileGateway();
List<Person> aNewListOfPeople = new List<Person>();

aNewListOfPeople = aGateway.GetPeople("C:\\Users\\wacky\\Documents\\Mayflower_Passengers.csv");

int i = 0;
while(i < aNewListOfPeople.Count)
{
    Console.WriteLine(aNewListOfPeople[i]);
    i++;
}
