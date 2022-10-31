using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenProject
{
	internal class Ghost: Monster
	{
		public Ghost(string aName): base(aName)
		{

		}

		// Methods
		public override string scare()
		{
			string msg = "";
			msg += base.scare();
			msg += "\n     .-.\r\n   .'   `.\r\n   :g g   :\r\n   : o    `.\r\n  :         ``.\r\n :             `.\r\n:  :         .   `.\r\n:   :          ` . `.\r\n `.. :            `. ``;\r\n    `:;             `:'\r\n       :              `.\r\n        `.              `.     .\r\n          `'`'`'`---..,___`;.-'\n\n";
			return msg;
		}
	}
}
