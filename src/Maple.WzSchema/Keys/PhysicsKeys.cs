namespace Maple.WzSchema;

/// <summary>
/// Typed key constants for <c>Map.wz/Physics.img</c> node navigation.
/// Source: PDB-verified symbol names from <c>CPhysicsWorld::Init</c> (catalog §5.19).
/// WZ archive node names use camelCase WITHOUT the <c>d</c>-prefix;
/// the <c>d</c>-prefix belongs to the C++ <c>CONSTANTS</c> struct fields only.
/// </summary>
public static class PhysicsKeys
{
    public const string WalkForce = "walkForce";
    public const string WalkSpeed = "walkSpeed";
    public const string WalkDrag = "walkDrag";
    public const string SlipForce = "slipForce";
    public const string SlipSpeed = "slipSpeed";

    /// <summary>Primary floating drag coefficient (WZ key: <c>floatDrag1</c>; C++ field: <c>dFloatDrag1</c>).</summary>
    public const string FloatDrag1 = "floatDrag1";

    /// <summary>Secondary floating drag coefficient (WZ key: <c>floatDrag2</c>; C++ field: <c>dFloatDrag2</c>).</summary>
    public const string FloatDrag2 = "floatDrag2";

    public const string FloatCoefficient = "floatCoefficient";
    public const string SwimForce = "swimForce";
    public const string SwimSpeed = "swimSpeed";
    public const string FlyForce = "flyForce";
    public const string FlySpeed = "flySpeed";
    public const string GravityAcc = "gravityAcc";
    public const string FallSpeed = "fallSpeed";
    public const string JumpSpeed = "jumpSpeed";
    public const string MaxFriction = "maxFriction";
    public const string MinFriction = "minFriction";

    /// <summary>Jump speed while swimming (WZ key: <c>swimSpeedDec</c>; C++ field: <c>dSwimSpeedDec</c>).</summary>
    public const string SwimSpeedDec = "swimSpeedDec";

    /// <summary>Jump speed while flying (WZ key: <c>flyJumpDec</c>; C++ field: <c>dFlyJumpDec</c>).</summary>
    public const string FlyJumpDec = "flyJumpDec";
}
