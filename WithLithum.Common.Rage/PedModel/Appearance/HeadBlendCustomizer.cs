using System;
using System.Collections.Generic;
using Rage;
using Rage.Exceptions;

namespace WithLithum.Core.PedModel.Appearance
{
    /// <summary>
    /// Provides head blend customization to model the freemode models.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Freemode models have their custom appearance system based on three different main factors:
    /// <list type="bullet">
    ///     <item><see cref="HeadBlend"/> which determines the base shape of the head and face, as well as their race (skin color).</item>
    ///     <item><see cref="FaceFeature"/> which determines extra modifiers of the head and face.</item>
    ///     <item><see cref="HeadOverlay"/> which determines textures and extra addon models added to the face.</item>
    /// </list>
    /// </para>
    /// <para>
    /// This class manages instances of <see cref="FaceFeature"/> and <see cref="HeadOverlay"/> as well as <see cref="HeadBlend"/> in order
    /// to assist the programmer to customize head blend.
    /// </para>
    /// <para>
    /// <note type="note">
    /// GTA Online's system, although is based on this system, is somewhat limited and direct usage of this system may result in
    /// combinations that is impossible in GTA Online.<br />
    /// LSPD First Response, on other hand, uses the mostly same system and same goes to that.
    /// </note>
    /// </para>
    /// </remarks>
    public class HeadBlendCustomizer
    {
        private readonly Dictionary<FaceFeatureType, FaceFeature> _features = new Dictionary<FaceFeatureType, FaceFeature>();
        private readonly Dictionary<HeadOverlayType, HeadOverlay> _overlays = new Dictionary<HeadOverlayType, HeadOverlay>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadBlendCustomizer"/> class.
        /// </summary>
        /// <param name="ped">The ped to customize.</param>
        public HeadBlendCustomizer(Ped ped)
        {
            if (ped == null) throw new ArgumentNullException(nameof(ped));
            if (!ped.IsValid()) throw new InvalidHandleableException(ped);

            BasePed = ped;
            Blend = new HeadBlend(this);

            foreach (FaceFeatureType type in Enum.GetValues(typeof(FaceFeatureType)))
            {
                _features.Add(type, new FaceFeature(this, type));
            }

            foreach (HeadOverlayType type in Enum.GetValues(typeof(HeadOverlayType)))
            {
                _overlays.Add(type, new HeadOverlay(this, type));
            }
        }

        /// <summary>
        /// Gets the ped of this instance.
        /// </summary>
        public Ped BasePed { get; }

        /// <summary>
        /// Gets an instance of <see cref="HeadBlend"/> which can be used to manipulate head blend data of this instance.
        /// </summary>
        /// <remarks>
        /// Multiple calls will return the same instance.
        /// </remarks>
        /// <value>
        /// An instance of <see cref="HeadBlend"/> which can be used to manipulate head blend data of this instance.
        /// </value>
        public HeadBlend Blend { get; }

        /// <summary>
        /// Gets an instance of <see cref="HeadOverlay"/> based on the specified <see cref="HeadOverlayType"/>.
        /// </summary>
        /// <param name="type">The type of the head overlay.</param>
        /// <remarks>
        /// Instances of <see cref="HeadOverlay"/> are created by object constructor and stored first. Thus, two calls with the same
        /// <see cref="HeadOverlayType"/> will return the same instance.
        /// </remarks>
        /// <returns>An instance of <see cref="FaceFeature"/> which can be used to change the value of a specified head overlay.</returns>
        public HeadOverlay this[HeadOverlayType type] => _overlays[type];

        /// <summary>
        /// Gets an instance of <see cref="FaceFeature"/> based on the specified <see cref="FaceFeatureType"/>.
        /// </summary>
        /// <remarks>
        /// Instances of <see cref="FaceFeature"/>  are created by object constructor and stored first. Thus, two calls with the same
        /// <see cref="FaceFeatureType"/> will return the same instance.
        /// </remarks>
        /// <param name="type">The type of the face feature.</param>
        /// <returns>An instance of <see cref="FaceFeature"/> which can be used to change the value of a specified face feature.</returns>
        public FaceFeature this[FaceFeatureType type] => _features[type];
    }

}