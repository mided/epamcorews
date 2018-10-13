using EPAM.Core.ReportHelper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.CoreWorkshop.ReportHelper.Tests
{
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        public void FillTests()
        {
            var array = new int[3];

            ArrayHelper.Fill(array, 5);

            var expectedResult = new int[] { 5, 5, 5 };

            array.Should().BeEquivalentTo(expectedResult);
        }
    }
}