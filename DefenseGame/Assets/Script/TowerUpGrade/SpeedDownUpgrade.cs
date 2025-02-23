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
		towerBuilding.SpeedDownTower.Damage += 3;
	}

	public void UpdateRange()
	{
		towerBuilding.SpeedDownTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);
	}

	public void UpdateSpeed()
	{
		towerBuilding.SpeedDownTower.projectileSpeed += 0.5f;
	}

	public void UpdateProperty()
	{
		towerBuilding.SpeedDownTower.SpeedDamage += 0.5f;
	}
}
