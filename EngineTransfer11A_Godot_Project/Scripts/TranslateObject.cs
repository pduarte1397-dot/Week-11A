using Godot;

// Attach this script to MyMarker/Move.
// Move is a child Node; MyMarker is the visible MeshInstance3D.
public partial class TranslateObject : Node
{
    [Export] public float Speed { get; set; } = 1.0f;

    private Node3D _target = null!;

    public override void _Ready()
    {
        _target = GetParent<Node3D>();
    }

    public override void _Process(double delta)
    {
        _target.Position += Vector3.Right * Speed * (float)delta;
    }
}
