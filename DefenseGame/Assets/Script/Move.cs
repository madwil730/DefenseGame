using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static DG.Tweening.DOTweenCYInstruction;

public class Move : MonoBehaviour
{
	public float speed = 5f; // 이동 시간
	public Transform[] movePositions; // 이동할 위치 배열
	private int currentIndex =1; // 현재 목표 위치 인덱스

	void Start()
	{
		StartCoroutine(Wander());
	}

	IEnumerator Wander()
	{
		while (true)
		{
			Vector3 targetPosition = movePositions[currentIndex].position;

			// 현재 위치와 목표 위치 간의 거리 계산
			float distance = Vector3.Distance(transform.position, targetPosition);

			// 속도에 맞춰 duration 계산 (duration = 거리 / 속도)
			float duration = distance / speed;


			yield return transform.DOMove(targetPosition, duration)
					   .SetEase(Ease.OutQuad)
					   .WaitForCompletion();

			// 목표 인덱스를 갱신 (끝까지 갔으면 다시 처음으로)
			currentIndex = (currentIndex + 1) % movePositions.Length;


		}
	}
}
