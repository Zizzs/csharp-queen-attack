using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackMain;

namespace QueenAttackMain.TestTools
{
    [TestClass]
    public class QueenTest
    {
        [TestMethod]
        public void Queen_CanHitHorizontal_True()
        {
            Queen testQueen = new Queen(5, 5, 5, 3);
            Assert.AreEqual(true, testQueen.CanHit());
        }
        [TestMethod]
        public void Queen_CanHitVertical_True()
        {
            Queen testQueen = new Queen(5, 3, 3, 3);
            Assert.AreEqual(true, testQueen.CanHit());
        }
        [TestMethod]
        public void Queen_CanHitDiagonally_True()
        {
            Queen testQueen = new Queen(5, 5, 3, 3);
            Assert.AreEqual(true, testQueen.CanHit());
        } 
    }
}