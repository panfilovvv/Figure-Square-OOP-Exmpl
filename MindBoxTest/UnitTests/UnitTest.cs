using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            try
            {
                Triangle t = new Triangle(a, b, c);
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "format");
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 3;
            double b = 4;
            double c = 9;
            try
            {
                Triangle t = new Triangle(a, b, c);
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "exist");
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 3;
            double b = 4;
            double c = 0;
            try
            {
                Triangle t = new Triangle(a, b, c);
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "zero");
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            double r = 3;
            try
            {
                Circle c = new Circle(r);
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "zero");
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            double r = -2;
            try
            {
                Circle c = new Circle(r);
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "zero");
            }
        }
    }
}
