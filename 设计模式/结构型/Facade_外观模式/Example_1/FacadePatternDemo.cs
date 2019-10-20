using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_外观模式.Example_1
{
    public class FacadePatternDemo
    {
        public static void test()
        {
            ShapeMarker_图形超市 shapeMarker_ = new ShapeMarker_图形超市();
            shapeMarker_.DrawCircle();
            shapeMarker_.DrawRectangle();
            shapeMarker_.DrawSquare();
        }
    }
}
