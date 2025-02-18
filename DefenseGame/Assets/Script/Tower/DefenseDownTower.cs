using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseDownTower : UpgradeManager
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


		TowerDescTitle.text = " 방어력 관통 타워";
		TowerDesc.text = "날카로운 부리로 상대방의 방어막을 부셔버린다";
	}

	public void UpdateAttack()
	{
		towerBuilding.NormalTower.Damage += 3;
	}
}
