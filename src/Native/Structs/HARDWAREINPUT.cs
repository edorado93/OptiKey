﻿using System.Runtime.InteropServices;

namespace JuliusSweetland.ETTA.Native.Structs
{
    /// <summary>
    /// The HARDWAREINPUT structure contains information about a simulated message generated by an input device other than a keyboard or mouse.  (see: http://msdn.microsoft.com/en-us/library/ms646269(VS.85).aspx)
    /// Declared in Winuser.h, include Windows.h
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct HARDWAREINPUT
    {
        /// <summary>
        /// Value specifying the message generated by the input hardware. 
        /// </summary>
        public int Msg;

        /// <summary>
        /// Specifies the low-order word of the lParam parameter for uMsg. 
        /// </summary>
        public short ParamL;

        /// <summary>
        /// Specifies the high-order word of the lParam parameter for uMsg. 
        /// </summary>
        public short ParamH;

        public override string ToString()
        {
            return string.Format("\t\t\t\tMsg:{0}" +
                                 "\n\t\t\t\tParamL:{1}" +
                                 "\n\t\t\t\tParamH:{2}", 
                                 Msg, ParamL, ParamH);
        }
    }
}