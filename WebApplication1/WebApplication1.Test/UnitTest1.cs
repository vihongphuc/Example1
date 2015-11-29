using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var gitFlow = string.Empty;
            var gitFlow2 = "Create test feature 02";
            gitFlow2 += "New update";

            gitFlow2 += "Create test feature 02a";
            gitFlow2 += "update 02a";
            gitFlow2 += "update 2 - 02a";

			var gitFlow3 = "Create test feature 03";
            gitFlow3 += "update";



            var gitFlow4 = "Create test feature 04";
            gitFlow4 += "update";

            var hotfi = "for release 03";

        }
    }
}
