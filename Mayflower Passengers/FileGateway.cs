// Written by Rogan Helm
// 11/15/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayflower_Passengers
{
    public class FileGateway
    {
        private Person aPerson;
        public List<Person> GetPeople(string aPath)
        {
            string[] allLines = File.ReadAllLines(aPath);
            string[] aRow;
            int index = 0;
            List<Person> aListOfPeople = new List<Person>();
            while (index < allLines.Length)
            {
                aPerson = new Person();
                aRow = allLines[index].Split(',');
                aPerson.FirstName = aRow[0];
                aPerson.LastName = aRow[1];
                aListOfPeople.Add(aPerson);
                index++;
            }
            return aListOfPeople;
        }
    }
}
