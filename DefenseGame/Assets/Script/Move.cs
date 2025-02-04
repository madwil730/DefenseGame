using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static DG.Tweening.DOTweenCYInstruction;

public class Move : MonoBehaviour
{
	public float speed = 5f; // �̵� �ð�
	public Transform[] movePositions; // �̵��� ��ġ �迭
	private int currentIndex =1; // ���� ��ǥ ��ġ �ε���

	void Start()
	{
		StartCoroutine(Wander());
	}

	IEnumerator Wander()
	{
		while (true)
		{
			Vector3 targetPosition = movePositions[currentIndex].position;

			float distance = Vector3.Distance(transform.position, targetPosition);
			float duration = distance / speed;


			yield return transform.DOMove(targetPosition, duration).WaitForCompletion();

			// ��ǥ �ε����� ���� (������ ������ �ٽ� ó������)
			currentIndex = (currentIndex + 1) % movePositions.Length;


		}
	}
}
