using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util;

namespace WithLithum.Core.UI.Scaleform
{
    /// <summary>
    /// Represents an <see cref="int"/>-typed scaleform argument.
    /// </summary>
    public class Int32ScaleformArgument : IScaleformArgument<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScaleformArgument"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Int32ScaleformArgument(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Pushes this instance onto the stack.
        /// </summary>
        public void Push()
        {
            NativeApi.ScaleformMovieMethodAddParamInt(Value);
        }

        /// <summary>
        /// Converts the <paramref name="value"/> to a scaleform argument implicitly.
        /// </summary>
        /// <param name="value">The value;</param>
        public static implicit operator Int32ScaleformArgument(int value)
        {
            return new Int32ScaleformArgument(value);
        }
    }
}
