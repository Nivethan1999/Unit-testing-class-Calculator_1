namespace CalculatorClass
{
    public class Calculator
    {
        //Variables
        public double Accumulator { get; private set; }
        
        //Addition
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        
        //Subtraction
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        
        //Multiplication
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        
        public double Multiply(double a)
        {
            Accumulator = a * Accumulator;
            return Accumulator;
        }
        
        //Division
        public double Divide(double a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = Accumulator / a;
            return Accumulator;
        }
 
        //Powers
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }
        
        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
        
        
        

    }
}