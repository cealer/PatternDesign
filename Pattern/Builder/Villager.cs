using Pattern.Structural.Attacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Structural
{
    public class Villager : Person, ICharacter
    {
        public Villager(string name, string lastName) : base(name, lastName)
        {
        }

        public void Message()
        {
            Console.WriteLine($"Hi, I'm a Villager and my name is {FullName}");
        }
    }
}
