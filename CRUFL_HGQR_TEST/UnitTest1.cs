using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRUFL_HGQR_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CRUFL_HGQR.QrCode code = new CRUFL_HGQR.QrCode();
            String result = code.test();
            Assert.AreEqual("test", result);
        }

        [TestMethod]
        public void TestBasicQRCode() {
            CRUFL_HGQR.QrCode code = new CRUFL_HGQR.QrCode();
            code.generate("test");
        }
    }
}
