using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeUpgrade : UpgradeManager
{
	public override void ChangeImage(Sprite sprite)
	{
		throw new System.NotImplementedException();
	}


	public override void Init(TowerBuilding towerBuilding)
	{
		this.towerBuilding = towerBuilding;
		gameObject.SetActive(true);

		TowerImage.sprite = Sprite;
		TowerDescTitle.text = "수입 타원";
		TowerDesc.text = "반짝이는 물건을 모아 수입을 늘린다, 공격력은 없다";
	}

	public void UpdateInCome()
	{
		if (GameManager.Instance.money >= 30)
		{
			GameManager.Instance.money -= 30;
			towerBuilding.InComeTower.InCome += 1;
		}
	}
}
