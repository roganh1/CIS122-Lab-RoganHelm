using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class FliesWithAJetpack : IFly
    {
        public string Fly()
        {
            return "Flies with a jetpack";
        }
    }
}
