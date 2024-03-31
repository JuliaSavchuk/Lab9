namespace Lab9
{
    public struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Додавання комплексних чисел
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        // Віднімання комплексних чисел
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        // Множення комплексних чисел
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            // (a + bi) * (c + di) = (ac - bd) + (ad + bc)i
            double real = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
            double imaginary = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);
            return new ComplexNumber(real, imaginary);
        }

        // Ділення комплексних чисел
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            // (a + bi) / (c + di) = [(ac + bd) / (c^2 + d^2)] + [(bc - ad) / (c^2 + d^2)]i
            double denominator = (b.Real * b.Real) + (b.Imaginary * b.Imaginary);
            double real = ((a.Real * b.Real) + (a.Imaginary * b.Imaginary)) / denominator;
            double imaginary = ((a.Imaginary * b.Real) - (a.Real * b.Imaginary)) / denominator;
            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
