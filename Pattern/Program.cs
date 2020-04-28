using Pattern.Behaviur;
using Pattern.Builder;
using Pattern.Creational;
using Pattern.Structural.Attacks;
using Pattern.Structural.Attacks.Powers;
using Pattern.Structural.Attacks.Type.Water;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var aldeano = FactoryCharacter.CreateNonAttackers("Aldeano 1", "aldea", CharacterType.Villager);

            var hero = FactoryCharacter.CreateAttackers("Cesar", "Gonzales", CharacterType.Hero, "CealeR");

            var villain = FactoryCharacter.CreateAttackers("Erick", "Gonzales", CharacterType.Villain, "Orejon");

            BuilderPowers.AddPowers(hero, new List<INormalAttack> { new Flame(), new Burn() }, new FireBomb());

            BuilderPowers.AddPowers(villain, new List<INormalAttack> { new Burble() }, new Waterfall());

            new AttackInterface(villain).NormalAttack(hero.Attacks.ToList()[1]);
            new AttackInterface(villain).SpecialAttack(hero.SpecialAttack);

            new AttackInterface(hero).NormalAttack(villain.Attacks.ToList()[1]);

            new AttackInterface(aldeano).SpecialAttack(villain.SpecialAttack);
            new AttackInterface(aldeano).NormalAttack(villain.Attacks.ToList()[0]);

            foreach (var item in hero.Attacks)
            {
                Console.WriteLine(item.GetType());
            }

            Console.WriteLine($"Villain HP: {villain.CurrentHP()}");
            Console.WriteLine($"Hero HP: {hero.CurrentHP()}");
            Console.WriteLine($"Villager HP: {aldeano.CurrentHP()}");

            Console.ReadLine();
        }

    }
}
