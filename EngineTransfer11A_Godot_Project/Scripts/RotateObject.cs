using Godot;

// Attach this script to MyMarker/Turn.
// Turn is a child Node; MyMarker is the visible MeshInstance3D.
public partial class RotateObject : Node
{
    [Export] public float DegreesPerSecond { get; set; } = 90.0f;

    private Node3D _target = null!;

    public override void _Ready()
    {
        _target = GetParent<Node3D>();
    }

    public override void _Process(double delta)
    {
        float radians = Mathf.DegToRad(DegreesPerSecond) * (float)delta;
        _target.RotateY(radians);
    }
}
