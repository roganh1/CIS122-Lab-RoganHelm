using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Pumpkin: Monster
	{
		public Pumpkin(string aName) : base(aName)
		{

		}

		// Methods
		public override string scare()
		{
			string msg = "";
			msg += base.scare();
			msg += "\n                                 ////\r\n                                ////\r\n                               ////\r\n                      *********************\r\n                   ***************************\r\n                 ******** ************* ********\r\n                ********   ***********   ********\r\n               ********     *********     ********\r\n              *************************************\r\n              *************************************\r\n              *************************************\r\n               ******     ***       ***     ******\r\n                ******    ***  ***  ***    ******\r\n                 ******        ***        ******\r\n                   ***************************\r\n                      *********************\n";
			return msg;
		}

		public string concatinate(string aString1, string aString2)
		{
			return aString1 + aString2;
		}

	}
}
