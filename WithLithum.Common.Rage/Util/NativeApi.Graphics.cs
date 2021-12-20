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
        internal static void ScaleformMovieMethodAddParamBool(bool value)
        {
            NativeFunction.Natives.xC58424BA936EB458(value);
        }

        internal static void ScaleformMovieMethodAddParamFloat(float value)
        {
            NativeFunction.Natives.xD69736AAE04DB51A(value);
        }

        internal static void ScaleformMovieMethodAddParamInt(int value)
        {
            NativeFunction.Natives.xC3D0841A0CC546A6(value);
        }
    }
}
