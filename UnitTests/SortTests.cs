using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SmallLibrary;
using SmallLibrary.Interface;

namespace UnitTests
{
    //              принцип именования 
    //  Method_Scenario_ExpectedBehavior:
    //  
    //  Method – метод [или свойство], который тестируем
    //  Scenario – сценарий, который мы тестируем
    //  ExpectedBehavior – ожидаемое поведение

    [TestFixture]
    public class EasyTaskTests
    {
        IEasyTask task;

        [SetUp]
        public void Setup()
        {
            task = new EasyTask();
        }

        [Test]
        public void BubbleSorting()
        { 
            int[] input = new int[]{1, 0, 20, 3, 2, 2, 5};

            var result = input.ToList();
            result.Sort();
            
            task.Sort(input);

            CollectionAssert.AreEqual(input, result);
        }

        [Test]
        public void SortIfInputIsNull()
        {
            Assert.Throws(typeof(NullReferenceException), new TestDelegate(() => task.Sort(null)));
        }

        [Test]
        public void Reverse_GetReversedString_ItIsOkReversedString()
        {
            //assign
            string s = "a b c d e f g";
            var trueResult = s.Reverse();

            //act 
            var result = task.Reverse(s);

            //assert
            Assert.AreEqual(result, trueResult);
        }

        [Test]
        public void Reverse_TransmitNullStringAsArgument_ItThrowsArgumentNullException()
        {
            string s = null;

            Assert.Throws<ArgumentNullException>(new TestDelegate(() => task.Reverse(s)));
        }

        [Test]
        public void NearestTo_TransmitArrayAndNumberThatNotEqualToAnyArrayItem_ReturnNearestInt()
        {
            int[] array = new int[] { 1, 4, 8, 20, 0, 2, 0, -1, 50 };

            int nearest = task.NearestTo(array, 3);

            Assert.That(nearest == 2 || nearest == 4);
        }
    }
}
