using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Native;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Provides extensions to <see cref="Rage.Vehicle"/>.
    /// </summary>
    public static class VehicleExtensions
    {
        /// <summary>
        /// Gets the localized display name of the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>The display name of vehicle, or <see langword="null"/> if not found.</returns>
        public static string GetDisplayName(this Vehicle vehicle)
        {
            var name = NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(vehicle.Model.Hash);
            if (string.IsNullOrWhiteSpace(name) || name == "CARNOTFOUND")
            {
                return null;
            }

            return Game.GetLocalizedString(name);
        }

        /// <summary>Tries to get the display name of specified vehicle model.</summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        ///   <para>Returns true if a proper name has been found; otherwise, false.</para>
        /// </returns>
        public static bool TryGetDisplayNameOfVehicleModel(this Vehicle vehicle, out string result)
        {
            var name = NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(vehicle.Model.Hash);
            if (name == "CARNOTFOUND")
            {
                result = string.Empty;
                return false;
            }

            var tempResult = Game.GetLocalizedString(name);
            if (string.IsNullOrWhiteSpace(tempResult))
            {
                result = string.Empty;
                return false;
            }

            result = tempResult;
            return true;
        }
    }
}
