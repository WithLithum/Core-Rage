using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util;

namespace WithLithum.Core.UI
{
    /// <summary>
    /// Represents a literal text. Also known as player name substring.
    /// </summary>
    public sealed class LiteralText : Text
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralText"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public LiteralText(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc />
        public override void Add()
        {
            NativeApi.AddTextComponentSubstringPlayerName(Value);
        }
    }
}
