// Written by Madeline Ellingson
// 10/24/2022

// Exceptions
// ----------
// 1. Format Exception
// 2. NullReferenceException
// 3. IndexOurOfRangeException
// 4. NotImplementedException
// 5. DivideByZeroException
// 6. OverflowException
// 7. FileNotFoundException

// DO NOT PRINT OUT EXCEPTIONS!!!!!!!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Program
	{
		public class StringManipulator
		{
			static void Main(string[] args)
			{
				Monster aMonster = new Monster("Bob");
				Console.WriteLine(aMonster.scare());

				Ghost aGhost2 = null;
				Console.WriteLine(aGhost2.scare());

				Ghost aGhost = new Ghost("Casper");
				Console.WriteLine(aGhost.scare());

				Skeleton aSkeleton = new Skeleton("Scully");
				Console.WriteLine(aSkeleton.scare());

				Zombie aZombie = new Zombie("Bart");
				Console.WriteLine(aZombie.scare());

				Pumpkin aPumpkin = new Pumpkin("Jim");
				Console.WriteLine(aPumpkin.scare());

				List<int> aList = new List<int>() { 1, 2, 3, 4 };

				for (int i = 0; i <= aList.Count; i++)
				{
					Console.WriteLine(aList[i]);
				}

				Console.ReadLine();
			}
		}
	}
}
