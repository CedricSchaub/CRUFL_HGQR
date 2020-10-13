using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUFL_HGQR;

namespace CRUFL_HGQR_MOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            QrCode code = new QrCode();
            String ascii = code.generateAscii("test");
            String base64 = code.generateBase64("test");
            
            Console.WriteLine(ascii);
            Console.WriteLine(base64);
            Console.ReadLine();

        }
    }
}
