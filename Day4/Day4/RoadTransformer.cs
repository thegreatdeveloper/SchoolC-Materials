using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class RoadTransformer : Transformer
    {
        public RoadTransformer(string name, WeaponType weapon, TransformerType type) : base(name, weapon ,type)
        {
        }

        public override void Go()
        {
            Console.WriteLine("Riding");
        }
    }
}
