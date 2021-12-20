using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util;

namespace WithLithum.Core.UI.Scaleform
{
    /// <summary>
    /// Represents a <see cref="float"/>-typed scaleform argument.
    /// </summary>
    public class SingleScaleformArgument : IScaleformArgument<float>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleScaleformArgument"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public SingleScaleformArgument(float value)
        {
            Value = value;
        }

        /// <inheritdoc />
        public float Value { get; set; }

        /// <inheritdoc />
        public void Push()
        {
            NativeApi.ScaleformMovieMethodAddParamFloat(Value);
        }
    }
}
