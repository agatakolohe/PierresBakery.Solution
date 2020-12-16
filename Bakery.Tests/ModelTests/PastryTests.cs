using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Constructor()
        {
            Pastry newPastry = new Pastry(1);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void PastryCost_GetPastryPrice_Int()
        {
            int inputPastryQuantity = 1;
            int pastryCostTest = 2;
            Pastry newPastry = new Pastry(inputPastryQuantity);

            int pastryCost = newPastry.PastryCost();

            Assert.AreEqual(pastryCostTest, pastryCost);
        }
        [TestMethod]
        public void PastryCost_GetPastryDealPrice_Int()
        {
            int inputPastryQuantity = 3;
            int pastryCostTest = 12;
            Pastry newPastry = new Pastry(inputPastryQuantity);

            int pastryCost = newPastry.PastryCost();

            Assert.AreEqual(pastryCostTest, pastryCost);
        }
    }
}