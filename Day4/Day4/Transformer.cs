using System;
using System.Collections.Generic;

namespace Day4
{
    enum WeaponType { Gun, Blaster, Riffle}

    enum TransformerType { Decepticon, Autobot }
    abstract class Transformer
    {
        public string Name { get; private set;  }
        public WeaponType Weapon { get; set; }

        public TransformerType Type { get; private set; }

        public Transformer(string name, WeaponType weapon, TransformerType type)
        {
            Name = name;
            Weapon = weapon;
            Type = type;
        }

        public abstract void Go();

        public virtual void Attack()
        {
            Console.WriteLine($"Attacking by {Weapon}");
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != typeof(Transformer))
                return false;

            if (((Transformer)obj).Name != Name)
                return false;

            return true;
        }
    }
}
