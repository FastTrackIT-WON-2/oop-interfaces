using System;

namespace OopInterfaces
{
    public class OtherTranslatableObject : ITranslatableObject
    {
        public void Translate(int dx, int dy)
        {
            Console.WriteLine($"Hey, look! I am moving with dx={dx} and dy={dy}");
        }
    }
}
