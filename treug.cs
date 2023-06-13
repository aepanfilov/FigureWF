namespace FiguresWF
{
    ///прямоугольник++
    internal class triangle : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public triangle()
        {
            Length = Width = 0;
        }

        public triangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Square()
        {
            return Length * Width * 0.5;
        }

        public override string ToString()
        {
            return string.Format("Треугольник (ОхВ = {0}x{1})", Length, Width);
        }
    }
}
