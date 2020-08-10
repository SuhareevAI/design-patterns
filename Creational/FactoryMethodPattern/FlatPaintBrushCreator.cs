using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern
{
    class FlatPaintBrushCreator : PaintBrushCreator
    {
        public override IPaintBrush Create()
        {
            return new FlatPaintBrush();
        }
    }
}