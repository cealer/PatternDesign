using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural.Attacks
{
    public interface ICharacter
    {
        void DamageReceive(int damage);
        int CurrentHP();
        void Walk();
    }
}
