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
    }
}