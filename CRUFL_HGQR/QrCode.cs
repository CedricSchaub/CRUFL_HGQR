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
     
        public string generateAscii(string value)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData codeData = generator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            AsciiQRCode asciiCode = new AsciiQRCode(codeData);
     
            return asciiCode.GetGraphic(1);
        }

        public string generateBase64(string value) {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData codeData = generator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
     
            Base64QRCode base64Code = new Base64QRCode(codeData);

            return base64Code.GetGraphic(20);
        }

        public string test() {
            return "test";
        }
    }
}
