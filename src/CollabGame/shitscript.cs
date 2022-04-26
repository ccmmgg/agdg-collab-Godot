using Godot;
using System;

public class shitscript : Spatial
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Spatial _spatial;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_spatial = GetParentSpatial();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
		_spatial.RotateY(1);
  }
}
