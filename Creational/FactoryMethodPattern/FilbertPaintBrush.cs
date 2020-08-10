using FactoryMethodPattern.Abstract;
using System;

namespace FactoryMethodPattern
{
    public class FilbertPaintBrush : IPaintBrush
    {
        public void Draw()
        {
            Console.WriteLine("Draw with filbert paint brush");
        }
    }
}
