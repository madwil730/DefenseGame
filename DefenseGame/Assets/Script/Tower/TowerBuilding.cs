using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBuilding : MonoBehaviour
{
    public Image Image;

    [SerializeField]
	private BaseUpgrade baseUpgrade;
	[SerializeField]
	private NormalUpgrade normalUpgrade;

	public enum TowerKind
    {
        Base,
        NormalTower,
        FireTower,
    }

    public TowerKind Kind = TowerKind.Base;  

    public void Init()
    {
        switch (Kind)
        {
            case TowerKind.Base:
                baseUpgrade.Init(this);
				break;

			case TowerKind.NormalTower:
				normalUpgrade.Init(this);   
				break;

			default:
                break;
        
        }
    }
}
