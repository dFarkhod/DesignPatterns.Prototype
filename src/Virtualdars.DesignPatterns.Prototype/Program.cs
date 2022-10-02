using Virtualdars.DesignPatterns.Prototype;

Circle circle = new();
circle.Id = 1;
circle.Position.X = 3;
circle.Position.Y = 5;
circle.Style.Width = 10;
circle.Style.Height = 20;
circle.Style.Radius = 7;
Console.WriteLine("Circle1 - Nusxa olishdan oldin:");
Console.WriteLine(circle.ToString());
Console.WriteLine();

/*var circle1 = circle.Clone() as Circle;
Console.WriteLine(circle1.ToString());*/

Circle circle2 = circle.DeepCopy();
circle2.Id = 2;
circle2.Position.X = 30;
circle2.Position.Y = 50;
circle2.Style.Width = 15;
circle2.Style.Height = 25;

Console.WriteLine("Circle2:");
Console.WriteLine(circle2.ToString());
Console.WriteLine();
Console.WriteLine("Circle1 - Nusxa olingandan keyin:");
Console.WriteLine(circle.ToString());
Console.WriteLine();


