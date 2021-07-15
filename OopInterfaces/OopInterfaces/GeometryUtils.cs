namespace OopInterfaces
{
    public static class GeometryUtils
    {
        public static double CalculateTotalArea(IObjectWithArea[] objects)
        {
            double area = 0;
            foreach (IObjectWithArea o in objects)
            {
                area += o.GetArea();
            }

            return area;
        }
    }
}
