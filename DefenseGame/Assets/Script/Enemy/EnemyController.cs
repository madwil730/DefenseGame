using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyData EnemyData;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	public Transform[] movePositions; // �̵��� ��ġ �迭
	private int currentIndex = 1; // ���� ��ǥ ��ġ �ε���


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
		// ���� ���� �� ���
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
