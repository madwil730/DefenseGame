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
		//Wander();
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
			sprite = enemyData.sprite,
			Speed = enemyData.Speed
		}; 
		spriteRenderer.sprite = enemyData.sprite;
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			EnemyData.Speed = 5;
		}

		if (movePositions.Length == 0) return;

		Vector3 targetPosition = movePositions[currentIndex].position;
		transform.position = Vector3.MoveTowards(transform.position, targetPosition, EnemyData.Speed * Time.deltaTime);

		if (Vector3.Distance(transform.position, targetPosition) < 0.01f) // ��ǥ ��ġ�� �����ϸ� ���� ��ġ�� ����
		{
			currentIndex = (currentIndex + 1) % movePositions.Length;
		}
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
