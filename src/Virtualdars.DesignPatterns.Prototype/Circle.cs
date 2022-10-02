using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Virtualdars.DesignPatterns.Prototype
{
    public class Circle : Shape<Circle>
    {
        public override string Name => "Doira";

        public override double Perimeter => 2 * Math.PI * Style.Radius;

        public override double Area => Math.PI * Math.Pow(Style.Radius, 2);

        public double Diameter => Style.Radius * 2;

        public override void Draw()
        {
            Console.WriteLine($"{Name} chizilmoqda. Diameter: {Diameter}");
        }

    }
}
