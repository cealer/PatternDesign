using Pattern.Structural.Attacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Behaviur
{
    public class Attack : ICharacterAction
    {

        private readonly INormalAttack _attack;

        public Attack(INormalAttack attack)
        {
            _attack = attack;
        }

        public void Execute(ICharacter character)
        {
            character.DamageReceive(_attack.Damage());
        }

    }
}
