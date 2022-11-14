using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class FliesLikeABug : IFly
    {
        public string Fly()
        {
            return "bzzzz";
        }
    }
}
