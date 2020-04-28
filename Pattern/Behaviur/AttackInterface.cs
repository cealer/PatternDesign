using Pattern.Structural.Attacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Behaviur
{
    /// <summary>
    /// Strategy pattern
    /// </summary>
    public class AttackInterface
    {
        private readonly ICharacter _characterTo;
        private ICharacterAction _characterAction;

        public AttackInterface(ICharacter characterTo)
        {
            _characterTo = characterTo;
        }

        public void NormalAttack(INormalAttack normalAttack)
        {
            _characterAction = new Attack(normalAttack);
            _characterAction.Execute(_characterTo);
        }

        public void SpecialAttack(ISpecialPower specialPower)
        {
            _characterAction = new SpecialAttack(specialPower);
            _characterAction.Execute(_characterTo);
        }

    }
}
