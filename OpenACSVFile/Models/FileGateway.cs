// Written by Rogan Helm
// 10/12/22

using System.IO;

namespace OpenACSVFile.Models
{
    public class FileGateway
    {
        public List<Person> GetPeople(string aPath)
        {
            // Path includes filename
            List<Person> aListOfPeople = new List<Person>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Person aPerson;
            try
            {
                allRows = File.ReadAllLines(aPath);
                while (index < allRows.Length)
                {
                    aRow = allRows[index].Split(',');
                    aPerson = new Person(Convert.ToInt32(aRow[0]), aRow[1], aRow[2]);
                    aListOfPeople.Add(aPerson);
                    index++;
                }
            }
            catch ()
            {
                Console.WriteLine("aaaaaaaaaaaa");
            }
            return aListOfPeople;
        }
    }
}
