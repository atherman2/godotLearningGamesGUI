using Godot;
using System;
using System.Collections.Generic;

public partial class ClickerGame : Node
{
	int money, collectorIndex;
	public ClickerUI ui;
	public List<Collector> collectors;

	struct CollectorInfo
	{
		public int outcomeValue; public double coolDownTime; public string infoTextString;
		public CollectorInfo(int outcome, double coolDown, string infoText)
		{
			outcomeValue = outcome; coolDownTime = coolDown; infoTextString = infoText;
		}
	};
	private List<CollectorInfo> collectorsInfo;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		money = 0;
		collectorIndex = -1;
		DefineCollectorsInfo();
		ui = GetNode<ClickerUI>("ClickerUI");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		UpdateCoolDown();
	}

	private void DefineCollectorsInfo()
	{
		collectorsInfo = new List<CollectorInfo>
		{
			new (1, 2.0, "Coletor\nBásico")
		};
	}

	public void AddCollector()
	{
		collectorIndex++;
		CollectorInfo collectorInfo = collectorsInfo[collectorIndex];
		ui.AddCollectorUI(collectorInfo.infoTextString);
		collectors.Add(new Collector(collectorInfo.outcomeValue, collectorInfo.coolDownTime));
	}

	public void Collect(int index)
	{
	}

	public void UpdateCoolDown()
	{
	}
}
