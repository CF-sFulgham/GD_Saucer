using Godot;
using System;

public partial class Level : Node2D
{
	public override void _Ready()
	{
		// GD.Print("Hello World!");
	}
	
	
	public void OnMazeBodyEntered(PhysicsBody2D body)
	{
		GetTree().CallDeferred("reload_current_scene");
	}
}
