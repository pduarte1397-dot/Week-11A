ENGINE TRANSFER 11A - COMPLETE GODOT 4 .NET PROJECT

This folder is a complete Godot 4 .NET project using C#.

OPEN THE PROJECT
1. Install the Godot 4 .NET (also called Mono) edition, plus the .NET 8 SDK.
2. Extract the ZIP file.
3. Open Godot and choose Import.
4. Select the project.godot file in this folder.
5. Let Godot import the project, then build the C# project using the Build button.
6. Press F6 to run the current scene, or F5 to run the main scene.

SCENE TREE
EngineTransfer11A (Node3D)
|-- MyMarker (MeshInstance3D, BoxMesh, scale 1, 1.5, 1)
|   |-- Move (Node)   [TranslateObject.cs]
|   |-- Turn (Node)   [RotateObject.cs]
|   `-- Color (Node)  [ChangeObjectColor.cs]
|-- Camera3D (position 0, 2, 10; rotation -10, 0, 0; Current)
`-- DirectionalLight3D

INSPECTOR VALUES
Move:
- Speed = 1

Turn:
- DegreesPerSecond = 90

Color:
- Tint = Cyan

TESTS REQUIRED BY THE ASSIGNMENT
1. Run and observe the cube for about three seconds.
2. Stop the scene, set Move > Speed to 0, build/run again.
3. Stop the scene, set Move > Speed to 2, build/run again.
4. Stop the scene, change Color > Tint, then run again.

The three behaviors are on separate child Nodes because Godot attaches one
script per node. Each behavior finds its visible target through its parent.

NOTE
This project source is prepared for Godot 4.4 .NET and .NET 8. The environment
that generated this ZIP does not have the Godot executable or .NET SDK installed,
so it has not been compiled or run here. Open it in Godot .NET and press Build
before running.
