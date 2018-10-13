using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM.CoreWorkshop.ReportHelper.Tests
{
    [TestClass]
    public class ReportNameHelperTests
    {
        [TestMethod]
        [DataRow("Hello: my world", '_', "Hello_ my world")]
        [DataRow("Hello my %world", '_', "Hello my %world")]
        [DataRow("Hello my /world", '_', "Hello my _world")]
        public void NormalizeFileNameTest(string name, char repl, string expected)
        {
            var result = ReportNameHelper.NormalizeFileName(name, repl);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
