using Godot;

// Attach to MyMarker/Move. The parent is the visible MeshInstance3D.
public partial class TranslateObject : Node
{
    [Export] public float Speed { get; set; } = 1f;

    private Node3D target;

    public override void _Ready()
    {
        target = GetParent<Node3D>();
    }

    public override void _Process(double delta)
    {
        target.Position += Vector3.Right * Speed * (float)delta;
    }
}
