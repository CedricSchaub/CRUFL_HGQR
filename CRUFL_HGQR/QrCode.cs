using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using QRCoder;

namespace CRUFL_HGQR
{
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), GuidAttribute("064267D7-70FF-4D45-8D47-8A99C6604BB4")]
    public class QrCode : IGenerateQr
    {
     
        public string generate(string value)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData codeData = generator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            byte[] rawData = codeData.GetRawData(QRCodeData.Compression.Uncompressed);

            String result = "";

            foreach(byte b in rawData) {
                char c = Convert.ToChar(b);
                result += c;
            }

            return result;
        }

        public string test() {
            return "test";
        }
    }
}
