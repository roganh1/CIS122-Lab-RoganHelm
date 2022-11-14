using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class DropsLikeAStone : IFly
    {
        public string Fly()
        {
            return "this drops like a stone";
        }
    }
}
