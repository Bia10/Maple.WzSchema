namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Map domain (String.wz / Map.wz).
/// Organised into nested classes by sub-domain: Info, Foothold, Tile, Obj, Life, Portal,
/// Background, Reactor, Swim, Ship, Clock, Physics, and Carnival.
/// </summary>
public static class MapKeys
{
    // ── Archive roots ─────────────────────────────────────────────────────────
    public const string Root = "Map";
    public const string MapStringImg = "Map.img";
    public const string TilePackageRoot = "Tile";
    public const string ObjPackageRoot = "Obj";
    public const string BackPackageRoot = "Back";
    public const string MapHelper = "MapHelper";
    public const string MapHelperImg = "MapHelper.img";

    // Physics archive — both .img and plain variants exist
    public const string PhysicsImg = "Physics.img";
    public const string Physics = "Physics";

    // ── String.wz per-map props ───────────────────────────────────────────────
    public const string StreetName = "streetName";
    public const string MapName = "mapName";
    public const string Help = "help";

    // ── Top-level map child node names ────────────────────────────────────────
    // Case variants exist in WZ vs NX — always search with both.
    public const string InfoNode = "info";
    public const string InfoNodeAlt = "Info";
    public const string LifeNode = "life";
    public const string LifeNodeAlt = "Life";
    public const string PortalNode = "portal";
    public const string PortalNodeAlt = "Portal";
    public const string FootholdNode = "foothold";
    public const string FootholdNodeAlt = "Foothold";
    public const string TileNode = "tile";
    public const string ObjNode = "obj";
    public const string LadderRopeNode = "ladderRope";
    public const string LadderRopeNodeAlt = "LadderRope";
    public const string BackgroundNode = "back";
    public const string BackgroundNodeAlt = "background";
    public const string BackgroundNodeAlt2 = "Background";
    public const string ReactorNode = "reactor";
    public const string ReactorNodeAlt = "Reactor";
    public const string MapAreaNode = "mapArea";
    public const string MapAreaNodeAlt = "area";
    public const string MiniMapNode = "miniMap";
    public const string MiniMapNodeAlt = "MiniMap";

    /// <summary>Keys used within the miniMap sub-node of map WZ data.</summary>
    public static class MiniMap
    {
        public const string CenterX = "centerX";
        public const string CenterY = "centerY";
        public const string Mag = "mag";
        public const string Width = "width";
        public const string Height = "height";

        /// <summary>Bitmap canvas node within the miniMap sub-node (RE-confirmed §9.9).</summary>
        public const string Canvas = "canvas";
    }

    public const string ShipNode = "ship";
    public const string ClockNode = "clock";
    public const string HealerNode = "healer";
    public const string PulleyNode = "pulley";
    public const string MonsterCarnivalNode = "monsterCarnival";

    // Optional info sub-nodes
    public const string HelpMsgNode = "help";
    public const string HelpMsgNodeAlt = "helpMsg";
    public const string SeatNode = "seat";
    public const string SeatNodeAlt = "seatInfo";
    public const string AllowedItemNode = "allowedItem";
    public const string AllowedItemNodeAlt = "allowedItemList";

    // Catalog §5.1 ✅ PDB-confirmed WZ key (info/forbiddenSkill/, C++ m_siForbiddenSkill)
    public const string ForbidSkillNode = "forbiddenSkill";
    public const string ForbidSkillNodeAlt = "forbidSkill";
    public const string ForbidSkillNodeAlt2 = "forbidSkills";

    // Catalog §5.1A ✅ PDB-confirmed WZ key (swimArea/{N}, C++ m_aSwimRect)
    public const string SwimRectNode = "swimArea";
    public const string SwimRectNodeAlt = "swimRect";
    public const string AutoLieDetectorNode = "autoLieDetector";

    // ── World map child node names ───────────────────────────────────────────
    public static class WorldMap
    {
        public const string Root = "WorldMap";
        public const string MapListNode = "MapList";
        public const string SpotNode = "spot";
        public const string MapNo = "mapNo";
        public const string BaseImgNode = "BaseImg";
        public const string MapLinkNode = "mapLink";
        public const string ToolTip = "toolTip";
        public const string LinkMap = "linkMap";
        public const string LinkImg = "linkImg";
    }

    // ── Map info props ────────────────────────────────────────────────────────
    public static class Info
    {
        // View bounds — WZ key names are SCREAMING_CAPS; kept verbatim for client loader compatibility.
        public const string VRLeft = "VRLeft";
        public const string VRTop = "VRTop";
        public const string VRRight = "VRRight";
        public const string VRBottom = "VRBottom";

        // String.wz text props (also exist as root-level MapKeys.StreetName/MapName)
        public const string StreetName = "streetName";
        public const string MapName = "mapName";

        // Field flags (boolean)
        public static readonly WzPresenceFlag Town = new("town");
        public static readonly WzPresenceFlag Swim = new("swim");
        public static readonly WzPresenceFlag Fly = new("fly");
        public const string FieldLimit = "fieldLimit";
        public const string ReturnMap = "returnMap";
        public const string Bgm = "bgm";
        public const string FieldType = "fieldType";
        public const string TimeLimit = "timeLimit";
        public const string LvLimit = "lvLimit";
        public const string OnUserEnter = "onUserEnter";
        public const string OnFirstUserEnter = "onFirstUserEnter";
        public static readonly WzPresenceFlag HideMinimap = new("hideMinimap");
        public static readonly WzPresenceFlag NeedSkillForFly = new("needSkillForFly");
        public static readonly WzPresenceFlag PersonalShop = new("personalShop");
        public static readonly WzPresenceFlag DropEverlast = new("dropEverlast");
        public const string ForcedReturn = "forcedReturn";
        public const string Recovery = "recovery";
        public const string RecoveryAlt = "recoveryRate";

        /// <summary>
        /// PDB-confirmed WZ key for HP reduction per tick on hazard maps (schema §5.1, C++ field <c>m_nReduceHPAmount</c>).
        /// Use with all alt spellings via <c>ResolveIntOrStringFirst</c>.
        /// </summary>
        public const string ReduceHpPdb = "ReduceHP";
        public const string DecHp = "decHP";
        public const string DecHpAlt = "reduceHP";
        public const string DecHpAlt2 = "reduceHPAmount";
        public const string NoWeather = "noWeather";
        public const string NoWeatherAlt = "noCashWeather";
        public const string NoWeatherAlt2 = "cannotUseCashWeather";
        public const string ExpeditionOnly = "expeditionOnly";
        public const string ConsumeItemCoolTime = "consumeItemCoolTime";
        public const string MobRate = "mobRate";
        public const string FixedMobCapacity = "fixedMobCapacity";
        public const string PartyOnly = "partyOnly";
        public const string Everlast = "everlast";
        public const string WeatherItemId = "weatherItemID";
        public const string ProtectItem = "protectItem";
        public const string HasBoat = "hasBoat";
        public const string BoatType = "boatType";
        public const string MirrorBottom = "mirror_Bottom";
        public const string ReactorShuffle = "reactorShuffle";
        public const string Cloud = "cloud";
        public const string NoMapCmd = "noMapCmd";
        public const string LvForceMove = "lvForceMove";
        public const string MoveLimit = "moveLimit";
        public const string Link = "link";
        public const string MapDesc = "mapDesc";
        public const string MapSpecificEffect = "mapSpecificEffect";
        public const string Version = "version";
        public const string Fs = "fs";

        // Viewport / capacity
        public const string NSide = "nSide";
        public const string NTop = "nTop";
        public const string NBottom = "nBottom";
        public const string MobCapacityMin = "mobCapacityMin";
        public const string MobCapacityMax = "mobCapacityMax";
        public const string ViewMobLevel = "viewMobLevel";

        // Catalog §5.1 ✅ PDB-confirmed WZ keys
        public const string MapMark = "mapMark";
        public const string Phase = "phase";
        public const string PhaseAlpha = "phaseAlpha";
        public const string PqStay = "pqStay";

        // Layer-level info node
        public const string TileSet = "tS";
        public const string TileSetAlt = "bS";
    }

    // ── Foothold entry props ──────────────────────────────────────────────────
    public static class Foothold
    {
        public const string X1 = "x1";
        public const string Y1 = "y1";
        public const string X2 = "x2";
        public const string Y2 = "y2";
        public const string CantThrough = "cant_through";
        public const string Prev = "prev";
        public const string Next = "next";
        public const string Force = "force";
        public const string Piece = "piece";

        // Catalog §5.3 ✅ PDB-confirmed WZ keys
        public const string Drag = "drag";
        public const string Walk = "walk";
        public const string ForbidFallDown = "forbidFallDown";
    }

    // ── Tile entry props ──────────────────────────────────────────────────────
    public static class Tile
    {
        /// <summary>Tile set name (WZ key: <c>tS</c>).</summary>
        public const string TileSet = "tS";

        /// <summary>Tile variant / sub-type within the tile set (WZ key: <c>u</c>).</summary>
        public const string U = "u";

        /// <summary>Alias for <see cref="U"/> used by client loaders (WZ key: <c>u</c>).</summary>
        public const string Variant = "u";
        public const string No = "no";
        public const string X = "x";
        public const string Y = "y";
        public const string ZM = "zM";
        public const string FlipH = "f";
    }

    // ── Object entry props ────────────────────────────────────────────────────
    public static class Obj
    {
        public const string ObjSet = "oS";
        public const string L0 = "l0";
        public const string L1 = "l1";
        public const string L2 = "l2";
        public const string X = "x";
        public const string Y = "y";
        public const string Z = "z";
        public const string ZM = "zM";
        public const string FlipH = "f";

        /// <summary>Short alias for <see cref="FlipH"/> (WZ key: <c>f</c>).</summary>
        public const string F = "f";

        public const string Alpha = "a";

        /// <summary>Short alias for <see cref="Alpha"/> (WZ key: <c>a</c>).</summary>
        public const string A = "a";

        public const string Rx = "rx";
        public const string Ry = "ry";
        public const string IsReactive = "r";
        public const string MoveType = "moveType";
        public const string MoveP = "move_p";
        public const string IsDynamic = "dynamic";
        public const string Piece = "piece";
        public const string Name = "name";
        public const string IsHidden = "hide";
        public const string HasFlow = "flow";
        public const string QuestId = "quest";
    }

    // ── Ladder/rope entry props ───────────────────────────────────────────────
    public static class LadderRope
    {
        /// <summary>Horizontal position of the vertical climb line (V95 RE confirmed: single <c>x</c> field, not <c>x1</c>/<c>x2</c>).</summary>
        public const string X = "x";
        public const string Y1 = "y1";
        public const string Y2 = "y2";
        public const string Page = "page";
        public const string IsLadder = "l";

        /// <summary>Alias for <see cref="IsLadder"/> used by client rendering code.</summary>
        public const string L = "l";

        /// <summary>Can enter from below (rope/ladder direction flag).</summary>
        public const string D = "d";
        public const string UpperFoothold = "uf";
    }

    // ── Portal entry props ────────────────────────────────────────────────────
    public static class Portal
    {
        public const string GameNode = "game";
        public const string EditorNode = "editor";
        public const string Name = "pn";
        public const string NameAlt = "name";
        public const string Type = "pt";
        public const string X = "x";
        public const string Y = "y";
        public const string TargetMap = "tm";

        /// <summary>Alias for <see cref="TargetMap"/> used by client loader code.</summary>
        public const string TargetMapId = "tm";
        public const string TargetName = "tn";

        /// <summary>Alias for <see cref="TargetName"/> used by client loader code.</summary>
        public const string TargetPortalName = "tn";
        public const string Script = "script";
        public const string OnlyOnce = "onlyOnce";
        public const string Delay = "delay";
        public const string HideTooltip = "hideTooltip";
        public const string ReactorName = "reactorName";
        public const string SessionValueKey = "sessionValueKey";
        public const string SessionValue = "sessionValue";
        public const string HRange = "hRange";
        public const string VRange = "vRange";
        public const string Image = "image";
        public const string VImpact = "vImpact";
        public const string HImpact = "hImpact";
    }

    // ── Background entry props ────────────────────────────────────────────────
    public static class Background
    {
        public const string BgSet = "bS";
        public const string No = "no";
        public const string Type = "type";
        public const string IsFront = "front";
        public const string IsAnim = "ani";
        public const string X = "x";
        public const string Y = "y";
        public const string Rx = "rx";
        public const string Ry = "ry";
        public const string Cx = "cx";
        public const string Cy = "cy";
        public const string Flip = "f";
        public const string Alpha = "a";
        public const string Back = "back";
        public const string ScreenMode = "screenMode";
        public const string MoveT = "moveT";
        public const string R = "r";
        public const string Period = "period";
        public const string CenterStart = "centerstart";
    }

    // ── Background entry props (client alias) ────────────────────────────────
    /// <summary>
    /// Client-facing alias for <see cref="Background"/> with short field names
    /// matching the client renderer's <c>MapKeys.Back.*</c> references.
    /// WZ values are identical — this is a naming convenience only.
    /// </summary>
    public static class Back
    {
        /// <summary>Bitmap set name (WZ key: <c>bS</c>).</summary>
        public const string BitmapSet = "bS";
        public const string No = "no";
        public const string Type = "type";
        public const string Front = "front";
        public const string Ani = "ani";
        public const string X = "x";
        public const string Y = "y";
        public const string Rx = "rx";
        public const string Ry = "ry";
        public const string Cx = "cx";
        public const string Cy = "cy";

        /// <summary>Flip-H flag (WZ key: <c>f</c>).</summary>
        public const string F = "f";

        /// <summary>Alpha / opacity (WZ key: <c>a</c>).</summary>
        public const string A = "a";
        public const string ScreenMode = "screenMode";
        public const string MoveT = "moveT";
        public const string R = "r";
        public const string Period = "period";
        public const string CenterStart = "centerstart";
    }

    // ── Life entry props ──────────────────────────────────────────────────────
    public static class Life
    {
        public const string Type = "type";
        public const string Id = "id";
        public const string X = "x";
        public const string Y = "y";
        public const string Fh = "fh";
        public const string Cy = "cy";
        public const string Rx0 = "rx0";
        public const string Rx1 = "rx1";
        public const string FaceDir = "f";
        public const string Hide = "hide";
        public const string MobTime = "mobTime";
        public const string Team = "team";

        // Type string values
        public const string TypeNpc = "n";
        public const string TypeMob = "m";
    }

    // ── Reactor entry props ───────────────────────────────────────────────────
    public static class Reactor
    {
        public const string Id = "id";
        public const string X = "x";
        public const string Y = "y";
        public const string F = "f";
        public const string Name = "name";
        public const string ReactorTime = "reactorTime";
    }

    // ── Ship data props ───────────────────────────────────────────────────────
    public static class Ship
    {
        public const string ShipObj = "shipObj";
        public const string ShipKind = "shipKind";
        public const string TMove = "tMove";
        public const string X = "x";
        public const string X0 = "x0";
        public const string Y = "y";
        public const string Z = "z";
        public const string TAppear = "tAppear";
        public const string Flip = "f";
        public const string LimitX0 = "limit_x0";
        public const string LimitX = "limit_x";
        public const string LimitY0 = "limit_y0";
        public const string LimitY = "limit_y";
    }

    // ── Clock data props ──────────────────────────────────────────────────────
    public static class Clock
    {
        public const string X = "x";
        public const string Y = "y";
        public const string Width = "width";
        public const string Height = "height";
    }

    // ── Swim rect props ───────────────────────────────────────────────────────
    /// <summary>
    /// Keys used within each swimArea/{N}/ child node.
    /// <list type="bullet">
    ///   <item><c>Lt</c> / <c>Rb</c> — WZ vector point nodes (preferred; PDB CField::LoadSwimArea uses these).</item>
    ///   <item><c>L/T/R/B</c> — individual int children, present in some WZ revisions.</item>
    ///   <item><c>X/Y</c> — centre-point variant used by a small number of maps.</item>
    /// </list>
    /// Callers should try <c>Lt</c>/<c>Rb</c> first, fall back to <c>L/T/R/B</c>.
    /// </summary>
    public static class SwimRect
    {
        public const string L = "l";
        public const string T = "t";
        public const string R = "r";
        public const string B = "b";
        public const string Lt = "lt";
        public const string Rb = "rb";
        public const string X = "x";
        public const string Y = "y";
    }

    // ── Monster Carnival props ────────────────────────────────────────────────
    public static class Carnival
    {
        public const string TimeLimit = "timeLimit";
        public const string GuardianGenMax = "guardianGenMax";
        public const string PointVersionUp = "pointVersionUp";
        public const string CpThresholdNode = "cpQ";
        public const string GuardianGenPosNode = "guardianGenPos";
        public const string GuardianNode = "guardian";
        public const string SkillNode = "skill";
        public const string MobNode = "mob";
        public const string Id = "id";

        // MC shop entry
        public const string Name = "name";
        public const string Desc = "desc";
        public const string SpendCp = "spendCP";
        public const string X = "x";
        public const string Y = "y";
    }

    // ── Healer props ──────────────────────────────────────────────────────────
    public static class Healer
    {
        public const string X = "x";

        /// <summary>
        /// WZ key confirmed as <c>"ymin"</c> (PDB-verified from <c>CField_GuildBoss::Init</c>).
        /// Earlier revisions of the schema catalog listed <c>"y"</c>.
        /// </summary>
        public const string Y = "ymin";
    }

    // ── Pulley props ──────────────────────────────────────────────────────────
    public static class Pulley
    {
        public const string X = "x";
        public const string Y = "y";
        public const string Hp = "hp";
    }

    // ── Seat props ────────────────────────────────────────────────────────────
    public static class Seat
    {
        public const string X = "x";
        public const string Y = "y";
    }

    // ── Top-level section navigation ─────────────────────────────────────────
    /// <summary>
    /// Top-level child node names within a <c>{mapId}.img</c> node.
    /// Mirrors the WZ map hierarchy used by loaders to navigate sections.
    /// </summary>
    public static class Section
    {
        public const string Info = "info";
        public const string Foothold = "foothold";
        public const string Portal = "portal";
        public const string LadderRope = "ladderRope";
        public const string Back = "back";
        public const string MiniMap = "miniMap";
        public const string Tile = "tile";
        public const string Obj = "obj";
        public const string Life = "life";

        /// <summary>Format prefix for per-layer nodes: <c>layer{0..7}</c>.</summary>
        public const string LayerPrefix = "layer";
    }

    // ── Portal sprite paths ───────────────────────────────────────────────────
    /// <summary>
    /// WZ paths and sub-keys for portal visual sprites under
    /// <c>Map.wz/MapHelper.img/portal/game/</c>.
    /// </summary>
    public static class PortalSprite
    {
        /// <summary>Root path: <c>Map/MapHelper.img/portal/game</c>.</summary>
        public const string Root = "Map/MapHelper.img/portal/game";

        public const string Sp = "sp";
        public const string Pv = "pv";
        public const string Cp = "cp";
        public const string Tp = "tp";
        public const string Ph = "ph";
        public const string Psh = "psh";

        /// <summary>Animation phase sub-keys within each portal category.</summary>
        public const string Enter = "enter";
        public const string Idle = "idle";
        public const string Exit = "exit";
        public const string Default = "default";
    }

    // ── Cloud / weather sprite ────────────────────────────────────────────────
    /// <summary>Paths for cloud/weather sprites in <c>Map.wz</c>.</summary>
    public static class Cloud
    {
        /// <summary>Cloud sprite source: <c>Obj/cloud.img</c>.</summary>
        public const string ImgPath = "Obj/cloud.img";
    }

    // ── Asset path prefixes ───────────────────────────────────────────────────
    /// <summary>Path prefixes for map assets referenced by tile/obj/back node fields.</summary>
    public static class AssetPath
    {
        public const string Back = "Back/";
        public const string Tile = "Tile/";
        public const string Obj = "Obj/";
    }

    // ── Sprite frame sub-keys ─────────────────────────────────────────────────
    /// <summary>
    /// Per-frame sub-node fields shared by map sprite animation frames.
    /// </summary>
    public static class Frame
    {
        /// <summary>Frame duration in milliseconds.</summary>
        public const string Delay = "delay";

        /// <summary>Anchor-point vector for sprite positioning.</summary>
        public const string Origin = "origin";
    }
}
