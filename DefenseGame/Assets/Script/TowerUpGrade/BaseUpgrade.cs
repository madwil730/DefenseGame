using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUpgrade : UpgradeManager
{
	private bool buildingOk;

	public override void ChangeImage(Sprite sprite)
	{
		if(buildingOk)
		{
			towerBuilding.TowerImage.sprite = sprite;
			towerBuilding.Init();
		}
	
	}

	public void ChangeNormalKind()
	{
		if(GameManager.Instance.money >= 30)
		{
			towerBuilding.Kind = TowerBuilding.TowerKind.NormalTower;
			towerBuilding.NormalTower.gameObject.SetActive(true);
			buildingOk = true;
			GameManager.Instance.money -= 30;
		}
	}

	public void ChangeDefenseDownKind()
	{
		if (GameManager.Instance.money >= 35)
		{
			buildingOk = true;
			GameManager.Instance.money -= 35;
			towerBuilding.Kind = TowerBuilding.TowerKind.DefenceDown;
			towerBuilding.DefenseDownTower.gameObject.SetActive(true);
		}
			
	}

	public void ChangeSpeedDownKind()
	{
		if (GameManager.Instance.money >= 40)
		{
			towerBuilding.Kind = TowerBuilding.TowerKind.SpeedDown;
			towerBuilding.SpeedDownTower.gameObject.SetActive(true);
			buildingOk = true;
			GameManager.Instance.money -= 40;
		}

		
	}

	public void ChangeInComeKind()
	{
		if (GameManager.Instance.money >= 50)
		{
			buildingOk = true;
			GameManager.Instance.money -= 50;
			towerBuilding.Kind = TowerBuilding.TowerKind.InCome;
			towerBuilding.InComeTower.gameObject.SetActive(true);
		}
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
		if(buildingOk)
		{
			buildingOk = false;
			gameObject.SetActive(false);

		}
	}
}
