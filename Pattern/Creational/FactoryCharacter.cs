using Pattern.Builder;
using Pattern.structural;
using Pattern.Structural;
using Pattern.Structural.Attacks;

namespace Pattern.Creational
{
    public static class FactoryCharacter
    {
        public static IAttacker CreateAttackers(string name, string lastName, CharacterType type, string nick)
        {
            switch (type)
            {
                case CharacterType.Hero:
                    return new SuperHero(name, lastName, nick);
                case CharacterType.Villain:
                    return new Villain(name, lastName, nick);
            }

            return null;

        }

        public static ICharacter CreateNonAttackers(string name, string lastName, CharacterType type)
        {
            switch (type)
            {
                case CharacterType.Villager:
                    return new Villager(name, lastName);
            }

            return null;

        }

    }
}
