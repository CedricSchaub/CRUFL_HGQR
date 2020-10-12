using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CRUFL_HGQR
{
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), GuidAttribute("064267D7-70FF-4D45-8D47-8A99C6604BB4")]
    public class QrCode : IGenerateQr
    {
     
        public string generate(string value)
        {
            return "Dieser Text ist von der C# Bibliothek " + value;
        }
    }
}
