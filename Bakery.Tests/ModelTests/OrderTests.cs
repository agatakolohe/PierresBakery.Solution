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
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
    }
}
