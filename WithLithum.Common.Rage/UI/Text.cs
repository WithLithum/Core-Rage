using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.UI
{
    /// <summary>
    /// Represents a substring text label, which replaces <c>~s~</c> in translatable texts.
    /// </summary>
    public abstract class Text
    {
        /// <summary>
        /// Adds this instance as substring.
        /// </summary>
        public abstract void Add();
    }
}
