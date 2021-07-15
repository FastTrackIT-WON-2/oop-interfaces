namespace OopInterfaces
{
    public class SomeOtherObjectWithArea : IObjectWithArea
    {
        public SomeOtherObjectWithArea(double area)
        {
            this.Area = area;
        }

        public double Area
        {
            get;
        }

        public double GetArea()
        {
            return this.Area;
        }
    }
}
