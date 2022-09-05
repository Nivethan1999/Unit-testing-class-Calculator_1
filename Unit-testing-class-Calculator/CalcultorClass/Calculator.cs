namespace CalcultorClass
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator =  Math.Pow(x, exp);
            return Accumulator;
            
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;


        }

        public double Subtract(double subtractor)
        {
            Accumulator = subtractor - Accumulator;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = multiplier * Accumulator;
            return Accumulator;

        }

        public double Accumulator { get; private set; }



    }
}