using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util
{
    /// <summary>
    /// Provides methods and properties that serves as quick access of various methods and properties.
    /// This class is intended to be imported using <c>using static</c>.
    /// </summary>
    /// <remarks>
    /// Generally, accessing things like player requires the programmer to write long codes. This class provides
    /// several quick accesses that can be used into the code to make the code look clean.
    /// <para>
    /// This class does not work for Visual Basic.
    /// </para>
    /// </remarks>
    public static class Quicks
    {
        /// <summary>
        /// Gets the <see cref="Rage.Ped"/> controlled by the player.
        /// </summary>
        public static Ped MainChara => Game.LocalPlayer.Character;

        /// <summary>
        /// Gets an instance of <see cref="Rage.Player"/> representing the local player.
        /// </summary>
        public static Player PInstance => Game.LocalPlayer;
    }
}
