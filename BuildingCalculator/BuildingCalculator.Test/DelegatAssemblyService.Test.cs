using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildingCalculator;

namespace BuildingCalculator.Test
{
    [TestClass]
    public class DelegatAssemblyServiceTest
    {
        [TestMethod]
        public void isCreatedCorrect_workDelegateNameNotChanged()
        {
            WorkTypeClass InpWork = new WorkTypeClass(100);
            InpWork.Article = "test";
            InpWork.category = WorkTypeClass.Category.other;

            string expected = null;

            DelegateAssemblyService.isCreatedCorrect(InpWork);
            Assert.AreEqual(expected, InpWork.delegateName);
        }
    }
}
