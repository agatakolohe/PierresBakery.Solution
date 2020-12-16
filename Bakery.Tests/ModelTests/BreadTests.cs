using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Constructor()
        {
            Bread newBread = new Bread(1, "rye");
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadCost_GetBreadPrice_Int()
        {
            int inputBreadQuantity = 1;
            string inputBreadType = "rye";
            int breadCostTest = 6;
            Bread newBread = new Bread(inputBreadQuantity, inputBreadType);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
        [TestMethod]
        public void BreadCost_GetBreadDealPrice_Int()
        {
            int inputBreadQuantity = 3;
            string inputBreadType = "rye";
            int breadCostTest = 10;
            Bread newBread = new Bread(inputBreadQuantity, inputBreadType);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
    }
}
