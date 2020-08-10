using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern
{
    public class FilbertPaintBrushCreator : PaintBrushCreator
    {
        public override IPaintBrush Create()
        {
            return new FilbertPaintBrush();
        }
    }
}
