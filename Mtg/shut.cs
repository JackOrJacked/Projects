using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtg
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    //----
    public static class RTBBeepExtensions
    {
        public static void EnableBeep(this ListView rtb)
        {
            SetBeepInternal(rtb, true);
        }

        public static void DisableBeep(this ListView rtb)
        {
            SetBeepInternal(rtb, false);
        }

        private static void SetBeepInternal(ListView rtb, bool beepOn)
        {
            const Int32 WM_USER = 0x400;
            const Int32 EM_GETOLEINTERFACE = WM_USER + 60;
            const Int32 COMFalse = 0;
            const Int32 COMTrue = ~COMFalse; // -1

            ITextServices textServices = null;
            // retrieve the rtb's OLEINTERFACE using the Interop Marshaller to cast it as an ITextServices
            // The control calls the AddRef method for the object before returning, so the calling application must call the Release method when it is done with the object.
            SendMessage(new HandleRef(rtb, rtb.Handle), EM_GETOLEINTERFACE, IntPtr.Zero, ref textServices);
            //textServices.OnTxPropertyBitsChange(TXTBIT.ALLOWBEEP, beepOn ? COMTrue : COMFalse);
            //Marshal.ReleaseComObject(textServices);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private extern static IntPtr SendMessage(HandleRef hWnd, Int32 msg, IntPtr wParam, ref ITextServices lParam);

        #region ITextServices // From TextServ.h
        [ComImport(), Guid("8d33f740-cf58-11ce-a89d-00aa006cadc5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITextServices
        {
            //see: Slots in the V-table
            //     https://learn.microsoft.com/en-us/dotnet/framework/unmanaged-api/metadata/imetadataemit-definemethod-method#slots-in-the-v-table
            void _VtblGap1_16();
            Int32 OnTxPropertyBitsChange(TXTBIT dwMask, Int32 dwBits);
        }

        private enum TXTBIT : uint
        {
            /// <summary>If TRUE, beeping is enabled.</summary>
            ALLOWBEEP = 0x800
        }
        #endregion

    }
}
