using System;
using System.Numerics;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            RoadTransformer transformer1 = new RoadTransformer("Optimus Prime", WeaponType.Riffle, TransformerType.Autobot);
            RoadTransformer transformer2 = new RoadTransformer("Optimus Prime", WeaponType.Riffle, TransformerType.Autobot);
            RoadTransformer transformer3 = new RoadTransformer("Bumble Bee", WeaponType.Blaster, TransformerType.Autobot);

            Console.WriteLine(transformer1.Equals(transformer3));
        }
    }
}
