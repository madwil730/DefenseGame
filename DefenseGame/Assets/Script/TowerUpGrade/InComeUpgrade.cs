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
		TowerDescTitle.text = "���� Ÿ��";
		TowerDesc.text = "��¦�̴� ������ ��� ������ �ø���, ���ݷ��� ����";
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
