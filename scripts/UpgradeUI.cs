using Godot;
using System;

public partial class UpgradeUI : HBoxContainer
{
	public Button button;
	public Label nameLabel, descriptionLabel;

	// Called when the node enters the scene tree for the first time.
	public UpgradeUI(string name, string description, int cost)
	{
		CustomMinimumSize = new Vector2(0, 48);
		SizeFlagsHorizontal = SizeFlags.ExpandFill;

		nameLabel = new Label
		{
			Text = name,
			CustomMinimumSize = new Vector2(60, 40)
		};
		AddChild(nameLabel);

		descriptionLabel = new Label
		{
			Text = description,
			CustomMinimumSize = new Vector2(120, 40)
		};
		AddChild(descriptionLabel);

		button = new Button
		{
			Text = "Upgrade",
			CustomMinimumSize = new Vector2(40, 40)
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
