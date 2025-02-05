using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpqwnManager : MonoBehaviour
{
    [SerializeField]
    private List<EnemyController> enemys;
    [SerializeField]
    private List<EnemyData> enemyDatas;
    private bool SpawnCheck;
    private bool LastEnemyGo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {

        foreach (var enemy in enemys)
        {
            enemy.Init(enemyDatas[GameManager.Instance.Round.RoundCount]);
            enemy.gameObject.SetActive(true);
			if (enemys.IndexOf(enemy) == enemys.Count - 1)
            {
				LastEnemyGo = true;
			}
				yield return new WaitForSeconds(0.5f);

        }
	}


    public void NextSpawnCheck()
    {
        if (!LastEnemyGo)
            return;

		foreach (var enemy in enemys)
        {
            if(enemy.gameObject.activeSelf)
            {
				SpawnCheck= false;
                break;
			}
            else
				SpawnCheck = true;
		}

        if(SpawnCheck)
        {

			GameManager.Instance.Round.RoundCount++;
            Debug.Log(GameManager.Instance.Round.RoundCount);
            Debug.Log(enemyDatas.Count);
            if(enemyDatas.Count > GameManager.Instance.Round.RoundCount)
            {
                LastEnemyGo = false;

			    StartCoroutine(Spawn());

            }
        }

	}
   
}
