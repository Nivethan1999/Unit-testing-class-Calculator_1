using CalculatorClass;

namespace Calculator_Test
{
    public class CalculatorTestUnit
    {
        [SetUp]
        public void Setup()
        {
        }

       


        //Addition Test
        //[Test]
        [TestCase(2, 5, 7)]
        [TestCase(10, 20, 30)]
        [TestCase(10, 10, 20)]
        [TestCase(50, 50, 100)]
        [TestCase(100, 50, 150)]
        [TestCase(150, 150, 300)]
        public void AddTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Add(p1, p2), Is.EqualTo(expected));

        }
        [TestCase(2, 12)]
        [TestCase(10, 20)]
        [TestCase(100, 110)]
        public void AddOverloadTest(double p1,double expected)
        {
            var uut = new Calculator();
            uut.Add(5, 5);//initializing the accumulator
            Assert.That(uut.Add(p1), Is.EqualTo(expected));

        }
        

        //Subtraction Test
        [TestCase(50, 50, 0)]
        [TestCase(100, 50, 50)]
        [TestCase(200, 100, 100)]
        public void MinusTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(p1, p2), Is.EqualTo(expected));
        }
        
        [TestCase( 5, 0)]
        [TestCase(10, -5)]
        [TestCase(2, 3)]
        public void MinusOverloadTest(double p1, double expected)
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);//initializing the accumulator
            Assert.That(uut.Subtract(p1), Is.EqualTo(expected));
        }


        //Multiplication Test
        [TestCase(5, 5, 25)]
        [TestCase(10, 5, 50)]
        [TestCase(5, 2, 10)]
        public void MultiplyTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(p1, p2), Is.EqualTo(expected));
        }
        
        [TestCase( 5, 25)]
        [TestCase(10, 50)]
        [TestCase(2, 10)]
        public void MultiplyOverloadTest(double p1, double expected)
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);//initializing the accumulator
            Assert.That(uut.Multiply(p1), Is.EqualTo(expected));
        }

        [TestCase(5, 5, 3125)]
        [TestCase(10, 5, 100000)]
        [TestCase(5, 2, 25)]
        public void PowTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Power(p1, p2), Is.EqualTo(expected));

        }
        
        [TestCase(0, 1)]
        [TestCase(1, 5)]
        [TestCase(2, 25)]
        public void PowOverloadTest(double power, double expected)
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);//initializing the accumulator
            Assert.That(uut.Power(power), Is.EqualTo(expected));
        }

        [TestCase(5, 5, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(5, 2, 2.5)]
        
        public void DivideTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Divide(p1, p2), Is.EqualTo(expected));
        }
        
        [Test]
        public void DivideTestException()
        {
            var uut = new Calculator();
            Assert.Throws<DivideByZeroException>(() => uut.Divide(10, 0));
        }
        
        
        [TestCase(10,1)]
        [TestCase(5,2)]
        [TestCase(2,5)]
        public void DivideOverloadTest(double p1, double expected)
        {
            var uut = new Calculator();
            uut.Multiply(10, 1);//initializing the accumulator
            Assert.That(uut.Divide(p1), Is.EqualTo(expected));
        }
        
        [Test]
        public void DivideOverloadTestException()
        {
            var uut = new Calculator();
            uut.Multiply(10, 1); //initializing the accumulator
            Assert.Throws<DivideByZeroException>(() => uut.Divide(0));
        }
        
        [TestCase(2, 5, 7)]
        [TestCase(10, 20, 30)]
        [TestCase(10, 10, 20)]
        public void AccumulatorAddTest(double p1,double p2, double expected)
        {
            var uut = new Calculator();
            uut.Add(p1, p2);
            Assert.That(uut.Accumulator, Is.EqualTo(expected));
        }
        
        [TestCase(2, 5, 0)]
        [TestCase(10, 20, 0)]
        [TestCase(10, 10, 0)]
        public void ClearTest(double p1,double p2, double expected)
        {
            var uut = new Calculator();
            uut.Add(p1, p2);//initializing the accumulator
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(expected));
        }

        [TestCase(36, 6 )]
        [TestCase(16,  4)]
        [TestCase(100,  10)]
        public void SqrtTest(double p1, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Sqrt(p1), Is.EqualTo(expected));
        }

        







    }
}