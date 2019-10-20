using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_外观模式.Example_1
{
    class ShapeMarker_图形超市
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;
        public ShapeMarker_图形超市() => (circle, rectangle, square) = (new Circle(), new Rectangle(), new Square());
        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
