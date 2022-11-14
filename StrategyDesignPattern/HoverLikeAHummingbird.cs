using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class HoverLikeAHummingbird : IFly
    {
        public string Fly()
        {
            return "this hovers like a hummingbird";
        }
    }
}
