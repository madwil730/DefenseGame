using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyData EnemyData;

	public Transform[] movePositions; // 이동할 위치 배열
	private int currentIndex = 1; // 현재 목표 위치 인덱스
	private Coroutine wnaderCoroutine;


	private void OnEnable()
	{
		if (wnaderCoroutine == null)
		{
			//wnaderCoroutine = StartCoroutine(Wander());
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		gameObject.SetActive(false);
		transform.position = movePositions[0].position;
	}

	public void Init(EnemyData enemyData)
	{
		EnemyData = enemyData;
	}

	IEnumerator Wander()
	{
		while (true)
		{
			Vector3 targetPosition = movePositions[currentIndex].position;

			float distance = Vector3.Distance(transform.position, targetPosition);
			float duration = distance / EnemyData.Speed;


			yield return transform.DOMove(targetPosition, duration).WaitForCompletion();

			// 목표 인덱스를 갱신 (끝까지 갔으면 다시 처음으로)
			currentIndex = (currentIndex + 1) % movePositions.Length;


		}
	}
}
