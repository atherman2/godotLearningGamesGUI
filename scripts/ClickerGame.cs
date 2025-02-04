using Godot;
using System;
using System.Collections.Generic;

public partial class ClickerGame : Node
{
	int money, collectorIndex;
	public ClickerUI ui;
	public List<Collector> collectors = new() { };

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
		AddCollector();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		UpdateAllCoolDowns();
	}

	public void IncreaseMoney(int increment)
	{
		money += increment;
		ui.SetMoneyLabel(money);
	}

	private void DefineCollectorsInfo()
	{
		collectorsInfo = new List<CollectorInfo>
		{
			new (1, 2.0, "Basic\nCollector")
		};
	}

	public void AddCollector()
	{
		CollectorInfo collectorInfo = collectorsInfo[++collectorIndex];
		Collector collector = new Collector(collectorInfo.outcomeValue, collectorInfo.coolDownTime, IncreaseMoney);
		collectors.Add(collector);
		AddChild(collector);
		ui.AddCollectorUI(collectorInfo.infoTextString);
		CollectorUI collectorUI = ui.collectorUIs[collectorIndex];
		collectorUI.button.Pressed += collector.Collect;
	}

	public void UpdateAllCoolDowns()
	{
		int index = 0;
		while(index <= collectorIndex)
		{
			UpdateCoolDown(index++);
		}
	}

	public void UpdateCoolDown(int index)
	{
		double remainingCoolDownTime = collectors[index].remainingCoolDownTime;
		double coolDownTime = collectors[index].coolDownTime;
		ui.collectorUIs[index].coolDownBar.Value = 100 * remainingCoolDownTime / coolDownTime;
	}
}
