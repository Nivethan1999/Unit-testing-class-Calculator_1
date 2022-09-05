namespace CalculatorClass
{
    public class Calculator
    {
        public double Accumulator { get; set; }
        
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double a)
        {
            Accumulator = Accumulator + a;
            return Accumulator;
        }
        
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Subtract(double a)
        {
            Accumulator = Accumulator - a;
            return Accumulator;
        }
        
        
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        
        public double Multiply(double a)
        {
            Accumulator = Accumulator * a;
            return Accumulator;
        }
        
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }
        
        public  double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = dividend / divisor;
            return Accumulator;
        }
        
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}