namespace FiguresWF
{
    ///прямоугольник++
    internal class trapezoid : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double G { get; set; }

        public trapezoid()
        {
            Length = Width = G = 0;
        }

        public trapezoid(double length, double width, double g)
        {
            Length = length;
            Width = width;
            G = g;
        }

        public override double Square()
        {
            return Length * Width * 0.5 * G;
        }

        public override string ToString()
        {
            return string.Format("Трапеция (БОхМОх0.5хh = {0}x{1}х0.5*{2})", Length, Width, G);
        }
    }
}

