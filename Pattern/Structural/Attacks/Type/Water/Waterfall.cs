using Pattern.structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural.Attacks.Powers
{
    public class Waterfall : IWaterType, ISpecialPower
    {
        public int Damage()
        {
            return 50;
        }
    }
}
