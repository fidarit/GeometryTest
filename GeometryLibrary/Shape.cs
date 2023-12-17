namespace GeometryLibrary
{
    public abstract class Shape
    {
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Вычислить периметр фигуры
        /// </summary>
        public abstract double GetPerimeter();
    }
}
