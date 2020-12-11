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
            Bread newBread = new Bread(1, "sourdough");
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadCost_GetBreadPrice_Int()
        {
            int inputBreadQuantity = 3;
            string inputBreadKind = "sourdough";
            int breadCostTest = 10;
            Bread newBread = new Bread(inputBreadQuantity, inputBreadKind);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
        [TestMethod]
        public void BreadCost_GetBreadPrice_Int()
        {
            int inputBreadQuantity = 3;
            string inputBreadKind = "sourdough";
            int breadCostTest = 10;
            Bread newBread = new Bread(inputBreadQuantity, inputBreadKind);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
        [TestMethod]
        public void BreadType_GetBreadType_False()
        {
            int inputBreadQuantity = 3;
            string inputBreadKind = "sourdough";
            Bread newBread = new Bread(inputBreadQuantity, inputBreadKind);

            int breadType = newBread.BreadType();

            Assert.AreEqual(false, breadType);
        }
    }
}