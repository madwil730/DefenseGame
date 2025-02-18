using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUpgrade : UpgradeManager
{


	public override void ChangeImage(Sprite sprite)
	{
		towerBuilding.TowerImage.sprite = sprite;
		towerBuilding.Init();
	}

	public void ChangeNormalKind()
	{
		towerBuilding.Kind = TowerBuilding.TowerKind.NormalTower;
	}

	public void ChangeDefenseDownKind()
	{
		towerBuilding.Kind = TowerBuilding.TowerKind.DefenceDown;
	}

	public void ChangeSpeedDownKind()
	{
		towerBuilding.Kind = TowerBuilding.TowerKind.SpeedDown;
	}

	public void ChangeInComeKind()
	{
		towerBuilding.Kind = TowerBuilding.TowerKind.InCome;
	}


	public override void Init(TowerBuilding towerBuilding)
	{
		gameObject.SetActive(true);
		this.towerBuilding = towerBuilding;

		TowerDescTitle.text = " 기본 타원";
		TowerDesc.text = " 무엇이든 될 수 있다";


	}

	public void FalseActiveSelf()
	{
		gameObject.SetActive(false);
	}
}
