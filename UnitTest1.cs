using UnitTestConsole;

namespace TestKey
{
    [TestClass]
    public class UnitTest1
    {
        //Test class 
        [TestMethod]
        public void TestMethod1()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 4;
            researcher.NumOfPaper = 2;
            researcher.PaperRank = 3;

            Assert.AreEqual(13.2324, researcher.GetSalary());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 2;
            researcher.NumOfPaper = 2;
            researcher.PaperRank = 3;
            Assert.AreEqual(15.2324, researcher.GetSalary());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 4;
            researcher.NumOfPaper = 5;
            researcher.PaperRank = 2;
            Assert.AreEqual(14.2312, researcher.GetSalary());
        }
        [TestMethod]
        public void TestMethod4()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 4;
            researcher.NumOfPaper = 5;
            researcher.PaperRank = 2;
            Assert.AreEqual(15.012, researcher.GetSalary());
        }
        [TestMethod]
        public void TestMethod5()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 4;
            researcher.NumOfPaper = 5;
            researcher.PaperRank = 1;
            Assert.AreEqual(14321, researcher.GetSalary());
        }








    }
}