namespace Maple.WzSchema;

/// <summary>
/// WZ property descriptors for Reactor.wz/{id:D7}.img/ nodes.
/// Nested classes mirror the WZ node hierarchy.
/// </summary>
public static class ReactorKeys
{
    // Root node name for Reactor archive navigation
    public const string Root = "Reactor";
    public const string RootImg = "Reactor.img";

    // Root-level key (not under info/): required active quest ID to interact with the reactor.
    public static readonly WzProperty<int> QuestId = new("quest", 0);

    /// <summary>Properties under Reactor.wz/{id}.img/info/</summary>
    public static class Info
    {
        public const string NodeName = CommonKeys.Info;

        // ── Template redirect ──────────────────────────────────────
        public static readonly WzProperty<int> Link = new("link", 0);

        // ── Behavioral flags ──────────────────────────────────────
        public static readonly WzPresenceFlag ActivateByTouch = new("activateByTouch");
        public static readonly WzPresenceFlag CanMove = new("move");
        public static readonly WzPresenceFlag NotHitable = new("notHitable");
        public static readonly WzPresenceFlag RemoveInFieldSet = new("removeInFieldSet");

        // ── Integer properties ────────────────────────────────────
        public static readonly WzProperty<int> Layer = new("layer", 0);
        public static readonly WzProperty<int> StateCount = new("stateCount", 0);

        // ── String properties ─────────────────────────────────────
        public const string Action = "action";
    }

    /// <summary>
    /// Properties under each state node Reactor.wz/{id}.img/{stateIndex}/.
    /// State nodes are identified by numeric-string names ("0", "1", "2", …).
    /// </summary>
    public static class State
    {
        public static readonly WzPresenceFlag Repeat = new("repeat");

        /// <summary>
        /// Auto-transition timeout in milliseconds.
        /// If nonzero, the state automatically triggers the next-state event after this delay.
        /// </summary>
        public static readonly WzProperty<int> Timeout = new("timeout", 0);

        /// <seealso cref="Event"/>
        public const string EventNode = "event";
    }

    /// <summary>
    /// Properties under reactor event nodes Reactor.wz/{id}.img/{stateIndex}/event/{eventIndex}/.
    /// </summary>
    public static class Event
    {
        /// <summary>Integer key <c>"0"</c> for the event's trigger type.</summary>
        public static readonly WzProperty<int> Type = new("0", 0);

        /// <summary>Archive target state index this event transitions to. Uses the WZ key <c>"state"</c>.</summary>
        public static readonly WzProperty<int> NextState = new("state", 0);
        public const string ActiveSkillId = "activeSkillID";

        // ── Hit area — WZ point nodes 'lt' and 'rb' at event node level ──
        // lt = top-left point, rb = bottom-right point
        // Resolved via ResolveVector() -> (x, y)
        public const string CheckRectLt = "lt";
        public const string CheckRectRb = "rb";

        // ── Item requirement ──────────────────────────────────────────────
        public const string ItemId = "itemID";
        public const string ItemIdAlt = "nItemID";
        public const string ItemCount = "itemCount";
        public const string ItemCountAlt = "nItemCount";
    }

    /// <summary>
    /// Properties under each animation frame node Reactor.wz/{id}.img/{stateIndex}/{frameIndex}/.
    /// </summary>
    public static class Frame
    {
        public static readonly WzProperty<int> Delay = new("delay", 100);
        public const string Origin = CommonKeys.Origin;
        public static readonly WzProperty<int> Z = new("z", 0);

        /// <summary>Alpha at frame start (0-255). Default <c>-1</c> means no effect.</summary>
        public static readonly WzProperty<int> A0 = new("a0", -1);

        /// <summary>Alpha at frame end (0-255). Default <c>-1</c> means no effect.</summary>
        public static readonly WzProperty<int> A1 = new("a1", -1);
    }
}
