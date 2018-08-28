using System;

namespace DesignPatterns.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        int IRectangle.Width => this.width;
        int IRectangle.Height => this.height;

        private int width;
        private int height;

        public SquareToRectangleAdapter(Square square)
        {
            this.width = square.Side;
            this.height = square.Side;
        }
    }    
}