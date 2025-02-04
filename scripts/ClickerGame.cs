using Godot;
using System;

public partial class ClickerGame : Node
{
	int money = 0;
	public UiClicker ui;
	public List<Collector> collectors;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ui = GetNode<UiClicker>("UiClicker");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		UpdateCoolDown();
	}

	public void Collect(int index)
	{
	}

	public void UpdateCoolDown()
	{
	}
}
