using Godot;
using System;

public partial class Collector : Node
{
	public double remainingCoolDownTime, coolDownTime;
	public int outcome;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		remainingCoolDownTime = 0.0;
		coolDownTime = 2.0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		UpdateTimes(delta);
	}

	public void UpdateTimes(double delta)
	{
		if(remainingCoolDownTime > 0.0)
		{
			remainingCoolDownTime -= delta;
		}
	}

	public int Collect()
	{
		if(remainingCoolDownTime <= 0.0)
		{
			remainingCoolDownTime = coolDownTime;
			return outcome;
		}
		else
		{
			return 0;
		}
	}
}
