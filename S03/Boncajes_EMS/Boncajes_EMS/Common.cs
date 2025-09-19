using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; //Ito yung Sa DllImport
using System.Text;
using System.Threading.Tasks;

namespace Boncajes_EMS
{
    internal class Common //Ang explanation lang ni sir sa Class na ito. Ina-allow na kapag pinindot mo yung Top Panel
                          //sa taas nung Form1 pede nyo idrag yung window kung saan man part ng screen.
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")] //If Red yung DllImport [Right click then show potential fixes tapos select yung
                                           //using System.Runtime.InteropServices;]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")] //Same lang sa taas.

        public static extern bool ReleaseCapture();
    }
}
