using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.UI.Enum
{
    /// <summary>
    /// An enumeration of all possible instructional buttons. Mix them manually.
    /// </summary>
    [Flags]
    public enum InstructionalButtons
    {
        /// <summary>
        /// No instructional buttons.
        /// </summary>
        None = 0,
        /// <summary>
        /// A "SELECT" button.
        /// </summary>
        Select = 1,
        /// <summary>
        /// An "OK" button.
        /// </summary>
        OK = 2,
        /// <summary>
        /// Yes button.
        /// </summary>
        Yes = 4,
        /// <summary>
        /// Back button.
        /// </summary>
        Back = 8,
        /// <summary>
        /// Cancel button.
        /// </summary>
        Cancel = 16,
        /// <summary>
        /// No button.
        /// </summary>
        No = 32,
        /// <summary>
        /// Retry button.
        /// </summary>
        Retry = 64,
        /// <summary>
        /// Skip button.
        /// </summary>
        Skip = 256,
        /// <summary>
        /// Continue button.
        /// </summary>
        Continue = 16384,
        /// <summary>
        /// Loading spinner.
        /// </summary>
        LoadingSpinner = 134217728,
    }
}
