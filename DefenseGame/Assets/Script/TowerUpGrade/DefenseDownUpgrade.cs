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
		TowerDescTitle.text = " 방관 타원";
		TowerDesc.text = "강철 같은 부리로 벌레의 피부를 무참히 찢어버린다";
	}

	public void UpdateAttack()
	{
		if (GameManager.Instance.money >= 20)
		{
			GameManager.Instance.money -= 20;
			towerBuilding.DefenseDownTower.Damage += 3;
		}
	}

	public void UpdateRange()
	{
		if (GameManager.Instance.money >= 10)
		{
			GameManager.Instance.money -= 10;
			towerBuilding.DefenseDownTower.firePoint.localScale += new Vector3(0.3f, 0.3f, 0.3f);
		}
	}

	public void UpdateSpeed()
	{
		if (GameManager.Instance.money >= 15)
		{
			GameManager.Instance.money -= 15;
			towerBuilding.DefenseDownTower.projectileSpeed += 0.5f;
		}
	}

	public void UpdateProperty()
	{
		if (GameManager.Instance.money >= 20)
		{
			GameManager.Instance.money -= 20;
			towerBuilding.DefenseDownTower.DefenceDamage += 1;
		}
	}


}
