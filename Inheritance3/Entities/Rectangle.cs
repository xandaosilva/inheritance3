﻿using Inheritance3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance3.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
