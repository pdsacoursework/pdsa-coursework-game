using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PDSACourseWork.Helper;
using System.Linq;

namespace PDSACourseWorkUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCompareLists()
        {
            List<string> playerList = new();
            playerList.Add("1,1");
            playerList.Add("2,7");
            playerList.Add("3,5");
            playerList.Add("4,8");
            playerList.Add("5,2");
            playerList.Add("6,4");
            playerList.Add("7,6");
            playerList.Add("8,3");

            List<string> possibilityList = new();
            possibilityList.Add("1,1-2,7-3,5-4,8-5,2-6,4-7,6-8,3");

            bool expected = true;

            bool actual = EightQueenHelper.CompareLists(playerList, possibilityList);

            Assert.AreEqual(expected, actual);
        }
    }
}