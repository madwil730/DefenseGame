using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class  UpgradeManager : MonoBehaviour
{
	[SerializeField]
	protected TextMeshProUGUI TowerDescTitle;
	[SerializeField]
	protected TextMeshProUGUI TowerDesc;
	[SerializeField]
	protected Image TowerImage;
	[SerializeField]
	protected Sprite Sprite;


	protected TowerBuilding towerBuilding;
	public abstract void Init(TowerBuilding towerBuilding);

	public abstract void ChangeImage(Sprite sprite);
}
