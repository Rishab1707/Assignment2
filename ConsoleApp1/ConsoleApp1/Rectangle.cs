using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Rectangle
    {
        public int length;
        public int width;

        public Rectangle()
        {
            width = 1;
            length = 1;
        }
        public Rectangle(int _length, int _width)
        {
            length = _length;
            width = _width;
        }

        public int GetWidth()
        {
            return width;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int _length)
        {
            if (length > 0)
            {
                length = _length;
                return length;
            }
            else return -1;
        }
        public int SetWidth(int _width)
        {
            if (width > 0)
            {
                width = _width;
                return width;
            }
            else return -1;
        }
        public int GetPerimeter()
        {
            return (2 * width + 2 * length);
        }
        public int GetArea()
        {
            return (width * length);
        }

    }
}
