using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util;

namespace WithLithum.Core.UI.Hud
{
    /// <summary>
    /// Provides utilties to manipulate the loading spinner.
    /// </summary>
    public static class BusySpinner
    {
        /// <summary>
        /// Gets a value indicating whether the busy spinner is currently active.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if busy spinner is currently active; otherwise, <see langword="false"/>.
        /// </value>
        public static bool IsBusySpinnerActive => NativeApi.BusySpinnerIsOn();

        /// <summary>
        /// Displays the busy spinner.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="type">The type of the spinner.</param>
        public static void DisplayBusySpinner(Text text, BusySpinnerType type = BusySpinnerType.Right)
        {
            NativeApi.BeginTextCommandBusyspinnerOn("STRING");
            text.Add();
            NativeApi.EndTextCommandBusyspinnerOn((int)type);
        }

        /// <summary>
        /// Removes the busy spinner. Fails silently if there is no busy spinner.
        /// </summary>
        public static void RemoveBusySpinner()
        {
            if (IsBusySpinnerActive)
            {
                NativeApi.BusyspinnerOff();
            }
        }
    }
}
