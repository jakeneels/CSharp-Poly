using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class UnitTest1
    {
        DateFashion _dateFashion = new DateFashion();
        FrontTimes _frontTimes = new FrontTimes();
        Less20 _less20 = new Less20();
        SameFirstLast _sameFirstLast = new SameFirstLast();

 
 


        [TestMethod]
        public void DateFashionTest()
        {
            Assert.AreEqual(2, _dateFashion.GetATable(5, 10));
            Assert.AreEqual(0, _dateFashion.GetATable(5, 2));
            Assert.AreEqual(1, _dateFashion.GetATable(5, 5));
            Assert.AreEqual(0, _dateFashion.GetATable(1, 1));
            Assert.AreEqual(2, _dateFashion.GetATable(8, 11));
            Assert.AreEqual(0, _dateFashion.GetATable(-1, 10));
        }
        [TestMethod]
        public void FirstTimes()
        {
            Assert.AreEqual("ChoCho", _frontTimes.GenerateString("Chocolate", 2));
            Assert.AreEqual("ChoChoCho", _frontTimes.GenerateString("Chocolate", 3));
            Assert.AreEqual("AbcAbcAbc", _frontTimes.GenerateString("Abc", 3));
            Assert.AreEqual("", _frontTimes.GenerateString("", 3));
            Assert.AreEqual("AbAb", _frontTimes.GenerateString("Ab", 2));
            Assert.AreEqual("Cho", _frontTimes.GenerateString("Chocolate", 1));

        }
        [TestMethod]
        public void Less20()
        {
            Assert.IsTrue(_less20.IsLessThanMultipleOf20(18));
            Assert.IsTrue(_less20.IsLessThanMultipleOf20(19));
            Assert.IsFalse(_less20.IsLessThanMultipleOf20(20));
            Assert.IsFalse(_less20.IsLessThanMultipleOf20(21));
            Assert.IsTrue(_less20.IsLessThanMultipleOf20(38));
            Assert.IsFalse(_less20.IsLessThanMultipleOf20(40));
        }
        [TestMethod]
        public void SameFirstLast()
        {
            Assert.IsFalse(_sameFirstLast.IsItTheSame(new int[] { 1, 2, 3 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new int[] { 1, 2, 3, 1 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new int[] { 1, 2, 1 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new int[] { }));
            Assert.IsFalse(_sameFirstLast.IsItTheSame(new int[] { 1, 2, 3, 4}));
            Assert.IsFalse(_sameFirstLast.IsItTheSame(new int[] { -3, 2, 3 }));
        }



        /*
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         IsItTheSame([1, 2, 3]) → false
         IsItTheSame([1, 2, 3, 1]) → true
         IsItTheSame([1, 2, 1]) → true
         */
    }
}

