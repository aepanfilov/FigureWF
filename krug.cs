namespace FiguresWF
{
    ///прямоугольник++
    internal class circle : Figure
    {
        public double Length { get; set; }
        public double pi = 3.14; 

        public circle()
        {
            Length = 0;
            
        }

        public circle(double length)
        {
            Length = length;
           
        }

        public override double Square()
        {
            return 2 * Length * pi ;
        }

        public override string ToString()
        {
            return string.Format("круг (РхПИх2 = {0}x{1}х2)", Length, pi);
        }
    }
}
