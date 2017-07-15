using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuildingCalculator.Test
{
    [TestClass]
    public class WorkTypeClassTests
    {
        [TestMethod]
        public void FullEquals()
        {
            //arrange 
            WorkTypeClass work = new WorkTypeClass();
            WorkTypeClass work1 = work.Clone() as WorkTypeClass;

            //act
            bool actual = work.FullEquals(work1);

            //assert

            Assert.AreEqual(true, actual);
        }
    }
}
