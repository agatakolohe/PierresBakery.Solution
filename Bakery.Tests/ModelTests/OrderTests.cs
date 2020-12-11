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
            int inputBreadQuatity = 1;
            int breadCostTest = 5;
            Bread newBread = new Bread(inputBreadQuatity);

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
    }
}
