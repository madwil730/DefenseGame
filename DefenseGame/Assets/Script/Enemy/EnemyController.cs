using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyData EnemyData;

	public Transform[] movePositions; // �̵��� ��ġ �迭
	private int currentIndex = 1; // ���� ��ǥ ��ġ �ε���
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

			// ��ǥ �ε����� ���� (������ ������ �ٽ� ó������)
			currentIndex = (currentIndex + 1) % movePositions.Length;


		}
	}
}
