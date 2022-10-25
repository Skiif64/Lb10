using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SequenceTests
    {
        [TestMethod]
        public void Sequence_Empty_ShouldReturn0()
        {
            double[] array = new double[] { 0 };
            int expected = 0;
            int result = Sequence.Calculate(array);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Sequence_1Elem_ShouldReturn0()
        {
            double[] array = new double[] { 1, 0 };
            int expected = 0;
            int result = Sequence.Calculate(array);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sequence_Ordered_ShouldReturn0()
        {
            double[] array = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int expected = 0;
            int result = Sequence.Calculate(array);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sequence_Normal_ShouldReturn4()
        {
            double[] array = new double[] { 1, -3, 6, -5, 10, 0 };
            int expected = 4;
            int result = Sequence.Calculate(array);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sequence_Normal2_ShouldReturn0()
        {
            double[] array = new double[] { -2, 6, 5, -10, 25, 0 };
            int expected = 3;
            int result = Sequence.Calculate(array);
            Assert.AreEqual(expected, result);
        }

    }
}