using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Hummingbird : IFly
    {
        private IFly flyingMethod = new SoarLikeAnEagle();
        public IFly FlyingMethod
        {
            get { return this.flyingMethod; }
            set { this.flyingMethod = value; }
        }
        public Hummingbird()
        {
            // Empty
        }
        public Hummingbird(IFly aFlyingMethod)
        {
            this.FlyingMethod = aFlyingMethod;
        }
        public string Fly()
        {
            return "Flies like a hummingbird";
        }
    }
}
