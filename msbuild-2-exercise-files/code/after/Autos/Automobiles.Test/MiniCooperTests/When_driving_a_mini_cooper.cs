using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automobiles.Test.MiniCooperTests
{
    [TestClass]
    public class When_driving_a_mini_cooper
    {
        MiniCooper _auto;

        [TestInitialize]
        public void Init()
        {
            _auto = new MiniCooper();
        }

        [TestMethod]
        public void It_can_start()
        {
            Assert.IsNotNull(_auto.Start());
        }

        [TestMethod]
        public void It_can_stop()
        {
            Assert.IsNotNull(_auto.Stop());
        }

        [TestMethod]
        public void It_has_the_correct_name()
        {
            Assert.AreEqual("Mini Cooper", _auto.Name);
        }
    }
}
