using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureApi.Services.Tests.Services
{
    [TestClass()]
    public class TriangleTests
    {
        private IReadifyService _service;
        const string error = "Error";
        const string equilateral = "Equilateral";
        const string isosceles = "Isosceles";
        const string scalene = "Scalene";

        [TestInitialize]
        public void Setup()
        {
            _service = new ReadifyPuzzels();
        }

        [TestMethod()]
        public void FirstSide_0_ShouldReturnError()
        {
            var actualValue = _service.GetTriangleType(0, 1, 1);

            Assert.IsTrue(actualValue == error);
        }

        [TestMethod()]
        public void SecondSide_0_ShouldReturnError()
        {
            var actualValue = _service.GetTriangleType(1, 0, 1);

            Assert.IsTrue(actualValue == error);
        }

        [TestMethod()]
        public void ThirdSide_0_ShouldReturnError()
        {
            var actualValue = _service.GetTriangleType(1, 1, 0);

            Assert.IsTrue(actualValue == error);
        }

        [TestMethod()]
        public void All_Sides_Max_Intger_ShouldReturn_Equilateral()
        {
            var actualValue = _service.GetTriangleType(int.MaxValue, int.MaxValue, int.MaxValue);

            Assert.IsTrue(actualValue == equilateral);
        }
    }
}