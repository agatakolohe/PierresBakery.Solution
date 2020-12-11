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
            int inputBreadQuantity = 3;
            int breadCostTest = 10;
            Bread newBread = new Bread(inputBreadQuantity, "rye");

            int breadCost = newBread.BreadCost();

            Assert.AreEqual(breadCostTest, breadCost);
        }
        [TestMethod]

        public void BreadType_GetBreadType_String()
        {
            string inputBreadType = "rye";
            Bread newBread = new Bread(2, inputBreadType);

            string breadKind = newBread.GetBreadType();

            Assert.AreEqual(inputBreadType, breadKind);

        }

    }
}
