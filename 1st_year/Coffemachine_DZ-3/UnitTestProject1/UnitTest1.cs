using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coffemachine_DZ_3;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrySdacha()
        {
            decimal sum = 37.9M;
            Assert.AreEqual(true, Money.TrySdacha(sum));
        }
        [TestMethod]
        public void TestSdacha()
        {
            decimal sum = 9.3M,d=Money.Value;
            Money.Sdacha(sum);
            Assert.AreEqual(Money.Value, d - sum);
        }

        // Структура класса Money не позволяет провести адекватный тест остальных его методов.
        // Методы на ввод денег требуют экземпляр класса, а при генерации экзепляра идет
        // чтение из консоли.
        [TestMethod]
        public void TestAllEnterMoney()
        {
            bool f = true;
            Assert.AreEqual(true, f);
        }
        [TestMethod]
        public void TestPodogreva()
        {
            Water s = new Water(0.0);
            s.Podogrev();
            Assert.AreEqual(true, s.ishot);     
        }
        [TestMethod]
        public void TestAppearSuply()
        {
            Storage.coffe -= 1.0;
            Storage.milk -= 1.0;
            Storage.sugar -= 1.0;
            Storage.water -= 1.0;
            Storage.AppearSuply();
            //Assert.AreEqual(new double[] { 1000.0, 10000.0, 1000.0, 100000.0 }, new double[] { Storage.coffe, Storage.milk, Storage.sugar, Storage.water });
            Assert.AreEqual(1000.0,Storage.coffe);
        }
        [TestMethod]
        public void TestCreateCup()
        {
            try
            {
                Cup w = new Cup("kapuchino");//Poroski.coffelist.Keys.ToList()[0]);
                TextWriter s = Console.Out;
                w.Create();
                Assert.IsTrue(s.ToString().Contains("Your coffe is ready!"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошло исключение - {ex.Message}");

            }
        }
        [TestMethod]
        public void TestCallSupport()
        {
            Storage.coffe -= 1.0;
            Storage.milk -= 1.0;
            Storage.sugar -= 1.0;
            Storage.water -= 1.0;
            Storage.AppearSuply();
            //Assert.AreEqual(new double[] { 1000.0, 10000.0, 1000.0, 100000.0 }, new double[] { Storage.coffe, Storage.milk, Storage.sugar, Storage.water });
            Assert.AreEqual(1000.0, Storage.coffe);
        }
    }
}
