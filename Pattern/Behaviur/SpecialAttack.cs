using Pattern.Structural.Attacks;

namespace Pattern.Behaviur
{
    public class SpecialAttack : ICharacterAction
    {
        private readonly ISpecialPower _specialPower;

        public SpecialAttack(ISpecialPower specialPower)
        {
            _specialPower = specialPower;
        }

        public void Execute(ICharacter character)
        {
            character.DamageReceive(_specialPower.Damage());
        }

    }
}
