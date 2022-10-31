// Written by Madeline Ellingson
// 10/24/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Skeleton: Monster
	{
		public Skeleton(string aName) : base(aName)
		{

		}

		// Methods
		public override string scare()
		{
			string msg = "";
			msg += base.scare();
			msg += "\n      .-.\r\n     (o.o)\r\n      |=|\r\n     __|__\r\n   //.=|=.\\\\\r\n  // .=|=. \\\\\r\n  \\\\ .=|=. //\r\n   \\\\(_=_)//\r\n    (:| |:)\r\n     || ||\r\n     () ()\r\n     || ||\r\n     || ||\r\n    ==' '==\n\n";
			return msg;
		}
	}
}
