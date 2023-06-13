namespace FiguresWF
{
	///прямоугольник++
    internal class Rect : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rect()
        {
            Length = Width = 0;
        }

        public Rect(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Square()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return string.Format("Прямоугольник (ДхШ = {0}x{1})", Length, Width);
        }
    }
}
