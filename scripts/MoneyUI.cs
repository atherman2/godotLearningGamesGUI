using Godot;
using System;

public partial class MoneyUI : VBoxContainer
{
	public Label moneyLabel, incomeRateLabel;
	// Called when the node enters the scene tree for the first time.
	public MoneyUI()
	{
		CustomMinimumSize = new Vector2(250, 80);
		SizeFlagsVertical = SizeFlags.ExpandFill;
		moneyLabel = new Label
		{
			Text = $"${0}",
			CustomMinimumSize = new Vector2(28,28)
		};
		AddChild(moneyLabel);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
