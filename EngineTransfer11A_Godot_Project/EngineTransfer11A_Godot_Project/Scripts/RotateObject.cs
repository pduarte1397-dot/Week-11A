using Godot;

// Attach to MyMarker/Turn. The parent is the visible MeshInstance3D.
public partial class RotateObject : Node
{
    [Export] public float DegreesPerSecond { get; set; } = 90f;

    private Node3D target;

    public override void _Ready()
    {
        target = GetParent<Node3D>();
    }

    public override void _Process(double delta)
    {
        float radians = Mathf.DegToRad(DegreesPerSecond) * (float)delta;
        target.RotateY(radians);
    }
}
