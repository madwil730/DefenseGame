using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeUpgrade : UpgradeManager
{
	[SerializeField]
	private GameObject temp;

	public override void ChangeImage(Sprite sprite)
	{
		throw new System.NotImplementedException();
	}


	public override void Init(TowerBuilding towerBuilding)
	{
		this.towerBuilding = towerBuilding;
		gameObject.SetActive(true);


		TowerDescTitle.text = " 노말 타원";
		TowerDesc.text = "기본적인 비둘기";
	}

	public void UpdateAttack()
	{
		towerBuilding.NormalTower.Damage += 3;
	}
}
