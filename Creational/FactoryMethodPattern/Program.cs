using FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PaintBrushCreator> paintBrushCreators = new List<PaintBrushCreator>()
            {
                new FilbertPaintBrushCreator(),
                new FlatPaintBrushCreator()
            };

            foreach (var creator in paintBrushCreators)
            {
                IPaintBrush paintBrush = creator.Create();

                paintBrush.Draw();
            }

            Console.ReadKey();
        }
    }
}