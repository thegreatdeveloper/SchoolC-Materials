using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class FlightTransformer : Transformer
    {
        public FlightTransformer(string name, WeaponType weapon, TransformerType type) : base(name, weapon, type)
        {
        }

        public override void Go()
        {
            Console.WriteLine("Flying");
        }
    }
}
