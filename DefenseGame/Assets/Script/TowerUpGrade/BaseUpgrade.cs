using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUpgrade : UpgradeManager
{
	[SerializeField]
	private GameObject normalTowerBtn;


	public override void ChangeImage(Sprite sprite)
	{
		towerBuilding.TowerImage.sprite = sprite;
		towerBuilding.Kind = TowerBuilding.TowerKind.NormalTower;
		towerBuilding.Init();
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
