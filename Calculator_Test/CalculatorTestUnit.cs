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
        [Test]
        public void AddOverloadTest()
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);
            Assert.That(uut.Add(10), Is.EqualTo(15));
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
        
        [Test]
        public void MinusOverloadTest()
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);
            Assert.That(uut.Subtract(10), Is.EqualTo(-5));
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
        
        [Test]
        public void MultiplyOverloadTest()
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);
            Assert.That(uut.Multiply(10), Is.EqualTo(50));
        }

        [TestCase(5, 5, 3125)]
        [TestCase(10, 5, 100000)]
        [TestCase(5, 2, 25)]
        public void PowTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Power(p1, p2), Is.EqualTo(expected));

        }
        
        [Test]
        public void PowOverloadTest()
        {
            var uut = new Calculator();
            uut.Multiply(5, 1);
            Assert.That(uut.Power(2), Is.EqualTo(25));
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
        public void DivideOverloadTest()
        {
            var uut = new Calculator();
            uut.Multiply(10, 1);
            Assert.That(uut.Divide(5), Is.EqualTo(2));
        }
        
        [Test]
        public void AccumulatorTest()
        {
            var uut = new Calculator();
            uut.Add(10, 5);
            Assert.That(uut.Accumulator, Is.EqualTo(15));
        }
        
        [Test]
        public void ClearTest()
        {
            var uut = new Calculator();
            uut.Add(10, 5);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
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