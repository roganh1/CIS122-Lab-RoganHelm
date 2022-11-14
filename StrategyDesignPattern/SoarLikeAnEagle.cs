using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SoarLikeAnEagle : IFly
    {
        // This class isn't a standalone class
        public string Fly()
        {
            // Note this class has no idea where it'll be injected
            return "This flies like an eagle";
        }
    }
}
