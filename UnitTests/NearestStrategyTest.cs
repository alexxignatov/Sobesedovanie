using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SmallLibrary;
using SmallLibrary.Strategy;
using SmallLibrary.Interface;

namespace UnitTests
{
    [TestFixture]
    public class NearestStrategyTest
    {
        int[] array;

        [SetUp]
        public void Setup()
        {
            array = new int[] { 1, 4, 8, 20, 0, 2, 0, -1, 50 };
        }

        [Test]
        public void NearestTo_BaseNearestStrategyImplementation_ReturnValidValue()
        {
            int nearest = array.NearestTo(3, new BaseNearestStrategy());
            Assert.That(nearest == 2 || nearest == 4);
        }

        [Test]
        public void NearestTo_NearestWithSortStrategyImplementation_ReturnValidValue()
        {
            var sortStrategy = new NearestWithSort();
            
            int nearest = array.NearestTo(3, sortStrategy);
            Assert.That(nearest == 2 || nearest == 4);

            int nearest2 = (new int[]{1}).NearestTo(3, sortStrategy);
            Assert.That(nearest2 == 1);
        }

        [Test]
        public void NearestTo_NearestWithAggregateStrategyImplementation_ReturnValidValue()
        {
            INearestStrategy aggregate = new NearestWithAggregate();

            int nearest = array.NearestTo(3, aggregate);
            Assert.That(nearest == 2 || nearest == 4);

            int nearest2 = (new int[] { 1 }).NearestTo(3, aggregate);
            Assert.That(nearest2 == 1);

            int nearest3 = (new int[] { 1, -1, -3 }).NearestTo(-4, aggregate);
            Assert.That(nearest3 == -3);
        }
    }
}
