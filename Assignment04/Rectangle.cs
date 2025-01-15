using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Rectangle
    {
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Constructors
        // Parameterless constructor that sets width and height to 0
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        // Constructor that accepts width and height as integers
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Constructor that accepts a single integer and sets both width and height to that value
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
        #endregion

        #region Method
        public void DisplayRectangle()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
        #endregion
    }
}
