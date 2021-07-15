using System;

namespace OopInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            SomeOtherObjectWithArea obj = new SomeOtherObjectWithArea(350);

            double totalArea = GeometryUtils.CalculateTotalArea(new IObjectWithArea[] { rectangle, obj });

            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}
