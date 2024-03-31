namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");
            Fraction frac1 = new Fraction(1, 2);
            Fraction frac2 = new Fraction(3, 4);

            Fraction sum = frac1 + frac2;
            Console.WriteLine($"Sum: {sum}");

            Fraction difference = frac1 - frac2;
            Console.WriteLine($"Difference: {difference}");

            Fraction product = frac1 * frac2;
            Console.WriteLine($"Product: {product}");

            Fraction quotient = frac1 / frac2;
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine("\n________________\n");


            Console.WriteLine("\n_____Task 2_____\n");
            ComplexNumber a = new ComplexNumber(3, 2);
            ComplexNumber b = new ComplexNumber(1, 4);

            ComplexNumber suma = a + b;
            Console.WriteLine($"Sum: {suma}");

            ComplexNumber differenc = a - b;
            Console.WriteLine($"Difference: {differenc}");

            ComplexNumber produc = a * b;
            Console.WriteLine($"Product: {produc}");

            ComplexNumber quotien = a / b;
            Console.WriteLine($"Quotient: {quotien}");
            Console.WriteLine("\n________________\n");



            Console.WriteLine("\n_____Task 3_____\n");
            Birthday birthday = new Birthday(1, 4, 2000);
            birthday.ShowBirthday();

            Console.WriteLine($"Day of week of birth: {birthday.DayOfWeekOfBirth()}");
            Console.WriteLine($"Day of week of birthday in 2025: {birthday.DayOfWeekInYear(2025)}");
            Console.WriteLine($"Days until birthday: {birthday.DaysUntilBirthday()}");

            Console.WriteLine("\n________________\n");
        }
    }
}