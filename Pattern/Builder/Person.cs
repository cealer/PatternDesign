using Pattern.structural;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HP { get; set; }

        public string FullName => $"{LastName} {Name}";

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            HP = 100;
        }

        public virtual void Walk()
        {
            Console.WriteLine("Walking");
        }

        public void DamageReceive(int damage) => HP -= damage;

        public int CurrentHP() => HP;

    }
}
