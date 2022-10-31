using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Zombie: Monster
	{
		public Zombie(string aName) : base(aName)
		{

		}

		// Methods
		public override string scare()
		{
			string msg = "";
			msg += base.scare();
			msg += "\n[¬º-°]¬\n";
			return msg;
		}
	}
}
