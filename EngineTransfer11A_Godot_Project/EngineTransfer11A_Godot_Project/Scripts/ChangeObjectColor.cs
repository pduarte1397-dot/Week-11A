using Godot;

// Attach to MyMarker/Color. The parent is the visible MeshInstance3D.
public partial class ChangeObjectColor : Node
{
    [Export] public Color Tint { get; set; } = Colors.Cyan;

    private MeshInstance3D target;

    public override void _Ready()
    {
        target = GetParent<MeshInstance3D>();

        // Create the material once and apply the exported tint.
        var material = new StandardMaterial3D
        {
            AlbedoColor = Tint,
            Metallic = 0.12f,
            Roughness = 0.38f
        };
        target.MaterialOverride = material;
    }
}
