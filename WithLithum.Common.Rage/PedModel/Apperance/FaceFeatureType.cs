namespace WithLithum.Core.PedModel.Apperance
{
    /// <summary>
    /// An enumeration of all possible face feature types.
    /// </summary>
    public enum FaceFeatureType
    {
        /// <summary>
        /// The width of the nose. Set to <c>-1.0</c> for narrow, <c>1.0</c> for wide.
        /// </summary>
        NoseWidth,
        /// <summary>
        /// The height of the nose. Set to <c>-1.0</c> for top, <c>1.0</c> for bottom.
        /// </summary>
        NoseHeight,
        /// <summary>
        /// The length of the nose. Set to <c>-1.0</c> for grand, <c>1.0</c> for petite.
        /// </summary>
        NoseLength,
        /// <summary>
        /// The nose bridge. Set to <c>-1.0</c> for round, <c>1.0</c> for hollow.
        /// </summary>
        NoseBridge,
        /// <summary>
        /// The tip of the nose. Set to <c>-1.0</c> for upward, <c>1.0</c> for downward.
        /// </summary>
        NoseTip,
        /// <summary>
        /// The shift of the nose bridge. Set to <c>-1.0</c> to shift left, <c>1.0</c> to shift right.
        /// </summary>
        NoseBridgeShift,
        /// <summary>
        /// The height of the brow. Set to <c>-1.0</c> for top, <c>1.0</c> for bottom.
        /// </summary>
        BrowHeight,
        /// <summary>
        /// The width of the brow. Set to <c>-1.0</c> for inward, <c>1.0</c> for outward.
        /// </summary>
        BrowWidth,
        /// <summary>
        /// The height of the cheekbone. Set to <c>-1.0</c> for top, <c>1.0</c> for bottom.
        /// </summary>
        CheekboneHeight,
        /// <summary>
        /// The width of the cheekbone. Set to <c>-1.0</c> for narrow, <c>1.0</c> for wide.
        /// </summary>
        CheekboneWidth,
        /// <summary>
        /// The width of the cheeks. Set to <c>-1.0</c> for wide, <c>1.0</c> for narrow.
        /// </summary>
        CheeksWidth,
        /// <summary>
        /// The size of the eyes. Set to <c>-1.0</c> for fully opened eyes, <c>1.0</c> for nearly closed eyes.
        /// </summary>
        Eyes,
        /// <summary>
        /// The thicknes of the lips. Set to <c>-1.0</c> for wide, <c>1.0</c> for narrow.
        /// </summary>
        Lips,
        /// <summary>
        /// The width of the jaw. Set to <c>-1.0</c> for narrow, <c>1.0</c> for wide.
        /// </summary>
        JawWidth,
        /// <summary>
        /// The height of the cheekbone. Set to <c>-1.0</c> for top, <c>1.0</c> for bottom.
        /// </summary>
        JawHeight,
        /// <summary>
        /// The length of the chin. Set to <c>-1.0</c> for small chin, <c>1.0</c> for long chin.
        /// </summary>
        ChinLength,
        /// <summary>
        /// The position of the chin. Set to <c>-1.0</c> for inward, <c>1.0</c> for outward.
        /// </summary>
        ChinPosition,
        /// <summary>
        /// The width of the chin. Set to <c>-1.0</c> for narrow, <c>1.0</c> for grand.
        /// </summary>
        ChinWidth,
        /// <summary>
        /// The shape of the jaw. Set to <c>-1.0</c> for simple chin, <c>1.0</c> for double chin.
        /// </summary>
        ChinShape,
        /// <summary>
        /// The width of the neck. Set to <c>-1.0</c> for narrow, <c>1.0</c> for wide.
        /// </summary>
        NeckWidth
    }

}
