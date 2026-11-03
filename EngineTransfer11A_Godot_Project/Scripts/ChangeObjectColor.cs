using Godot;

// Attach this script to MyMarker/Color.
// Color is a child Node; MyMarker is the visible MeshInstance3D.
public partial class ChangeObjectColor : Node
{
    [Export] public Color Tint { get; set; } = Colors.Cyan;

    private MeshInstance3D _target = null!;

    public override void _Ready()
    {
        _target = GetParent<MeshInstance3D>();

        var material = new StandardMaterial3D
        {
            AlbedoColor = Tint,
            Metallic = 0.12f,
            Roughness = 0.38f
        };

        _target.MaterialOverride = material;
    }
}
