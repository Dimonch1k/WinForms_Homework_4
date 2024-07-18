using System;

namespace Task5
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Numerator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Divide(Fraction f1, Fraction f2)
        {
            if (f2.Numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
