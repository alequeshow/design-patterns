using System;

namespace DesignPatterns.Bridge
{
    public abstract class Shape
    {
        IRenderer Renderer;

        public Shape(IRenderer renderer)
        {
            if (renderer == null)
                throw new NullReferenceException("renderer");

            Renderer = renderer;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format(Renderer.WhatToRenderAs, Name);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {         
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }
}
