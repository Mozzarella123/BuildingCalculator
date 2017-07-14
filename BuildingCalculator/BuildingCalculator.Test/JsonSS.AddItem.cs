using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuildingCalculator.Test
{
    [TestClass]
    public class JsonSSAddItem
    {
        [TestInitialize]
        [TestCleanup]
        public void TestInitialize()
        {
            JSONSerializeService.ReadInput("test.json");
        }

        [TestMethod]
        public void AddToOutput_AddNewWork()
        {
            WorkTypeClass work = new WorkTypeClass();
            work.article = "Test";
            work.category = WorkTypeClass.Category.other;
            work.setPriceFunc("0");

            bool expected = true;

            bool result = JSONSerializeService.AddToOutput(work);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddToOutput_AddExistedWork()
        {
            WorkTypeClass work = new WorkTypeClass();
            work.article = "Test2";
            work.category = WorkTypeClass.Category.other;
            work.setPriceFunc("0");

            bool expected = false;

            JSONSerializeService.AddToOutput(work);
            bool result = JSONSerializeService.AddToOutput(work);
            Assert.AreEqual(expected, result);
        }
    }
}
