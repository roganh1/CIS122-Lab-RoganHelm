using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Beagle : IFly
    {
        private IFly flyingMethod = new DropsLikeAStone();
        public IFly FlyingMethod
        {
            get { return this.flyingMethod; }
            set { this.flyingMethod = value; }
        }
        public Beagle()
        {
            // Empty
        }
        public Beagle(IFly aFlyingMethod)
        {
            this.FlyingMethod = aFlyingMethod;
        }
        public string Fly()
        {
            return FlyingMethod.Fly();
        }
    }
}
