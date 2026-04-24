# Maple.WzSchema — Reverse-Engineering Reference

Provenance metadata for every WZ key file in `Maple.WzSchema/Keys/`.
Each entry documents the WZ archive it covers, the WZ path template(s) where
the keys are found, the V95 PDB source that confirms the key names, and any
notable implementation decisions.

---

## Quick stats

- **16 key files** across 8 WZ archives
- **All keys confirmed** via V95 PDB (`game_pseudocode.c` / `game_types.h`) or
  direct WZ content inspection
- **3 supporting files**: `WzDefaults.cs`, `WzPath.cs`, `WzPresenceFlag.cs`
- **1 extension layer**: `WzPropertyExtensions.cs` (typed resolve helpers)
- **1 code file**: `CharacterCodes.cs` (integer literals, not WZ keys)

---

## Archived source-comment notes

The source files now keep comments focused on present code behavior, live WZ
quirks, and usage constraints. Reverse-engineering provenance, historical
corrections, and pseudocode metadata that previously appeared inline are
archived here instead.

### Moved provenance by file

- `WzDefaults.cs`: mob skill and mob speak defaults were originally annotated
  with schema and PDB defaults; the source now keeps only the runtime default
  values.
- `CharacterCodes.cs`: slot indices and the previously noted V95 slot-clearing
  quirks came from the avatar compositing reverse-engineering pass.
- `EtcKeys.cs`: Morph and TamingMob comments previously carried `game_types.h`
  anchors and registration-function references. The remaining source comments
  keep only movability semantics and field purpose.
- `ItemKeys.cs`: item `unitPrice`, throwing-star `incPAD`, and pet ability flag
  comments previously embedded SP offsets and field-name provenance. Those
  lookup notes now belong here.
- `MapKeys.cs`: `forbiddenSkill`, `swimArea`, `ReduceHP`, and healer `ymin`
  comments previously carried catalog sections and binary-source references.
- `MobKeys.cs`: the following key confirmations and prior-name corrections were
  removed from inline comments and retained as reference data here:
  `publicReward` over `pickUpDrop`, `HPgaugeHide` exact casing, `mbookID`,
  `escort`, `pushed` over `pushedDamage`, `fs` as floating-point data,
  `hpTagBgcolor` exact casing, `ban` over `banType`, `damagedByMob`,
  `damagedBySkill`, and the `areaWarning` attack UOL.
- `MobSkillKeys.cs`: archived name/provenance notes for `hp`, `time`,
  `randomtarget`, and `nEffect`, including prior aliases that were called out
  in source comments.
- `PhysicsKeys.cs`: archived the engine-field provenance for the physics key
  names; source comments now only describe the live WZ key meaning.
- `ReactorKeys.cs`: archived the catalog and engine-model references for
  `quest`, `timeout`, event type `"0"`, and event `state` transitions.
- `SkillKeys.cs`: archived provenance for `skillLVData`, `prepare/time`,
  `ball/delay`, `defaultMasterLev`, `mob`, `delay`, and `hold`, along with the
  associated pseudocode notes.
- `CharacterKeys.cs`, `EquipKeys.cs`, and `UiKeys.cs`: archived PDB/path-source
  references that were only documenting discovery, not present behavior.

### WZ quirks intentionally kept in source

These remain in source comments because they describe the live archive shape,
not the research trail:

- `MobKeys.Attack.SpeicalAttack = "speicalAttack"`
- `MobKeys.Attack.FacingAttatch = "facingAttatch"`
- `EtcKeys.ItemCrafting.ReqSkillProbability = "reqSkillProbility"`
- Truncated keys such as `defaultMasterLev`, `hpincratioonmo`,
  `mpincratioonmo`, `hpchangepertim`, and `mpchangepertim`

---

## Two resolution APIs

This package is consumed by two codebases with different resolution styles.
Both work; pick the one that matches your codebase's dependency on Duey.

### Typed API — `WzPropertyExtensions` (admin panel / data-layer)

```csharp
// Returns int, default from descriptor when node absent
int level = infoNode.Resolve(MobKeys.Info.Level);  // default = 1

// Returns bool, absent-or-zero = false
bool isBoss = infoNode.Resolve(MobKeys.Info.Boss);
```

Extension methods are in `WzPropertyExtensions`. Consumers call
`node.Resolve(WzProperty<T>)` or `node.Resolve(WzPresenceFlag)`.
The descriptor's `Default` is applied automatically on absent nodes.

### Nullable API — `DataExtensions` (client / Duey consumers)

```csharp
// WzProperty<T> implicitly converts to string — passes the key, not the default
int level = node.ResolveInt(MobKeys.Info.Level) ?? 1;  // caller owns the fallback
```

Duey's built-in `DataExtensions.ResolveInt(string?)` accepts any
`WzProperty<T>` via its implicit `string` conversion.
The descriptor's `Default` is **not** applied — the caller must provide the fallback inline.

### Key type conventions

Keys files intentionally mix two forms:

| Form | When used | Example |
|------|-----------|---------|
| `WzProperty<T>` | Value-bearing node with a known default (stat, flag, string field) | `MobKeys.Info.Level` |
| `const string` | Navigation waypoint or structural node name (no scalar default) | `MapKeys.InfoNode`, `CharacterKeys.Frame.Map` |

Both forms work with both APIs. `WzProperty<T>` adds type safety and a default
when using `WzPropertyExtensions`; `const string` is lighter and sufficient for
pure navigation.

---

## Folder structure

```
Maple.WzSchema/
├── Keys/                 ← One file per WZ domain (or sub-domain)
│   ├── CommonKeys.cs     ← Cross-domain keys used in multiple archives
│   ├── CharacterCodes.cs ← Integer constants, equip slot indices, default item IDs
│   ├── CharacterKeys.cs  ← Character.wz — actions, anchors, z-order table, folders
│   ├── EquipKeys.cs      ← Item.wz/Character.wz equip info/ and stat nodes
│   ├── EtcKeys.cs        ← Etc.wz — morphs, guild skills, continent move, char-create
│   ├── ItemKeys.cs       ← Item.wz — all non-equip item categories and info fields
│   ├── MapKeys.cs        ← Map.wz — info, footholds, portals, layers, backgrounds
│   ├── MobKeys.cs        ← Mob.wz — template info, attacks, skills, speak
│   ├── MobSkillKeys.cs   ← Skill.wz mob skills (separate from player skills)
│   ├── NpcKeys.cs        ← Npc.wz — sprite and template data
│   ├── PhysicsKeys.cs    ← Map.wz Physics.img — movement physics constants
│   ├── QuestKeys.cs      ← Quest.wz — check, act, and info nodes
│   ├── ReactorKeys.cs    ← Reactor.wz — state machine and event nodes
│   ├── SkillKeys.cs      ← Skill.wz — player skill levels, formulas, animations
│   ├── StringKeys.cs     ← String.wz — localised string paths
│   └── UiKeys.cs         ← UI.wz — login, HUD, minimap, button state paths
├── Navigation/           ← IWzNodeNavigator abstraction + adapters
├── WzDefaults.cs         ← Sentinel / default integer values
├── WzPath.cs             ← Path-segment helpers (typed IDs → ".img" strings)
├── WzPresenceFlag.cs     ← Boolean-by-presence WZ field wrapper
├── WzProperty.cs         ← Typed WZ property with key + default
└── WzPropertyExtensions.cs ← Resolve helpers (ResolveFloat, etc.)
```

---

## Origin classification

### PDB_CONFIRMED — V95 PDB verified

Key strings confirmed via field access in `game_pseudocode.c` or symbol names
in `game_types.h`. These are ground truth from the binary.

All 16 key files fall into this category. Specific PDB sources are listed per
file in the [Reference table](#reference-table) below.

### WZ_DATA — value from WZ content, not PDB struct fields

Some constants are not C++ struct fields but are WZ string values read at
runtime and matched by the engine against a known set:

| Constant | WZ path | Notes |
|----------|---------|-------|
| `MobKeys.Info.Species` = `"species"` | `Mob.wz/{id}.img/info/species` | Stored as string; converted to `nSpecies` int via `get_mobspecies_code_from_name()`. Species names: `"beast"=0`, `"dragon"=1`, `"undead"=2`, `"etc"=3` |
| `MapKeys.Life.TypeMob` = `"m"` | `Map.wz/{mapId}.img/life/{id}/type` | String discriminator; `"m"` → mob, `"n"` → NPC |
| `ReactorKeys.Event.Type` = `"0"` | `Reactor.wz/{id}.img/{state}/{event}/type` | WZ stores type as string `"0"` (hit-body), not an integer |
| `ReactorKeys.State.NextState` = `"state"` | `Reactor.wz/{id}.img/{state}/{event}/state` | Transition key named `"state"` inside a state node |

### CODE_CONSTANTS — integer literals, not WZ keys

`CharacterCodes.cs` contains integer values derived from V95 PDB analysis. They
are not WZ node keys and are never passed to `ResolveString` / `ResolveInt`.

| Class | Source |
|-------|--------|
| `CharacterCodes.EquipSlot` | V95 RE: slot indices 1–11 per `BP_*` body-part enum |
| `CharacterCodes.FaceExpression` | V95 RE: face expression WZ node name strings |
| `CharacterCodes.DefaultItems` | V95 RE: hardcoded default coat/pants item IDs |

---

## Reference table

| File | WZ Archive(s) | Root Path Template | Nested Classes | PDB Source | Notes |
|------|--------------|-------------------|----------------|------------|-------|
| `CommonKeys.cs` | All | *(cross-domain)* | — | Various | Shared keys: `info`, `origin`, `link`, `delay`, `icon*`, `default` |
| `CharacterCodes.cs` | Character.wz | *(integer constants)* | `FaceExpression`, `DefaultItems`, `EquipSlot` | V95 RE | See [CharacterCodes detail](#charactercodescs) |
| `CharacterKeys.cs` | Character.wz | `Character.wz/{id}.img/{action}/{frame}/` | `Category`, `Action`, `Part`, `Parts`, `Slot`, `Anchor`, `Anchors`, `Equip`, `Frame`, `Actions`, `Folders` | `game_pseudocode.c` §CompositeCharacter, `CharSelectCompositing_Pipeline_RE.md` | See [CharacterKeys detail](#characterkeyscs) |
| `EquipKeys.cs` | Item.wz, Character.wz | `Item.wz/Equip/{category}/{id}.img/info/` | `Animation`, `ElementResist`, `Addition`, `ItemSkill` | `game_pseudocode.c` §LoadEquipInfo SP[0x6C0]–[0x7C8] | See [EquipKeys detail](#equipkeyscs) |
| `EtcKeys.cs` | Etc.wz | `Etc.wz/{img}/` | `TitleItem`, `Morph`, `TamingMobTemplate`, `SetItemInfo`, `ItemCrafting`, `GuildSkill`, `ContinentMove`, `MakeCharInfo`, `Equipment` | `game_pseudocode.c` §LoadEtcData, `EtcWZ_Reference.md` | See [EtcKeys detail](#etckeyscs) |
| `ItemKeys.cs` | Item.wz | `Item.wz/{category}/{id}.img/info/` | `Icon`, `Category`, `EquipCategory`, `Spec`, `Lottery`, `PetEvolution`, `Bridle`, `ItemOption` | `game_pseudocode.c` §LoadItemInfo, `ItemWZ_Reference.md` §4.1–4.11 | See [ItemKeys detail](#itemkeyscs) |
| `MapKeys.cs` | Map.wz | `Map.wz/Map{N}/{mapId}.img/` | `MiniMap`, `WorldMap`, `Info`, `Foothold`, `Tile`, `Obj`, `LadderRope`, `Portal`, `Background`, `Back`, `Life`, `Reactor`, `Ship`, `Clock`, `SwimRect`, `PhysicsProps`, `Carnival`, `Healer`, `Pulley`, `Seat`, `Section`, `PortalSprite`, `Cloud`, `AssetPath`, `Frame` | `game_pseudocode.c` §CField::Load, `MapWZ_Data_Reference.md`, `MapWZ_Runtime_Reference.md` | See [MapKeys detail](#mapkeyscs) |
| `MobKeys.cs` | Mob.wz | `Mob.wz/{id:07d}.img/` | `Actions`, `Info`, `Attack`, `Skill`, `Speak`, `Frame`, `Drop` | `game_pseudocode.c` §LoadMobTemplate SP[0x668]–[0x1AB6], `MobWZ_Template_Reference.md` | See [MobKeys detail](#mobkeyscs) |
| `MobSkillKeys.cs` | Skill.wz | `Skill.wz/MobSkill.img/{skillId}/{level}/` | `Level` | `game_pseudocode.c` §LoadMobSkillInfo, `MobWZ_Combat_Reference.md` | See [MobSkillKeys detail](#mobskillkeyscs) |
| `NpcKeys.cs` | Npc.wz, String.wz | `Npc.wz/{id:07d}.img/` | `Info`, `Frame`, `Shop`, `ScriptInfo`, `SpeakCondition`, `Actions` | `game_pseudocode.c` §LoadNpcTemplate, `NpcWZ_Reference.md` | See [NpcKeys detail](#npckeyscs) |
| `PhysicsKeys.cs` | Map.wz | `Map.wz/Physics.img/` | — | `game_pseudocode.c` §CPhysicsConst::Load SP[0x1553] | See [PhysicsKeys detail](#physicskeyscs) |
| `QuestKeys.cs` | Quest.wz | `Quest.wz/Check.img/{questId}/`, `Quest.wz/Act.img/{questId}/`, `Quest.wz/QuestInfo.img/{questId}/` | `Entry`, `InfoProps`, `SayProps` | `game_pseudocode.c` §LoadQuestData, `QuestWZ_Reference.md` | See [QuestKeys detail](#questkeyscs) |
| `ReactorKeys.cs` | Reactor.wz | `Reactor.wz/{id:07d}.img/` | `Info`, `State`, `Event`, `Frame` | `game_pseudocode.c` §CReactorTemplate::Load, `ReactorWZ_Reference.md` | See [ReactorKeys detail](#reactorkeyscs) |
| `SkillKeys.cs` | Skill.wz | `Skill.wz/{jobId}.img/skill/{skillId}/` | `ReqEntry`, `AdditionPsd`, `Animation`, `Icon`, `Formula` | `game_pseudocode.c` §LoadSkillInfo, `SkillWZ_Reference.md` | See [SkillKeys detail](#skillkeyscs) |
| `StringKeys.cs` | String.wz | `String.wz/{img}/` | — | `game_pseudocode.c` §LoadStringData, `StringWZ_Reference.md` | See [StringKeys detail](#stringkeyscs) |
| `UiKeys.cs` | UI.wz | `UI.wz/{img}/` | `Canvas`, `ButtonState`, `StatusBar`, `Basic`, `MiniMap`, `Login`, `Channel` | V95 RE: UI layout paths, `CharacterAvatar_Reference.md` | See [UiKeys detail](#uikeyscs) |

---

## WZ archive paths

### Path template conventions

WZ paths use `/` as the separator. Image files are addressed as `{name}.img`
sub-nodes of the archive root. `WzPath` provides typed helpers:

```csharp
WzPath.MobImg(id)      // "0100100.img"
WzPath.NpcImg(id)      // "9201000.img"
WzPath.ItemImg(id)     // "01002000.img"
WzPath.SkillJobImg(id) // "100.img"
WzPath.MapGroup(id)    // "Map0" … "Map9"
WzPath.MapImg(id)      // "000000000.img"
WzPath.ReactorImg(id)  // "9201000.img"
```

### Per-archive path tables

| Archive | Root path | Img naming | Example |
|---------|-----------|-----------|---------|
| `Mob.wz` | `Mob/{id:07d}.img/` | 7-digit zero-padded ID | `Mob/0100100.img/info/level` |
| `Npc.wz` | `Npc/{id:07d}.img/` | 7-digit zero-padded ID | `Npc/9201000.img/info/link` |
| `Skill.wz` | `Skill/{jobId}.img/skill/{skillId}/` | job ID (no padding) | `Skill/100.img/skill/1001000/level/1/damage` |
| `Skill.wz` (mob skills) | `Skill/MobSkill.img/{skillId}/{level}/` | no padding | `Skill/MobSkill.img/100/1/hp` |
| `Item.wz` | `Item/{category}/{id:08d}.img/info/` | 8-digit zero-padded ID | `Item/Equip/Cap/01002000.img/info/STR` |
| `Map.wz` | `Map/Map{firstDigit}/{mapId:09d}.img/` | 9-digit zero-padded ID | `Map/Map0/000000000.img/info/returnMap` |
| `Map.wz` (physics) | `Map/Physics.img/` | fixed path | `Map/Physics.img/walkForce` |
| `Character.wz` | `Character/{folder}/{id:08d}.img/{action}/{frame}/` | 8-digit zero-padded ID | `Character/00002000.img/stand1/0/body` |
| `String.wz` | `String/{img}/{id}/` | named img files | `String/Mob.img/100100/name` |
| `Quest.wz` | `Quest/{img}/{questId}/` | Check.img / Act.img / QuestInfo.img | `Quest/Check.img/1001/mob/0/id` |
| `Etc.wz` | `Etc/{img}/` | named img files | `Etc/EtcPotentialSkill.img/...` |
| `Reactor.wz` | `Reactor/{id:07d}.img/` | 7-digit zero-padded ID | `Reactor/9201000.img/info/link` |
| `UI.wz` | `UI/{img}/` | named img files | `UI/StatusBar2.img/mainBar/BtSkill/normal/0` |

---

## Detailed notes

### `CommonKeys.cs`

Cross-domain constants present in two or more WZ archives.

| Constant | WZ key | Found in |
|----------|--------|----------|
| `Info` | `"info"` | All templates (mob, npc, item, reactor, char equip) |
| `Origin` | `"origin"` | Every sprite canvas frame |
| `Link` | `"link"` | Mob, NPC, Character equip (redirect to template) |
| `Delay` | `"delay"` | Animation frame delay (ms) in Mob, NPC, Skill, Reactor |
| `Default` | `"default"` | Face/hair default anim node; fallback action name |
| `Icon` | `"icon"` | Item icon canvas; Skill icon canvas |
| `IconRaw` | `"iconRaw"` | Raw (un-greyed) icon variant |

---

### `CharacterCodes.cs`

Integer constants derived from V95 PDB analysis. Not WZ string keys.

**`EquipSlot`** — equip slot index for Character.wz avatar compositing:

| Slot | Value | Notes |
|------|-------|-------|
| `FaceAccessory` | 2 | BP_FACEACC |
| `Earring` | 3 | BP_EARACC |
| `EyeAccessory` | 4 | BP_EYEACC |
| `Coat` | 5 | BP_COAT |
| `Pants` | 6 | BP_PANTS |
| `Shoes` | 7 | BP_SHOES |
| `Gloves` | 8 | BP_GLOVES |
| `Cape` | 9 | BP_CAPE |
| `Weapon` | 10 | BP_WEAPON |
| `Shield` | 11 | BP_SHIELD |

**`DefaultItems`** — fallback coat/pants item IDs when slots 5/6 are empty
(V95 hardcoded) — male/female variants for each.

**`FaceExpression`** — WZ node name strings for face expressions used in
`Character.wz/{faceId:D8}.img/{expression}/{frameIndex}/`. Emotion packet IDs
(`EMT_*` integer values) have been moved to `Maple.Enums.Emotion`.

Source: `CharSelectCompositing_Pipeline_RE.md`, `CharacterWZ_Reference.md §6`

---

### `CharacterKeys.cs`

**WZ archive**: `Character.wz`

**Root path templates**:
```
Character.wz/{bodyId:08d}.img/{action}/{frame}/         (body/head sprites)
Character.wz/Face/{faceId:08d}.img/{expression}/{frame}/
Character.wz/Hair/{hairId:08d}.img/{action}/{frame}/
Character.wz/{folder}/{equipId:08d}.img/{action}/{frame}/
```

**Body/Head ID encoding:**
- Body: `bodyId = 2_000 + skinId` (e.g. `00002000.img`)
- Head: `headId = 12_000 + skinId` (e.g. `00012000.img`)

**Sub-folder dispatch** (`Folders` class):

| `Folders.*` | WZ folder name | Item ID prefix (÷10000) |
|-------------|---------------|------------------------|
| `Cap` | `"Cap"` | 100 |
| `Coat` | `"Coat"` | 105 |
| `Pants` | `"Pants"` | 106 |
| `Shoes` | `"Shoes"` | 107 |
| `Glove` | `"Glove"` | 108 |
| `Shield` | `"Shield"` | 109, 119, 180–183 |
| `Cape` | `"Cape"` | 110 |
| `Longcoat` | `"Longcoat"` | 111 |
| `Weapon` | `"Weapon"` | 130–165 |
| `Accessory` | `"Accessory"` | 101–103, 112–115, 161–165 |
| `Face` | `"Face"` | (face IDs) |
| `Hair` | `"Hair"` | (hair IDs) |

**Z-order table** (`ZOrderTable`): 36 entries (`"capeBackHead"` [0] …
`"cap"` [35]). Split point: index 21 (`"face"`) — sprites at Z < 21 are drawn
under face canvas, Z ≥ 21 are drawn over face canvas.
Source: `CCharacterLook::m_aZMapKey[]`, `CharacterAvatar_Reference.md §8.4`

**`Part` vs `Parts`**, **`Anchor` vs `Anchors`**: plural classes are
client-loader aliases exposing the same string values. Both resolve to the
same WZ keys.

---

### `EquipKeys.cs`

**WZ archive**: `Item.wz` (equip info nodes), `Character.wz` (equip sprite frames)

**Root path template**:
```
Item.wz/Equip/{category}/{id:08d}.img/info/
```

**Key groups:**

| Class | WZ sub-path | Example key | Notes |
|-------|-------------|-------------|-------|
| *(root)* | `info/` | `"STR"`, `"DEX"`, `"incSTR"` | Base stats and increment stats |
| `Addition` | `info/` | `"rStr"`, `"rDex"` | Potential/bonus stats |
| `ElementResist` | `info/` | `"nirFire"`, `"nirIce"` | 5 elemental resistances (no `nirDark`) |
| `Animation` | `{action}/` | `"stand1"`, `"walk1"` | Sprite animation node names |
| `ItemSkill` | `info/irs{N}/` | `"id"`, `"level"` | Embedded skill grant |

**Notable keys:**
- `Pad = "incPAD"` (primary) / `PadAlt = "PAD"` — throwing stars use `"PAD"`; all other weapons use `"incPAD"`. PDB-confirmed (`SP[0x708]`).
- `IncPddR = "pddR"`, `IncMddR = "mddR"`, `IncDamR = "damR"` — percent defense/damage rate from catalog §4.10.
- `Epic = "epicItem"` — potential grade; `MinGrade = "grade"` — minimum potential grade.
- `Swim = "swim"` — double (mount swim-speed override), distinct from `ItemKeys.Equip.IncSwim = "incSwim"` (short, character swim stat).

Source: `ItemWZ_Reference.md §4.5–4.10`, `game_pseudocode.c` §LoadEquipInfo

---

### `EtcKeys.cs`

**WZ archive**: `Etc.wz`

**Root path templates**:
```
Etc.wz/EtcPotentialSkill.img/{id}/           (TitleItem)
Etc.wz/Morph.img/{morphId}/                   (Morph)
Etc.wz/TamingMob.img/{tamingMobId}/           (TamingMobTemplate)
Etc.wz/SetItemInfo.img/{setId}/               (SetItemInfo)
Etc.wz/ItemMake.img/{id}/                     (ItemCrafting)
Etc.wz/GuildSkill.img/{skillId}/              (GuildSkill)
Etc.wz/ContinentMove.img/{continentId}/       (ContinentMove)
Etc.wz/MakeCharInfo.img/                      (MakeCharInfo)
```

**Notable keys:**
- `Morph` class: C++ pointer-prefix naming (`nSpeed`, `nJump`, `dFs`, `nSwim`, `bMorphEffect`, `bSuperMan`, `bHide`, `bAttackable`) — preserved verbatim from `game_pseudocode.c` §LoadMorphTemplate.
- `ContinentMove`: all 8 sub-keys confirmed from catalog §9.9 (`mob`, `mobInterval`, `stageNode`, `spotCount`, `questId`, `startMap`, `endMap`, `endPortal`).
- `MakeCharInfo.Equipment`: includes `"hairColor"` key alongside `"skin"`, `"face"`, `"hair"`, and equip slot entries.

Source: `EtcWZ_Reference.md`, `game_pseudocode.c` §LoadEtcData

---

### `ItemKeys.cs`

**WZ archive**: `Item.wz`

**Root path templates**:
```
Item.wz/{category}/{id:08d}.img/info/         (all item types)
Item.wz/{category}/{id:08d}.img/icon          (icon canvas)
Item.wz/Consume/{id:08d}.img/spec/            (Spec — use-effect stats)
Item.wz/Cash/{id:08d}.img/pet/evolution/      (PetEvolution)
```

**Category sub-folder mapping** (`Category` class):

| `Category.*` | WZ folder | Item ID range |
|-------------|-----------|--------------|
| `Equip` | `"Equip"` | `1xxxxxxx` |
| `Consume` | `"Consume"` | `2xxxxxxx` |
| `Install` | `"Install"` | `3xxxxxxx` |
| `Etc` | `"Etc"` | `4xxxxxxx` |
| `Cash` | `"Cash"` | `5xxxxxxx` |

**Equipment category mapping** (`EquipCategory` class — maps item prefix to `Character.wz` folder):

`Cap` (100), `Face` (101–103), `Coat` (105), `Pants` (106), `Shoes` (107),
`Glove` (108), `Cape` (110), `Longcoat` (111), `Accessory` (112–115),
`Weapon` (130–165), `Shield` (109, 119, 180–183)

**Notable keys:**
- `UnitPrice = "unitPrice"` — `double` type.
- `Icon.Standard = "icon"`, `Icon.Raw = "iconRaw"` — canvas sub-nodes on item images.
- `Spec` class keys: `IncStr`, `IncDex`, `IncInt`, `IncLuk` in `spec/` sub-node (§4.3).
- `Bridle` class: pet riding stats (`bridleProb`, `bridleProbAdj`) in `spec/`.

Source: `ItemWZ_Reference.md §4.1–4.11`, `game_pseudocode.c` §LoadItemInfo

---

### `MapKeys.cs`

**WZ archive**: `Map.wz`

**Root path template**:
```
Map.wz/Map/Map{firstDigit}/{mapId:09d}.img/
```

**Key classes and their WZ sub-paths:**

| Class | WZ sub-path | Example key | Notes |
|-------|-------------|-------------|-------|
| `Info` | `info/` | `"returnMap"`, `"fieldLimit"`, `"VRLeft"` | Map metadata; VR bounds are SCREAMING_CAPS in WZ |
| `Foothold` | `foothold/{layer}/{group}/{id}/` | `"x1"`, `"y1"`, `"cant_through"` | 3-level hierarchy |
| `Tile` | `{layer}/tile/{id}/` | `"tS"`, `"u"`, `"no"`, `"zM"` | `Tile.Variant` is alias for `Tile.U = "u"` |
| `Obj` | `{layer}/obj/{id}/` | `"oS"`, `"l0"`, `"l1"`, `"l2"`, `"z"` | `Obj.F = "f"`, `Obj.A = "a"` are short aliases |
| `LadderRope` | `ladderRope/{id}/` | `"x"`, `"y1"`, `"y2"`, `"l"` | `"l"` = 1 → ladder, 0 → rope |
| `Portal` | `portal/{id}/` | `"pn"`, `"pt"`, `"tm"`, `"tn"` | `HRange`/`VRange` default 25 |
| `Back` / `Background` | `back/{id}/` | `"bS"`, `"no"`, `"ani"`, `"rx"`, `"ry"` | `Back` = client-facing alias for `Background` |
| `Life` | `life/{id}/` | `"type"`, `"id"`, `"x"`, `"y"`, `"rx0"`, `"rx1"` | `"type"="m"` → mob, `"type"="n"` → NPC |
| `MiniMap` | `miniMap/` | `"canvas"`, `"width"`, `"height"`, `"centerX"`, `"centerY"` | RE-confirmed §9.9 |
| `PhysicsProps` | Layer `info/` | `"walkForce"`, `"swimSpeedDec"` | Per-layer physics overrides (rarely used) |
| `Healer` | `healer/` | `"x"`, `"ymin"`, `"ymax"`, `"fall"`, `"heal"` | Note: `"ymin"` confirmed PDB — NOT `"y"` |
| `Ship` | `ship/` | `"shipObj"`, `"tMove"`, `"tAppear"`, `"limit_x0"` | Ship-type field data |
| `PortalSprite` | `Map/MapHelper.img/portal/game/{cat}/` | `"enter"`, `"idle"`, `"exit"`, `"sp"` | Portal animation categories |
| `Cloud` | `Map/Obj/cloud.img/` | *(child node enumeration)* | `info/cloud != 0` → GenerateClouds |
| `Section` | *(section node names)* | `"info"`, `"foothold"`, `"life"`, `"portal"` | Section header strings; `LayerPrefix = ""` |

**View range keys** (`Info` class):
- `VrLeft/VrTop/VrRight/VrBottom` — PascalCase C# naming
- `VRLeft/VRTop/VRRight/VRBottom` — uppercase aliases matching WZ node casing

**`Fs` key**: friction/traction coefficient, stored as `double` in `info/fs`.
Default `1.0` (applied to player movement drag). PDB: `CField::m_dFs`.

Source: `MapWZ_Data_Reference.md`, `MapWZ_Runtime_Reference.md`,
`game_pseudocode.c` §CField::Load

---

### `MobKeys.cs`

**WZ archive**: `Mob.wz`

**Root path template**:
```
Mob.wz/{id:07d}.img/
  info/                         (Info class)
  attack{N}/info/               (Attack class, N = 1–9)
  skill{N}/                     (Skill class, N = 1–N)
  speak/{N}/                    (Speak class)
  {action}/{frame}/             (Frame class, Actions class)
  drop/{N}/                     (Drop class)
```

**Notable keys:**
- `Info.Species = "species"` — string value, not int. Converted by engine.
- `Info.NoRegen = "noregen"` — `WzPresenceFlag` (boolean-by-presence).
- `Attack.SpecialAttack = "speicalAttack"`, `Attack.FacingAttach = "facingAttatch"` — PDB typos preserved verbatim.
- `Info.FixedBodyAttackDamR = "FixedBodyAttackDamR"` — uppercase first letter, PDB-confirmed.
- Frame default delay: 120 ms (`WzDefaults.DefaultMobFrameDelay`).

Source: `MobWZ_Template_Reference.md`, `MobWZ_Combat_Reference.md`,
`game_pseudocode.c` §LoadMobTemplate SP 0x668–0x1AB6

---

### `MobSkillKeys.cs`

**WZ archive**: `Skill.wz` (mob sub-section, not player skills)

**Root path template**:
```
Skill.wz/MobSkill.img/{skillId}/{level}/
```

**Notable keys (all PDB-confirmed with non-obvious names):**

| Constant | WZ key | Intuitive name | PDB field |
|----------|--------|---------------|-----------|
| `Level.HpBelow` | `"hp"` | hp threshold | `nHP` |
| `Level.Duration` | `"time"` | duration (ms) | `nTime` |
| `Level.Random` | `"randomtarget"` | random target | `bRandomTarget` |
| `Level.NEffect` | `"nEffect"` | effect count | `nEffect` |

Default for `HpBelow`: 50 (`WzDefaults.MobSkillHpBelowDefault`).
Default for `Targets`: -1 = unlimited (`WzDefaults.MobSkillUnlimitedTargets`).

Source: `MobWZ_Combat_Reference.md`, `game_pseudocode.c` §LoadMobSkillLevel

---

### `NpcKeys.cs`

**WZ archive**: `Npc.wz`, `String.wz`

**Root path template**:
```
Npc.wz/{id:07d}.img/
  info/                         (Info class)
  {action}/{frame}/             (Frame class, Actions class)
  shop/{N}/                     (Shop class)
  speak/condition{N}/           (SpeakCondition class)
```

**Animation action fallback sequence** (`ActionFallbacks` array):
`stand` → `default` → `move` → `say` → `finger` → `wink` → `heart` → `shine`

**`Actions` nested class** (client loader alias):
- `Actions.Stand = "stand"` — primary stand animation
- `Actions.Stand1 = "stand1"` — alternate used in some WZ revisions

**`Info.Link = "link"`** — redirect; all sprite data comes from the linked NPC's .img.

Frame delay default: 180 ms (`WzDefaults.DefaultNpcFrameDelay`).

Source: `NpcWZ_Reference.md`, `game_pseudocode.c` §LoadNpcTemplate

---

### `PhysicsKeys.cs`

**WZ archive**: `Map.wz`

**Root path template**:
```
Map.wz/Physics.img/
```

All 19 keys are camelCase without a `d-` prefix, PDB-confirmed from
`CPhysicsConst::Load`:

| Constant | WZ key | Description |
|----------|--------|-------------|
| `WalkForce` | `"walkForce"` | Walking acceleration force |
| `WalkSpeed` | `"walkSpeed"` | Max walking speed |
| `WalkDrag` | `"walkDrag"` | Walk deceleration |
| `SlipForce` | `"slipForce"` | Ice/slip acceleration |
| `SlipSpeed` | `"slipSpeed"` | Max slip speed |
| `FloatDrag1` | `"floatDrag1"` | Float drag coefficient 1 |
| `FloatDrag2` | `"floatDrag2"` | Float drag coefficient 2 |
| `FloatCoefficient` | `"floatCoefficient"` | Float general coefficient |
| `SwimForce` | `"swimForce"` | Swim acceleration |
| `SwimSpeed` | `"swimSpeed"` | Max swim speed |
| `FlyForce` | `"flyForce"` | Fly (mount) acceleration |
| `FlySpeed` | `"flySpeed"` | Max fly speed |
| `GravityAcc` | `"gravityAcc"` | Gravity acceleration |
| `FallSpeed` | `"fallSpeed"` | Max fall speed |
| `JumpSpeed` | `"jumpSpeed"` | Jump initial velocity |
| `MaxFriction` | `"maxFriction"` | Maximum ground friction |
| `MinFriction` | `"minFriction"` | Minimum ground friction |
| `SwimSpeedDec` | `"swimSpeedDec"` | Swim speed deceleration (NOT `"swimJumpSpeed"`) |
| `FlyJumpDec` | `"flyJumpDec"` | Fly-jump deceleration |

Source: `MapWZ_Data_Reference.md §5.19`, `game_pseudocode.c` §CPhysicsConst SP[0x1553]

---

### `QuestKeys.cs`

**WZ archive**: `Quest.wz`

**Root path templates**:
```
Quest.wz/Check.img/{questId}/           (check conditions)
Quest.wz/Act.img/{questId}/             (act rewards)
Quest.wz/QuestInfo.img/{questId}/       (InfoProps class)
```

**`Entry` class** — per-condition/reward child nodes (shared structure):

| Key | WZ key | Used in |
|-----|--------|---------|
| `Order` | `"order"` | Check and Act ordering |
| `Id` | `"id"` | Mob ID / item ID / NPC ID |
| `Count` | `"count"` | Required count |

**`InfoProps` notable keys:**
- `Pop = "pop"` — fame reward (primary)
- `Fame = "fame"` — fame reward (fallback alias)
- `StartScript`, `EndScript` — NPC script file references

Source: `QuestWZ_Reference.md`, `game_pseudocode.c` §LoadQuestData

---

### `ReactorKeys.cs`

**WZ archive**: `Reactor.wz`

**Root path template**:
```
Reactor.wz/{id:07d}.img/
  info/                         (Info class)
  {stateIdx}/                   (State class)
  {stateIdx}/{eventIdx}/        (Event class)
  {stateIdx}/{frameIdx}         (Frame class, animation frames)
```

**Notable keys:**
- `Info.QuestId = "quest"` — at root/info level, **not** in event sub-nodes.
- `State.Timeout = "timeout"` — state auto-advance timer.
- `Event.Type = "0"` — stored as string `"0"` in WZ (hit-body event type); NOT an integer.
- `Event.NextState = "state"` — transition target named `"state"` inside event node.
- `Frame.A0` default: -1, `Frame.A1` default: -1 (not 255) — confirmed PDB.

**`Info.Layer`** controls render layer. Values: `0` = background, `1` = foreground.

Source: `ReactorWZ_Reference.md`, `game_pseudocode.c` §CReactorTemplate::Load

---

### `SkillKeys.cs`

**WZ archive**: `Skill.wz`

**Root path template**:
```
Skill.wz/{jobId}.img/
  skill/{skillId}/
    common/                     (formulas, evaluated per level)
    level/{1-30}/               (literal per-level values)
    req/                        (ReqEntry class — prerequisites)
```

**`Formula` class**: 34 formula fields read from `common/` (formula string,
evaluated at the skill level) or `level/{N}/` (literal int fallback). All
identified by `SkillFormulaEvaluator.Evaluate`. Fields include:
`hpCon`, `mpCon`, `damage`, `fixDamage`, `time`, `prop`, `attackCount`,
`bulletCount`, `mastery`, `mobCount`, `hp`, `mp`, `pad`, `pdd`, `mad`,
`mdd`, `acc`, `eva`, `speed`, `jump`, `x`, `y`, `z`, `range`, `cooltime`,
`dot`, `dotInterval`, `dotTime`, `moneyCon`, `itemCon`, `itemConNo`,
`subTime`, `subProp`, `bulletConsume`

**Notable keys:**
- `DefaultMasterLevel = "defaultMasterLev"` — truncated PDB name (not `"defaultMasterLevel"`).
- `ElemAttr = "elemAttr"` (primary), `Element = "element"` (alternate). No `"attackElemAttr"` key.
- `PrepareNode` + `PrepareTimeKey`: sub-path for skill prepare-phase timing.
- `SkillLvData = "skillLVData"` — `WzProperty<int>` sentinel.

**`Icon` class** keys:
- `Standard = "icon"`, `MouseOver = "iconMouseOver"`, `Disabled = "iconDisabled"`

Source: `SkillWZ_Reference.md`, `game_pseudocode.c` §LoadSkillInfo

---

### `StringKeys.cs`

**WZ archive**: `String.wz`

**Root path templates**:
```
String.wz/Mob.img/{mobId}/name
String.wz/Npc.img/{npcId}/name
String.wz/Eqp.img/Eqp/{category}/{itemId}/name
String.wz/Ins.img/{itemId}/name                    (Install items — NOT "Install.img")
String.wz/Cash.img/{itemId}/name
String.wz/Etc.img/Etc/{itemId}/name
String.wz/Consume.img/{itemId}/name
String.wz/Skill.img/{skillId}/name
String.wz/Map.img/{continentName}/{mapId}/mapName
String.wz/MonsterBook.img/{mobId}/name             (alt: "Monster Book.img")
```

**Notable keys:**
- `InsImg = "Ins.img"` — Install item string image is `"Ins.img"`, **not** `"Install.img"`.
- `MonsterBook`: two constants — `MonsterBookImg = "Monster Book.img"` (space in name) and `MonsterBookAlt = "MonsterBook"` (no space).

Source: `StringWZ_Reference.md`, `game_pseudocode.c` §LoadStringData

---

### `UiKeys.cs`

**WZ archive**: `UI.wz`

**Root path templates**:
```
UI.wz/StatusBar2.img/mainBar/           (StatusBar, Gauge, Buttons, ChatTab)
UI.wz/Basic.img/Cursor/                 (cursor states)
UI.wz/Basic.img/Check/                  (checkbox states)
UI.wz/UIWindow2.img/MiniMap/            (MiniMap chrome)
UI.wz/Login.img/                        (Login screens)
UI.wz/MapLogin.img/                     (Login map backgrounds — NOT Map.wz)
UI.wz/UIWindow2.img/Channel/            (Channel select)
```

**`ButtonState` class** — 4-state interactive sprite sub-nodes:
`"normal"`, `"mouseOver"`, `"pressed"`, `"disabled"`

**`Canvas.Origin = "origin"`** — universal canvas anchor point vector.

**`Login` nested classes**:

| Class | WZ path | Contents |
|-------|---------|----------|
| `Login.Title` | `Login.img/Title/` | signboard, id/pw inputs, login buttons |
| `Login.WorldSelect` | `Login.img/Title/WorldSelect/` | world list, channel buttons |
| `Login.CharSelect` | `Login.img/CharSelect/` | char slots, BtSelect/New/Delete |
| `Login.NewChar` | `Login.img/NewChar/` | race/class selector buttons |
| `Login.Common` | `Login.img/Common/` | frame/grade shared assets |

**Login map backgrounds** are in `UI.wz/MapLogin.img/back/`, **not** in
`Map.wz`. Tile/object layer data also lives in `UI.wz/MapLogin.img/layer{N}/`.

Source: `CharacterAvatar_Reference.md`, V95 RE UI layout analysis

---

## WzDefaults.cs — sentinel values

| Constant | Value | Usage |
|----------|-------|-------|
| `SameMap` | `999_999_999` | `info/returnMap` when no return map set |
| `MobSkillHpBelowDefault` | `50` | `MobSkill/level/{N}/hp` when absent |
| `MobSkillUnlimitedTargets` | `-1` | Mob skill targets = unlimited |
| `DefaultMobFrameDelay` | `120` | Frame delay (ms) when `delay` node absent |
| `DefaultNpcFrameDelay` | `180` | Frame delay (ms) when `delay` node absent |
| `DefaultReactorFrameDelay` | `100` | Frame delay (ms) when `delay` node absent |
| `NpcDefaultSpeed` | `70` | `npc.info.speed + 70` = actual movement speed |

---

## WzPresenceFlag.cs — boolean-by-presence pattern

Some WZ fields encode a boolean as the mere presence/absence of a node rather
than a value. `WzPresenceFlag` wraps these:

```csharp
// usage:
bool isUndead = MobKeys.Info.Undead.IsPresent(infoNode);

// examples:
MobKeys.Info.NoRegen   = new("noregen")   // present → no HP regen
NpcKeys.Float          = new("float")     // present → NPC floats
NpcKeys.Hide           = new("hide")      // present → NPC hidden
NpcKeys.Cash           = new("cash")      // present → cash shop NPC
```

---

## V95 PDB sources

All key confirmations reference one or more of these V95 RE documents:

| Reference file | Contents |
|---------------|----------|
| `game_pseudocode.c` | Full C pseudocode decompilation; function-level RE |
| `game_types.h` | All named/anonymous enum definitions; struct member types |
| `StronglyTyped_WZ_Schema_Catalog.md` | Verified per-field catalog §1–§19 |
| `MobWZ_Template_Reference.md` | Mob.wz info/ fields with SP[offset] citations |
| `MobWZ_Combat_Reference.md` | Mob attacks, skills, mob-skill level data |
| `MobWZ_Animation_Reference.md` | Mob frame delay, action node naming |
| `NpcWZ_Reference.md` | Npc.wz info/ fields, link redirect, frame struct |
| `SkillWZ_Reference.md` | Skill.wz formula fields, PrepareNode, SkillLvData |
| `ItemWZ_Reference.md` | Item.wz all categories, equip stats, Spec, PetEvolution |
| `MapWZ_Data_Reference.md` | Map.wz structural nodes, Healer ymin, Ship struct |
| `MapWZ_Runtime_Reference.md` | Map.wz Physics.img, view range, minimap |
| `CharacterWZ_Reference.md` | Character.wz Z-order table, anchor system, skin IDs |
| `CharacterAvatar_Reference.md` | Compositing pipeline §8.2–8.5, EquipSlot indices |
| `CharacterCompositing_Reference.md` | NavelSpace math, Z-split at face index 21 |
| `QuestWZ_Reference.md` | Quest.wz Check/Act/QuestInfo structure |
| `EtcWZ_Reference.md` | Etc.wz Morph C++ prefix naming, GuildSkill, ContinentMove |
| `ReactorWZ_Reference.md` | Reactor.wz state machine, Event.Type string `"0"`, A0/A1 defaults |
| `StringWZ_Reference.md` | String.wz img names ("Ins.img", "Monster Book.img") |
