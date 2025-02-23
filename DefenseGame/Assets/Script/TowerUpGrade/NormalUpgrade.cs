using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NormalUpgrade : UpgradeManager
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
		TowerDescTitle.text = " 노말 타원";
		TowerDesc.text = "기본적인 비둘기";
	}

	public void UpdateAttack()
	{
		towerBuilding.NormalTower.Damage += 3;
	}

	public void UpdateRange()
	{
		towerBuilding.NormalTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);
	}

	public void UpdateSpeed()
	{
		towerBuilding.NormalTower.projectileSpeed += 0.5f;
	}
}
