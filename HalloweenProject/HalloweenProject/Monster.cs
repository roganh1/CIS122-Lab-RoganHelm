// Written by Madeline Ellingson
// 10/24/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Monster
	{
		// Class variables
		private int numPplScared = -1;
		private string name = "";

		// Gets/Sets
		public int NumPplScared 
		{ 
			get { return this.numPplScared; } 
			set { this.numPplScared = value; }
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		// Constructors
		public Monster()
		{

		}

		public Monster(string aName): this(-1, aName)
		{

		}

		public Monster(int aNumOfPplScared, string aName)
		{
			this.NumPplScared = numPplScared;
			this.Name = aName;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += "People Scared: " + this.NumPplScared + "\n"
				+ "Name: " + this.Name + "\n";
			return msg;
		}

		public virtual string scare()
		{
			Random random = new Random();
			int pplScared = random.Next(20);

			this.NumPplScared += pplScared;

			return this.Name + " scared " + pplScared +" people!\n";
		}
	}
}
