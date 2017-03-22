using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata.UnitTests
{
    [TestClass]
    public class BowlingGameShould
    {
        [TestMethod]
        public void ReturnScore()
        {
            int score = new BowlingGame().Score();
            Assert.AreEqual(0, score);
        }
    }
}
