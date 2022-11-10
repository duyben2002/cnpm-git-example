using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        public void Score8_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 2;
            s.Name = "Ben";
            s.Age = 21;
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        public void Score8_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 3;
            s.Name = "Hoang Anh";
            s.Age = 28;
            s.Score = 6;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        public void Score8_Should_ReturnD()
        {
            Student s = new Student();
            s.Id = 4;
            s.Name = "Ben";
            s.Age = 26;
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
    }
}