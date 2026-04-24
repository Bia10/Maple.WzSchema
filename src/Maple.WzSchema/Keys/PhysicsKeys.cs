namespace Maple.WzSchema;

/// <summary>
/// Typed key constants for <c>Map.wz/Physics.img</c> node navigation.
/// WZ archive node names use camelCase without the engine field-name prefix.
/// </summary>
public static class PhysicsKeys
{
    public const string WalkForce = "walkForce";
    public const string WalkSpeed = "walkSpeed";
    public const string WalkDrag = "walkDrag";
    public const string SlipForce = "slipForce";
    public const string SlipSpeed = "slipSpeed";

    /// <summary>Primary floating drag coefficient.</summary>
    public const string FloatDrag1 = "floatDrag1";

    /// <summary>Secondary floating drag coefficient.</summary>
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

    /// <summary>Jump speed while swimming.</summary>
    public const string SwimSpeedDec = "swimSpeedDec";

    /// <summary>Jump speed while flying.</summary>
    public const string FlyJumpDec = "flyJumpDec";
}
