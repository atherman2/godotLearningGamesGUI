using Godot;
using System;

public partial class Upgrade : Node
{
	public delegate void Action();
	public Action upgradeActionPerformed;
	
	// Called when the node enters the scene tree for the first time.
	public Upgrade(Action upgradeAction)
	{
		upgradeActionPerformed = upgradeAction;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
