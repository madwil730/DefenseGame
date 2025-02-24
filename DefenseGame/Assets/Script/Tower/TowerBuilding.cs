using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBuilding : MonoBehaviour
{
    public Image TowerImage;
    public NormalTower NormalTower;
    public SpeedDownTower SpeedDownTower;
    public DefenseDownTower DefenseDownTower;
    public InComeTower InComeTower;

    [SerializeField]
	private BaseUpgrade baseUpgrade;
	[SerializeField]
	private NormalUpgrade normalUpgrade;
	[SerializeField]
	private DefenseDownUpgrade defenseDownUpgrade;
	[SerializeField]
	private SpeedDownUpgrade speedDownUpgrade;
	[SerializeField]
	private InComeUpgrade inComeUpgrade;

	public enum TowerKind
    {
        Base,
        NormalTower,
        DefenceDown,
        SpeedDown,
        InCome
    }

    public TowerKind Kind = TowerKind.Base;  

    public void Init()
    {
        switch (Kind)
        {
            case TowerKind.Base:
                baseUpgrade.Init(this);
                ActiveOff(baseUpgrade);
				break;

			case TowerKind.NormalTower:
				NormalTower.gameObject.SetActive(true);    
				normalUpgrade.Init(this);
				ActiveOff(normalUpgrade);
				break;

			case TowerKind.SpeedDown:
				SpeedDownTower.gameObject.SetActive(true);
				speedDownUpgrade.Init(this);
				ActiveOff(speedDownUpgrade);
				break;

			case TowerKind.DefenceDown:
				DefenseDownTower.gameObject.SetActive(true);
				defenseDownUpgrade.Init(this);
				ActiveOff(defenseDownUpgrade);
				break;

			case TowerKind.InCome:
				InComeTower.gameObject.SetActive(true);
				inComeUpgrade.Init(this);
				ActiveOff(inComeUpgrade);
				break;

			default:
                break;
        
        }
    }
    public void ActiveOff(UpgradeManager upgradeManager)
    {
       var instance =  GameManager.Instance;
        if(instance.upgradeTemp == null)
        {
            instance.upgradeTemp = upgradeManager.gameObject;
        }
        else if (instance.upgradeTemp == upgradeManager.gameObject)
        {
            return;
		}
        else
        {
            Debug.Log(instance.upgradeTemp.gameObject);
		    instance.upgradeTemp.SetActive(false);
			instance.upgradeTemp = upgradeManager.gameObject; 

		}

	}
}
