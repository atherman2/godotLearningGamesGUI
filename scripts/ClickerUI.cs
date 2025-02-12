using Godot;
using System;
using System.Collections.Generic;

public partial class ClickerUI : Control
{
	public VBoxContainer runVBox, upgradeVBox;
	public HBoxContainer infoHBox;
	public List<CollectorUI> collectorUIs;
	public UpgradeUI upgradeUI;
	public MoneyUI moneyUI;
	public int collectorUIindex = -1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		runVBox = GetNode<VBoxContainer>("RunPanel/VBox");
		upgradeVBox = GetNode<VBoxContainer>("UpgradePanel/VBox");
		infoHBox = GetNode<HBoxContainer>("InfoPanel/HBox");
		upgradeUI = new UpgradeUI("Second\nCollector", "Unlocks the second collector\nGives $4 every 5 sec");
		moneyUI = new MoneyUI();
		upgradeVBox.AddChild(upgradeUI);
		infoHBox.AddChild(moneyUI);
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

	public void SetMoneyLabel(int money)
	{
		moneyUI.moneyLabel.Text = $"${money}";
	}
}
