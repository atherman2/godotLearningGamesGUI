using Godot;
using System;

public partial class CollectorUI : HBoxContainer
{
	public Button button;
	public ProgressBar coolDownBar;
	public Label infoLabel;

	// Called when the node enters the scene tree for the first time.
	public CollectorUI(string infoText)
	{
		CustomMinimumSize = new Vector2(0,48);
		SizeFlagsHorizontal = SizeFlags.ExpandFill;

		infoLabel = new Label
		{
			Text = infoText,
			CustomMinimumSize = new Vector2(60, 40)
		};

		button = new Button
		{
			Text = "Collect",
			CustomMinimumSize = new Vector2(40,40)
		};
		AddChild(button);

		coolDownBar = new ProgressBar
		{
			Value = 0,
			SizeFlagsHorizontal = SizeFlags.ExpandFill,
		};
		AddChild(coolDownBar);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
