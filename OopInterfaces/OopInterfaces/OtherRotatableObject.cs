using System;

namespace OopInterfaces
{
    public class OtherRotatableObject : IRotatableObject
    {
        public void Rotate(double angleDegrees)
        {
            Console.WriteLine($"Hey, look! I am rotating with an angle of {angleDegrees} degrees");
        }
    }
}
