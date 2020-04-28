using Pattern.Structural;
using Pattern.Structural.Attacks;
using Pattern.Structural.Attacks.Type;
using System;
using System.Collections.Generic;

namespace Pattern.structural
{
    public class SuperHero : Person, IAttacker
    {
        public string HeroName { get; set; }

        public ICollection<INormalAttack> Attacks { get; set; }
        public ISpecialPower SpecialAttack { get; set; }

        public SuperHero(string name, string lastName, string heroName) : base(name, lastName)
        {
            HeroName = heroName;
            Attacks = new HashSet<INormalAttack>();
            Attacks.Add(new BasicAttack());
        }


        public ICollection<INormalAttack> GetNormalAttacks() => Attacks;
        public ISpecialPower GetSpecialAttack() => SpecialAttack;

        public void Message()
        {
            Console.WriteLine($"Hi, I'm a Super Hero and my name is {HeroName}");
        }

    }
}
