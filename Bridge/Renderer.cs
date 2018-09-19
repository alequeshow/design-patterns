using System;

namespace DesignPatterns.Bridge
{
    //You are given an example of an inheritance hierarchy which results in Cartesian-product duplication.
    //Please refactor this hierarchy, giving the base class Shape a constructor that takes an interface IRenderer
    //and well as VectorRenderer and RasterRenderer classes.
    //Each implementer of the Shape abstract class should have a constructor that takes an IRenderer such that, 
    //subsequently, each constructed object's ToString() operates correctly, for example:
    //new Triangle(new RasterRenderer()).ToString() // returns "Drawing Triangle as pixels"
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs { get => "Drawing {0} as lines"; }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs { get => "Drawing {0} as pixels"; }
    }
}