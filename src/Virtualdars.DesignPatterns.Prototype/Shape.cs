using System.Text.Json;

namespace Virtualdars.DesignPatterns.Prototype
{
    public abstract class Shape<T> : ICloneable
    {
        public Shape()
        {
            Style = new Style();
            Position = new Coordinate();
        }
        public Shape(Style style, Coordinate position)
        {
            Style = style;
            Position = position;
        }

        public abstract string Name { get; }
        public int Id { get; set; }
        public Coordinate Position { get; set; }
        public Style Style { get; set; }
        public abstract double Perimeter { get; }
        public abstract double Area { get; }

        /// <summary>
        /// Returns shallow copy of this object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Returns deep copy of this object
        /// </summary>
        /// <returns></returns>
        public T DeepCopy()
        {
            var strCopy = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<T>(strCopy);
        }

        public abstract void Draw();

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Style
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public string Color { get; set; }
        public double Radius { get; set; }
    }
}
