using AzureApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureApi.Tests.Services
{
    [TestClass()]
    public class ReverseWordsTests
    {
        private IReadifyService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new ReadifyPuzzels();
        }

        [TestMethod()]
        public void Spaces_Should_Return_Empty()
        {
            var expectedValue = "";
            var actualValue = _service.ReverseWords("     ");

            Assert.IsTrue(expectedValue == actualValue);
        }

        [TestMethod()]
        public void One_Word_Trailling_Spaces()
        {
            var expectedValue = "taC   ";
            var actualValue = _service.ReverseWords("Cat   ");

            Assert.IsTrue(expectedValue == actualValue);
        }
    }
}