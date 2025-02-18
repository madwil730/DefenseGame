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


		TowerDescTitle.text = " ���� ���� Ÿ��";
		TowerDesc.text = "��ī�ο� �θ��� ������ ���� �μŹ�����";
	}

	public void UpdateAttack()
	{
		towerBuilding.NormalTower.Damage += 3;
	}
}
