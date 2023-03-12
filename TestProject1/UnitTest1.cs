using ClassLibrary1;
using Microsoft.VisualBasic.FileIO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 calculator = new Class1();
            if(calculator.Add(2,2) != 4) { throw new ApplicationException(); }
            //Assert.AreEqual(4, calculator.Add(2, 2));
        }
    }
}