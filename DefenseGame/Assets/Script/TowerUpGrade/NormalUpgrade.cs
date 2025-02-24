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
		if (GameManager.Instance.money >= 20)
		{
			GameManager.Instance.money -= 20;
			towerBuilding.NormalTower.Damage += 3;
		}
	}

	public void UpdateRange()
	{
		if (GameManager.Instance.money >= 10)
		{
			GameManager.Instance.money -= 10;
			towerBuilding.NormalTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);
		}
	}

	public void UpdateSpeed()
	{
		if (GameManager.Instance.money >= 15)
		{
			GameManager.Instance.money -= 15;
			towerBuilding.NormalTower.projectileSpeed += 0.5f;

		}
	}
}
