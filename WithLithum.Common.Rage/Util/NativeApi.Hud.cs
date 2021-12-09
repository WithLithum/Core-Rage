using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util
{
    internal static partial class NativeApi
    {
        /// <summary>
        /// Adds an arbitrary string as a text component placeholder, replacing <c>~a~</c> in the current text command's text label.
        /// </summary>
        /// <param name="value">A string to add of up to 99 characters. This can contain additional <c>~</c> formatting directives.</param>
        internal static void AddTextComponentSubstringPlayerName(string value)
        {
            NativeFunction.Natives.x6C188BE134E074AA(value);
        }

        internal static void AddTextComponentSubstringTextLabel(string value)
        {
            NativeFunction.Natives.xC63CD5D2920ACBE7(value);
        }

        internal static void BeginTextCommandBusyspinnerOn(string label)
        {
            NativeFunction.Natives.xD422FCC5F239A915(label);
        }

        internal static bool BusySpinnerIsOn()
        {
            return NativeFunction.Natives.xD422FCC5F239A915<bool>();
        }

        internal static void BusyspinnerOff()
        {
            NativeFunction.Natives.x10D373323E5B9C0D();
        }

        internal static void EndTextCommandBusyspinnerOn(int type)
        {
            NativeFunction.Natives.xBD12F8228410D9B4(type);
        }
    }
}
