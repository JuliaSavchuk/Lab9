namespace Lab9
{
    struct Fraction
    {
        public int Numerator;
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int commonDenominator = a.Denominator * b.Denominator;
            int sumNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            return Simplify(new Fraction(sumNumerator, commonDenominator));
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int commonDenominator = a.Denominator * b.Denominator;
            int diffNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            return Simplify(new Fraction(diffNumerator, commonDenominator));
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        private static int FindGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static Fraction Simplify(Fraction fraction)
        {
            int gcd = FindGreatestCommonDivisor(fraction.Numerator, fraction.Denominator);
            fraction.Numerator /= gcd;
            fraction.Denominator /= gcd;
            return fraction;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
