using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util;

namespace WithLithum.Core.UI.Scaleform
{
    /// <summary>
    /// Represents a <see cref="bool"/>-typed scaleform argument.
    /// </summary>
    public class BooleanScaleformArgument : IScaleformArgument<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanScaleformArgument"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public BooleanScaleformArgument(bool value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public bool Value { get; set; }

        /// <summary>
        /// Pushes this instance onto the stack.
        /// </summary>
        public void Push()
        {
            NativeApi.ScaleformMovieMethodAddParamBool(Value);
        }

        /// <summary>
        /// Converts the <paramref name="value"/> to a scaleform argument implicitly.
        /// </summary>
        /// <param name="value">The value;</param>
        public static implicit operator BooleanScaleformArgument(bool value)
        {
            return new BooleanScaleformArgument(value);
        }
    }
}
