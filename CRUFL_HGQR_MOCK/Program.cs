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
            String result = code.generate("test");
            
            Console.WriteLine(result); 
            Console.ReadLine();

        }
    }
}
