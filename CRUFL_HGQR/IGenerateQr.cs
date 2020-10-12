using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CRUFL_HGQR
{
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("5A9DA6EA-241E-47F8-8232-5BBB256EA7F4")]
    public interface IGenerateQr
    {
        string generate(string value);
    }
}
