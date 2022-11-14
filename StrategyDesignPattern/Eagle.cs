using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Eagle : IFly
    {
        private IFly flyingMethod = new SoarLikeAnEagle();
        public IFly FlyingMethod
        {
            get { return this.flyingMethod; }
            set { this.flyingMethod = value; }
        }
        public Eagle()
        {
            // Empty
        }
        public Eagle(IFly aFlyingMethod)
        {
            this.FlyingMethod = aFlyingMethod;
        }
        public string Fly()
        {
            return "flies like an eagle";
        }
    }
}
