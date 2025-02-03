using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpqwnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Enemys;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        foreach (var enemy in Enemys)
        {
            enemy.SetActive(true);
            yield return new WaitForSeconds(0.1f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
