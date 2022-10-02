using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualdars.DesignPatterns.Prototype
{
    public class Rectangle : Shape<Rectangle>
    {
        public override string Name => "To'rtburchak";

        public override double Perimeter => 2 * (Style.Width + Style.Height);

        public override double Area => Style.Width * Style.Height;

        public double Diagonal => Math.Sqrt(Math.Pow(Style.Width, 2) + Math.Pow(Style.Height, 2));

        public override void Draw()
        {
            Console.WriteLine($"{Name} chizilmoqda. Diagonal: {Diagonal}");
        }
    }
}
