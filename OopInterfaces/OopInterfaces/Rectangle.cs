namespace OopInterfaces
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, double width, double height)
            : base(new[]
            {
                topLeft ?? new Point(0, 0), 
                new Point(topLeft?.X ?? 0 + width, topLeft?.Y ?? 0), // topRight
                new Point(topLeft?.X ?? 0 + width, topLeft?.Y ?? 0 + height), // bottomRight
                new Point(topLeft?.X ?? 0, topLeft?.Y ?? 0 + height) // bottomLeft
            })
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get;
        }

        public double Height
        {
            get;
        }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }
    }
}
