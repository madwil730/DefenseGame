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


		TowerDescTitle.text = " �븻 Ÿ��";
		TowerDesc.text = "�⺻���� ��ѱ�";
	}

	public void UpdateAttack()
	{
		towerBuilding.NormalTower.Damage += 3;
	}
}
