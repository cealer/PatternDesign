using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural.Attacks
{
    public interface IAttacker : ICharacter
    {
        ICollection<INormalAttack> Attacks { get; set; }
        ISpecialPower SpecialAttack { get; set; }
    }
}
