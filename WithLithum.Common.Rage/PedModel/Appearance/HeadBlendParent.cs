namespace WithLithum.Core.PedModel.Appearance
{
    /// <summary>
    /// An enumeration of all possible parents in head blend configuration.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Freemode peds' head blend is constructed of a basic blend of two parents, and <see cref="FaceFeature"/>s.
    /// </para>
    /// <note type="important">This list may not be accurate, or even totally incorrect, because this list is simply chronologically ordered instead of tested actually.<br />
    /// For more information, see <see href="https://gtaforums.com/topic/858970-all-gtao-face-ids-pedset_ped_head_blend_data-explained">this topic</see> on GTAForums.</note>
    /// <para>
    /// GTA Online restricts parents to be one male and one female, much like in the real life. However, the game engine does not enforce
    /// that restriction on natives which the library based on. As result, combinations that are impossible in GTA Online such as two mothers are
    /// possible.
    /// </para>
    /// <note type="warning">
    /// The original author of this order made the list against <b>Simple Trainer V</b> which begins all indexs by <b>1</b>. The list may needs to be validated
    /// and sees if the list is <b>actually begins from 1 at all</b>.
    /// </note>
    /// </remarks>
    /// <seealso cref="HeadBlend"/>
    /// <seealso cref="HeadBlendCustomizer"/>
    public enum HeadBlendParent
    {
        /// <summary>
        /// One of the parents.
        /// He has the ID of 1.
        /// </summary>
        Benjamin = 1,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Daniel,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Joshua,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Noah,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Andrew,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Juan,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Alex,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Isaac,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Evan,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Ethan,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Vincent,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Angel,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Diego,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Adrian,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Gabriel,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Michael,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Santiago,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Kevin,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Louis,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Samuel,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Anthony,
        /// <summary>
        /// A mother. She has an ID of 22.
        /// </summary>
        Hannah,
        /// <summary>
        /// One of the parents. They have an ID of 23.
        /// </summary>
        Audrey,
        /// <summary>
        /// One of the parents. They have an ID of 24.
        /// </summary>
        Jasmine,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Giselle,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Amelia,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Isabella,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Zoe,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Ava,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Camila,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Violet,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Sophia,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Evelyn,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Nicole,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Ashley,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Grace,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Brianna,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Natalie,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Olivia,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Elizabeth,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Charlotte,
        /// <summary>
        /// One of the parents.
        /// </summary>
        Emma,
        /// <summary>
        /// A father. He's the protagonist of Grand Theft Auto III.
        /// He has an ID of 43.
        /// </summary>
        Claude,
        /// <summary>
        /// A father. He's the protagonist of Grand Theft Auto IV.
        /// He has an ID of 44.
        /// </summary>
        Niko,
        /// <summary>
        /// One of the parents.
        /// </summary>
        John,
        /// <summary>
        /// A mother. She's one of the characters in Grand Theft Auto III.
        /// She has an ID of 46.
        /// </summary>
        Misty
    }

}
