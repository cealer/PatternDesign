using Pattern.Structural;
using Pattern.Structural.Attacks;
using Pattern.Structural.Attacks.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.structural
{
    public class Villain : Person, ICharacter, IAttacker
    {
        public string VillainName { get; set; }

        public ICollection<INormalAttack> Attacks { get; set; }
        public ISpecialPower SpecialAttack { get; set; }

        public Villain(string name, string lastName, string villainName) : base(name, lastName)
        {
            VillainName = villainName;
            Attacks = new HashSet<INormalAttack>();
            Attacks.Add(new BasicAttack());
        }

        public void Message()
        {
            Console.WriteLine($"Hi, I'm a Villain and my name is {VillainName}");
        }
    }
}
