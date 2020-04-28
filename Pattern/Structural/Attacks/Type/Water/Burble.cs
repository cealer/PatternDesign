using Pattern.structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural.Attacks.Type.Water
{
    public class Burble : IWaterType, INormalAttack
    {
        public int Damage()
        {
            return 10;
        }
    }
}
