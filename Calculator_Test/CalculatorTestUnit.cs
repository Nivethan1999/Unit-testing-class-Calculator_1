using CalculatorClass;

namespace Calculator_Test
{
    public class CalculatorTestUnit
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 5, 7)]
        [TestCase(10, 20, 30)]
        [TestCase(10, 10, 20)]
        [TestCase(50, 50, 100)]
        [TestCase(100, 50, 150)]

        public void AddTest(double p1, double p2, double expected)
        {
            var uut = new Calculator();
            Assert.That(uut.Add(p1, p2), Is.EqualTo(expected));

        }

        [Test]
        public void MinusTest()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(10,5),Is.EqualTo(5));
        }
        
        [Test]
        public void DivideTestOverloaded()
        {
            var uut = new Calculator();
            uut.Multiply(10, 1);
            Assert.That(uut.Divide(5),Is.EqualTo(2));
        }

        [Test]
        public void MultiplyTest()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(10, 5), Is.EqualTo(50));
        }
        
        [Test]
        public void MultiplyTestOverloaded()
        {
            var uut = new Calculator();
            uut.Add(0, 5);
            Assert.That(uut.Multiply(10), Is.EqualTo(50));
        }

        [Test]
        public void PowTest()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }
        
        [Test] 
        public void PowTestOverloaded()
        {
            var uut = new Calculator();
            uut.Power(2, 2);
            
            //4^2 = 16
            Assert.That(uut.Power(2), Is.EqualTo(16));
        }

    }
}