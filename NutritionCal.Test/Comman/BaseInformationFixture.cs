using System;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using NUnit;
using NUnit.Framework;

namespace NutritionCal.Test.Comman
{
    [TestFixture]
    public class BaseInformationFixture
    {
        [Test]
        public void TestWeightSet()
        {
            IBaseInformation baseinformation = new BaseInformation();
            baseinformation.Weight = 10;

            Assert.AreEqual(10, baseinformation.Weight);
        }
    }
}
