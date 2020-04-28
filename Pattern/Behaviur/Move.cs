using Pattern.Structural.Attacks;

namespace Pattern.Behaviur
{
    public class Move : ICharacterAction
    {
        public void Execute(ICharacter character)
        {
            character.Walk();
        }
    }
}
