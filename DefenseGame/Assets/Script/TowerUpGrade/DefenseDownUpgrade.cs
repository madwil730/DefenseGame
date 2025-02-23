using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseDownUpgrade : UpgradeManager
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
		TowerDescTitle.text = " ��� Ÿ��";
		TowerDesc.text = "��ö ���� �θ��� ������ �Ǻθ� ������ ���������";
	}

	public void UpdateAttack()
	{
		towerBuilding.DefenseDownTower.Damage += 3;
	}

	public void UpdateRange()
	{
		towerBuilding.DefenseDownTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);
	}

	public void UpdateSpeed()
	{
		towerBuilding.DefenseDownTower.projectileSpeed += 0.5f;
	}

	public void UpdateProperty()
	{
		towerBuilding.DefenseDownTower.DefenceDamage += 1;
	}


}
