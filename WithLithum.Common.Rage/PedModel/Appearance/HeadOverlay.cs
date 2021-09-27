using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage.Exceptions;
using Rage.Native;

namespace WithLithum.Core.PedModel.Appearance
{
    /// <summary>
    /// Provides methods and properties to manipulate head overlay.
    /// </summary>
    public class HeadOverlay
    {
        private readonly HeadBlendCustomizer _customizer;
        private readonly HeadOverlayType _type;

        internal HeadOverlay(HeadBlendCustomizer customizer, HeadOverlayType type)
        {
            _customizer = customizer;
            _type = type;
        }

        /// <summary>
        /// Gets or sets the opacity used when setting <see cref="Index"/> next time. This value will not be effective until next call to <see cref="Index"/>'s setter.
        /// </summary>
        public float Opacity { get; set; } = 1.0f;

        /// <summary>
        /// Gets the index of this instance.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="HeadBlendCustomizer"/> or it's <see cref="GTA.Ped"/> was null, or when <see cref="HeadBlendCustomizer.BasePed"/> was invalid.</exception>
        public int Index
        {
            get
            {
                if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
                if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
                if (!_customizer.BasePed.IsValid()) throw new InvalidOperationException("Customizer base ped was invalid.");

                return NativeFunction.Natives.xA60EF3B6461A4D43<int>(_customizer.BasePed, _type);
            }
            set
            {
                if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
                if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
                if (!_customizer.BasePed.IsValid()) throw new InvalidOperationException("Customizer base ped was invalid.");

                NativeFunction.Natives.x48F44967FA05CC1E(_customizer.BasePed, (int)_type, value, Opacity);
            }
        }

        /// <summary>
        /// Sets the color of this instance. Recommended to call right after setting <see cref="Index"/>. The type of the color is automatically determined based on <see cref="HeadOverlayType"/>.
        /// </summary>
        /// <param name="firstId">The first color Id.</param>
        /// <param name="secondId">The second color Id.</param>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="HeadOverlayType"/> of this instance does not allow colors, or when <see cref="HeadBlendCustomizer"/>'s ped was null.</exception>
        /// <exception cref="InvalidHandleableException">Thrown when the ped of <see cref="HeadBlendCustomizer"/> of this instance invalidates.</exception>
        public void SetColor(int firstId, int secondId)
        {
            if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
            if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
            if (!_customizer.BasePed.IsValid()) throw new InvalidHandleableException(_customizer.BasePed);

            int colorType;
            switch (_type)
            {
                case HeadOverlayType.Eyebrows:
                case HeadOverlayType.FacialHair:
                case HeadOverlayType.ChestHair:
                    colorType = 1;
                    break;
                case HeadOverlayType.Blush:
                case HeadOverlayType.Lipstick:
                    colorType = 2;
                    break;
                default:
                    throw new InvalidOperationException("The type of this instance does not allow colors.");
            }

           NativeFunction.Natives.x497BF74A7B9CB952(_customizer.BasePed, _type, colorType, firstId, secondId);
        }
    }

}
