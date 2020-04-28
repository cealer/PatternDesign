using Pattern.Structural.Attacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Creational
{
    public static class BuilderPowers
    {
        public static void AddPowers(IAttacker character, ICollection<INormalAttack> attacks, ISpecialPower specialPower)
        {
            foreach (var attack in attacks)
            {
                character.Attacks.Add(attack);
            }

            character.SpecialAttack = specialPower;
        }
    }
}
