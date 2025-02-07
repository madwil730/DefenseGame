using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBuilding : MonoBehaviour
{
	public Button NormalTower;

   public enum TowerKind
    {
        Base,
        NormalTower,
        FireTower,
        TowerNull
    }

    public TowerKind Kind = TowerKind.Base;  

    public void Init()
    {
        switch (Kind)
        {
            case TowerKind.NormalTower:
				NormalTower.gameObject.SetActive(true);
				break;  

            default:
                break;
        
        }
    }
}
