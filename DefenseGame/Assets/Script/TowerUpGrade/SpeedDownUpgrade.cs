using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownUpgrade : UpgradeManager
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
		TowerDescTitle.text = "���� Ÿ��";
		TowerDesc.text = "���� ��� ������ ���ù����� ������ ������";
	}

	public void UpdateAttack()
	{
		if (GameManager.Instance.money >= 20)
		{
			GameManager.Instance.money -= 20;
			towerBuilding.SpeedDownTower.Damage += 3;
		}

	}

	public void UpdateRange()
	{
		if (GameManager.Instance.money >= 10)
		{
			GameManager.Instance.money -= 10;
			towerBuilding.SpeedDownTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);

		}
	}

	public void UpdateSpeed()
	{
		if (GameManager.Instance.money >= 15)
		{
			GameManager.Instance.money -= 15;
			towerBuilding.SpeedDownTower.projectileSpeed += 0.5f;

		}
	}

	public void UpdateProperty()
	{
		if (GameManager.Instance.money >= 20)
		{
			GameManager.Instance.money -= 20;
			towerBuilding.SpeedDownTower.SpeedDamage += 0.5f;
		}
	}
}
