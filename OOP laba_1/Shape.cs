using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_laba_1
{

    public abstract class Shape
    {
        protected Color _color;
        protected int _width;

        protected Shape(Color color, int width)
        {
            _color = color;
            _width = width;
        }

        public abstract void Draw(Graphics graphics);
    }



}
