using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BestRes_100i2_ZeroElement_And_10()
        {
            float[] massiv = new float[] { 100.2f, 2.5f, 10f, -5.5f };
            var actual = Sport.Program.BestRes(massiv);
            var excepted = 10f;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void BestRes_0i2_ZeroElement_And_10max()
        {
            float[] massiv = new float[] { 0.2f, 2.5f, 10f, -5.5f };
            var actual = Sport.Program.BestRes(massiv);
            var excepted = 10f;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void negativ_BestRes_100i2_ZeroElement_And_10max()
        {
            float[] massiv = new float[] { 0.2f, 2.5f, 10f, -5.5f };
            var actual = Sport.Program.BestRes(massiv);
            var excepted = 100f;
            Assert.AreEqual(excepted, actual);
        }


        //TestFile.txt :
        //1,0
        //3,0
        //4,0
        [TestMethod]
        public void number_NewSportsman_2()
        {
            using (StreamReader sr = new StreamReader("TestFile.txt")) {
                Console.SetIn(sr);
                int number = 2;
                var actual = Sport.Program.NewSportsman(number);
                var excepted = 2;
                Assert.AreEqual(excepted, actual[0]);
            }
        }
        [TestMethod]
        public void NewSportsman_number3_Score134()
        {
            using (StreamReader sr = new StreamReader("TestFile.txt")) {
                Console.SetIn(sr);
                int number = 3;
                var actual = Sport.Program.NewSportsman(number);
                var excepted = new float[5] { 3, 1.0f, 3.0f, 4.0f, 4.0f };
                for (int i = 0; i < 5; i++)
                {
                    Assert.AreEqual(excepted[i], actual[i]);
                }
            }
        }
        [TestMethod]
        public void ntgativ_NewSportsman_87531()
        {
            using (StreamReader sr = new StreamReader("TestFile.txt")) {
                Console.SetIn(sr);
                int number = 3;
                var actual = Sport.Program.NewSportsman(number);
                var excepted = new float[5] { 8, 7.0f, 5.0f, 3.0f, 1.0f };
                for (int i = 0; i < 5; i++)
                {
                    Assert.AreEqual(excepted[i], actual[i]);
                }
            }
        }

    }
}
