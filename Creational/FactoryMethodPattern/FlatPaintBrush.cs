using FactoryMethodPattern.Abstract;
using System;

namespace FactoryMethodPattern
{
    public class FlatPaintBrush : IPaintBrush
    {
        public void Draw()
        {
            Console.WriteLine("Draw with flat paint brush");
        }
    }
}
