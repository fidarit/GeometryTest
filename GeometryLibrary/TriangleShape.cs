namespace GeometryLibrary
{
    public class TriangleShape : Shape
    {
        public readonly double a;
        public readonly double b;
        public readonly double c;

        /// <summary>
        /// Создание треугольника по трем сторонам
        /// </summary>
        /// <exception cref="ArgumentException">Генерируется, если переданы некорректные значения сторон</exception>
        public TriangleShape(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Некорректные значения сторон треугольника.");
            }

            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public override double GetArea()
        {
            // Используем формулу Герона
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle(double eps = double.Epsilon)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            // Используем теорему Пифагора
            double left = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
            double right = Math.Pow(sides[2], 2);

            return Math.Abs(left - right) <= eps;
        }

        /// <summary>
        /// Проверка, что переданные значения образуют действительный треугольник
        /// </summary>
        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
