using Godot;
using System;

public partial class Collector : Node
{
	public double remainingCoolDownTime, coolDownTime;
	public int outcomeValue;

	public delegate void increment(int incrementValue);

	public increment IncrementFunction;

	// Called when the node enters the scene tree for the first time.
	public Collector(int outcome, double coolDown, increment incrementFunction)
	{
		remainingCoolDownTime = 0.0;
		coolDownTime = coolDown;
		outcomeValue = outcome;
		IncrementFunction = incrementFunction;
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

	public void Collect()
	{
		if(remainingCoolDownTime <= 0.0)
		{
			remainingCoolDownTime = coolDownTime;
			IncrementFunction(outcomeValue);
		}
	}
}
