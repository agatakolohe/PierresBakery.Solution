using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Constructor()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadCost_GetBreadPrice_Int()
        {
            int inputBreadQuantity = 3;
            int breadCostTest = 10;
            Bread newBread = new Bread(inputBreadQuantity);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }

        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Constructor()
        {
            Pastry newPastry = new Pastry(1);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void PastryCost_GetPastryPrice_Int()
        {
            int inputPastryQuantity = 3;
            int pastryCostTest = 5;
            Pastry newPastry = new Pastry(inputPastryQuantity);

            int pastryCost = newPastry.PastryCost();

            Assert.AreEqual(pastryCostTest, pastryCost);
        }
    }
}
