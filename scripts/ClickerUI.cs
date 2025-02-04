using Godot;
using System;
using System.Collections.Generic;

public partial class ClickerUI : Control
{
	public VBoxContainer runVBox;
	public HBoxContainer infoHBox;
	public List<CollectorUI> collectorUIs;
	public MoneyUI moneyUI;
	public int collectorUIindex = -1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		runVBox = GetNode<VBoxContainer>("RunPanel/VBox");
		collectorUIs = new List<CollectorUI>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void AddCollectorUI(string infoText)
	{
		CollectorUI newCollectorUI = new CollectorUI(infoText);
		collectorUIs.Add(newCollectorUI);
		collectorUIindex++;
		runVBox.AddChild(newCollectorUI);
	}
}
