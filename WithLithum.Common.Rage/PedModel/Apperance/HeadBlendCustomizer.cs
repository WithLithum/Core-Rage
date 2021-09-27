using System;
using Rage;
using Rage.Exceptions;

namespace WithLithum.Core.PedModel.Apperance
{
    public class HeadBlendCustomizer
    {
        public HeadBlendCustomizer(Ped ped)
        {
            if (ped == null) throw new ArgumentNullException(nameof(ped));
            if (!ped.IsValid()) throw new InvalidHandleableException(ped);

            BasePed = ped;
        }

        public Ped BasePed { get; }
    }
}