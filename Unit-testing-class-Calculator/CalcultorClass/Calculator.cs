﻿namespace CalculatorClass
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

        public double Power(double x, double exp)
        {
            Accumulator =  Math.Pow(x, exp);
            return Accumulator;
            
        }
        
        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
        
        
        

        public double Add(double addend)
        {
            Accumulator = Accumulator + addend;
            return Accumulator;


        }

        public double Subtract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }


       



    }
}