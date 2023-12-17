namespace GeometryLibrary
{
    public class CircleShape : Shape
    {
        public readonly double Radius;

        /// <summary>
        /// Создание окружности по радиусу
        /// </summary>
        /// <exception cref="ArgumentException">Генерируется, если передан отрицательный радиус</exception>
        public CircleShape(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }

            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
