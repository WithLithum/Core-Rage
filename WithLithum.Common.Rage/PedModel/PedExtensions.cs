using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Exceptions;
using WithLithum.Core.PedModel.Appearance;

namespace WithLithum.Core.PedModel
{
    /// <summary>
    /// Provide extension methods to <see cref="Rage.Ped"/> class.
    /// </summary>
    public static class PedExtensions
    {
        private static readonly Dictionary<Ped, HeadBlendCustomizer> _customizers = new Dictionary<Ped, HeadBlendCustomizer>();

        /// <summary>
        /// Receives an instance of <see cref="HeadBlendCustomizer"/> which can be used to edit the face features,
        /// head blend datas, etc. of this instance.
        /// </summary>
        /// <param name="ped">The ped.</param>
        /// <returns>An instance of <see cref="HeadBlendCustomizer"/>. Multiple calls with the same ped are not guaranteed to return the same instance.</returns>
        public static HeadBlendCustomizer HeadBlend(this Ped ped)
        {
            if (ped == null)
            {
                _customizers.Remove(ped);
                throw new ArgumentNullException(nameof(ped));
            }

            if (!ped.IsValid())
            {
                _customizers.Remove(ped);
                throw new InvalidHandleableException(ped);
            }

            if (_customizers.ContainsKey(ped))
            {
                return _customizers[ped];
            }
            else
            {
                var customizer = new HeadBlendCustomizer(ped);
                _customizers.Add(ped, customizer);
                return customizer;
            }
        }
    }

}
