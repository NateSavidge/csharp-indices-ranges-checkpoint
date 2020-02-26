using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpIndicesRangesCheckpoint
{
    [TestClass]
    public class TestsBefore
    {
        readonly static string[] GRADES = new string[]
            {
                "A", "B", "C", "D", "F"
            };

        [TestMethod]
        public void GetGradeFromEnd_WhenCalledWithValidNumber_ShouldReturnGradeFromEnd()
        {
            string result = getGradeFromEnd(4);

            Assert.AreEqual("B", result);
        }

        private string getGradeFromEnd(int indexFromEnd)
        {
            string item = GRADES[^indexFromEnd];
            return item;
        }

        [TestMethod]
        public void GetGradeRange_WhenCalledWithStartAndEndIndex_ShouldReturnGradeRange()
        {
            string[] result = getGradeRange(1, 3);

            CollectionAssert.AreEqual(new string[] { "B", "C", "D" }, result);
        }

        private string[] getGradeRange(int startIndex, int endIndex)
        {
            var result = GRADES[startIndex..(endIndex+1)];
            return result;
        }

        [TestMethod]
        public void GetGradeRange_WhenCalledWithStartAndEndIndex_ShouldReturnGradeRange2()
        {
            string[] result = getGradeRange(1, 3);

            CollectionAssert.AreEqual(new string[] { "B", "C", "D" }, result);
            result[0] = "Fred";
            Assert.AreEqual("B", GRADES[1]);

        }
    }
}