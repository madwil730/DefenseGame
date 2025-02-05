using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyData EnemyData;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	public Transform[] movePositions; // 이동할 위치 배열
	private int currentIndex = 1; // 현재 목표 위치 인덱스


	private void OnEnable()
	{
		Wander();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Projectile")
		{
			Projectile projectile = collision.GetComponent<Projectile>();
			EnemyData.HP = EnemyData.HP - projectile.Damage;
			if (EnemyData.HP < 0)
			{
				transform.DOKill();
				transform.position = movePositions[0].position;
				gameObject.SetActive(false);
			
				GameManager.Instance.EnemySpqwnManager.NextSpawnCheck();
			}
		}
	}

	public void Init( EnemyData enemyData)
	{
		// 깊은 복사 후 사용
		EnemyData = new EnemyData
		{
			HP = enemyData.HP,
			color = enemyData.color,
			Speed = enemyData.Speed
		}; 
		spriteRenderer.color = enemyData.color;
	}

	public void Wander()
	{
		Vector3 targetPosition = movePositions[currentIndex].position;

		float distance = Vector3.Distance(transform.position, targetPosition);
		float duration = distance / EnemyData.Speed;

		transform.DOMove(targetPosition, duration).OnComplete(() =>
		{
			currentIndex = (currentIndex + 1) % movePositions.Length;
			Wander();
		});
	}
}
