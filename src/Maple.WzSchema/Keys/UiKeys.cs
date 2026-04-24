namespace Maple.WzSchema;

/// <summary>
/// WZ node key constants for <c>UI.wz</c> node navigation across all UI loaders.
/// Source: PDB-verified symbol names and RE-confirmed paths.
/// </summary>
public static class UiKeys
{
    // ── Common WZ canvas conventions ──────────────────────────────────────────

    /// <summary>Universal WZ canvas child keys used across all .img files.</summary>
    public static class Canvas
    {
        /// <summary>Hot-spot / anchor point vector on a canvas sprite.</summary>
        public const string Origin = "origin";
    }

    /// <summary>Standard button state sub-node names (4-state interactive sprites).</summary>
    public static class ButtonState
    {
        public const string Normal = "normal";
        public const string MouseOver = "mouseOver";
        public const string Pressed = "pressed";
        public const string Disabled = "disabled";
    }

    // ── StatusBar2.img ────────────────────────────────────────────────────────

    /// <summary>Keys under <c>UI.wz/StatusBar2.img/</c>.</summary>
    public static class StatusBar
    {
        /// <summary>Root path for the main HUD bar: <c>StatusBar2.img/mainBar</c>.</summary>
        public const string MainBar = "StatusBar2.img/mainBar";

        /// <summary>Gauge sub-node names under <c>mainBar/</c>.</summary>
        public static class Gauge
        {
            public const string Hp = "gaugeHP";
            public const string Mp = "gaugeMP";
            public const string Exp = "gaugeEXP";

            /// <summary>Three child keys per gauge: left cap, center fill, right cap.</summary>
            public const string Left = "0";
            public const string Center = "1";
            public const string Right = "2";
        }

        /// <summary>Level number digit sprites: <c>mainBar/lvNumber/{0–9}</c>.</summary>
        public const string LvNumber = "lvNumber";

        /// <summary>Cooltime overlay format: <c>mainBar/cooltime{0..15}</c>.</summary>
        public const string CooltimePrefix = "cooltime";

        /// <summary>Button sub-paths under <c>mainBar/</c>.</summary>
        public static class Buttons
        {
            public const string BtCharacter = "BtCharacter";
            public const string BtStat = "BtStat";
            public const string BtQuest = "BtQuest";
            public const string BtInven = "BtInven";
            public const string BtEquip = "BtEquip";
            public const string BtSkill = "BtSkill";
            public const string BtKeysetting = "BtKeysetting";
            public const string BtChannel = "BtChannel";
            public const string BtCashShop = "BtCashShop";
            public const string BtMenu = "BtMenu";
            public const string BtSystem = "BtSystem";
            public const string BtMTS = "BtMTS";
            public const string BtChat = "BtChat";
            public const string BtClaim = "BtClaim";
            public const string ChatOpen = "chatOpen";
            public const string ChatClose = "chatClose";
        }

        /// <summary>Chat filter tab paths under <c>StatusBar2.img/chat/Tap/</c>.</summary>
        public static class ChatTab
        {
            public const string Root = "StatusBar2.img/chat/Tap";
            public const string All = "all";
            public const string Friend = "friend";
            public const string Party = "party";
            public const string Guild = "guild";
            public const string Association = "association";
            public const string Expedition = "expedition";
        }
    }

    // ── Basic.img ─────────────────────────────────────────────────────────────

    /// <summary>Keys under <c>UI.wz/Basic.img/</c>.</summary>
    public static class Basic
    {
        public const string Cursor = "Basic.img/Cursor";
        public const string Checkbox = "Basic.img/Check";
    }

    // ── UIWindow2.img ─────────────────────────────────────────────────────────

    /// <summary>Keys under <c>UI.wz/UIWindow2.img/MiniMap</c>.</summary>
    public static class MiniMap
    {
        public const string Root = "UIWindow2.img/MiniMap";
        public const string BtMinimize = "BtMinimize";
        public const string BtMaximize = "BtMaximize";
        public const string BtWorldMap = "BtWorldMap";

        public const string SimpleFrameRoot = "UIWindow2.img/MiniMapSimpleMode/Window";
        public const string SimpleNormal = "Normal";

        /// <summary>8-piece corner/edge keys for simple-mode frame.</summary>
        public static class SimpleFrame
        {
            public const string UpLeft = "UpLeft";
            public const string UpRight = "UpRight";
            public const string DownLeft = "DownLeft";
            public const string DownRight = "DownRight";
            public const string UpCenter = "UpCenter";
            public const string DownCenter = "DownCenter";
            public const string MiddleLeft = "MiddleLeft";
            public const string MiddleRight = "MiddleRight";
        }
    }

    // ── Login.img ─────────────────────────────────────────────────────────────

    /// <summary>Keys under <c>UI.wz/Login.img/</c> (login flow screens).</summary>
    public static class Login
    {
        public static class Common
        {
            public const string Root = "Common";
            public const string Frame = "frame";
            public const string Grade = "grade";
        }

        /// <summary>Keys under <c>Login.img/Title/</c> (CUITitle credential form).</summary>
        public static class Title
        {
            public const string Root = "Title";
            public const string Signboard = "signboard";
            public const string Id = "ID";
            public const string Pw = "PW";
            public const string BtLogin = "BtLogin";
            public const string BtLoginIdSave = "BtLoginIDSave";
            public const string BtLoginIdLost = "BtLoginIDLost";
            public const string BtPasswdLost = "BtPasswdLost";
            public const string BtNew = "BtNew";
            public const string BtHomePage = "BtHomePage";
            public const string BtQuit = "BtQuit";
            public const string CheckUnchecked = "check/0";
            public const string CheckChecked = "check/1";
        }

        /// <summary>Keys under <c>Login.img/WorldSelect/</c> (CUIWorldSelect).</summary>
        public static class WorldSelect
        {
            public const string Root = "WorldSelect";
            public const string ChBackground = "chBackgrn";
            public const string BtGoWorld = "BtGoworld";
            public const string BtViewAll = "BtViewAll";
            public const string BtViewChoice = "BtViewChoice";
            public const string BtWorldPrefix = "BtWorld";
        }

        /// <summary>Keys under <c>Login.img/CharSelect/</c> (CUICharSelect).</summary>
        public static class CharSelect
        {
            public const string Root = "CharSelect";
            public const string CharInfo = "charInfo";
            public const string CharInfo1 = "charInfo1";
            public const string BtSelect = "BtSelect";
            public const string BtNew = "BtNew";
            public const string BtDelete = "BtDelete";
        }

        /// <summary>Keys under <c>Login.img/NewChar/</c> (CUINewChar).</summary>
        public static class NewChar
        {
            public const string Root = "NewChar";
            public const string CharName = "charName";
            public const string CharSet = "charSet";
            public const string BtYes = "BtYes";
            public const string BtNo = "BtNo";
            public const string BtCheck = "BtCheck";
            public const string BtLeft = "BtLeft";
            public const string BtRight = "BtRight";
        }
    }

    // ── UIWindow2.img/Channel ─────────────────────────────────────────────────

    /// <summary>Keys under <c>UI.wz/UIWindow2.img/Channel/</c> (in-game channel switcher).</summary>
    public static class Channel
    {
        public const string Root = "Channel";
        public const string Background = "backgrnd";
        public const string BtChange = "BtChange";
        public const string BtCancel = "BtCancel";
    }
}
