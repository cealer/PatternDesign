using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural.Attacks.Type
{
    public class BasicAttack : INormalAttack
    {
        public int Damage()
        {
            return 2;
        }
    }
}
