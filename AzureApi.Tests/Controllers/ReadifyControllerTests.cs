using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureApi.Controllers.Tests
{
    [TestClass()]
    public class ReadifyControllerTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            ReadifyController controller = new ReadifyController();

            var dd = controller.ReverseWords("   abc  ");
        }
    }
}