using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.UI.Scaleform
{
    /// <summary>
    /// Represents a scaleform argument.
    /// </summary>
    public interface IScaleformArgument<T>
    {
        /// <summary>
        /// Pushes this instance onto the stack.
        /// </summary>
        void Push();

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        T Value { get; set; }
    }
}
