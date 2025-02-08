using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class  UpgradeManager : MonoBehaviour
{
	[SerializeField]
	protected TextMeshProUGUI TowerDescTitle;
	[SerializeField]
	protected TextMeshProUGUI TowerDesc;
	protected TowerBuilding towerBuilding;
	public abstract void Init(TowerBuilding towerBuilding);

	public abstract void ChangeImage(Sprite sprite);
}
