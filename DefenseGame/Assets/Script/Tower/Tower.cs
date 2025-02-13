using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
	public GameObject projectilePrefab; // 발사체 프리팹
	public Transform firePoint; // 발사 위치
	public float fireRate = 1f; // 초당 발사 속도
	public float projectileSpeed = 5f; // 발사체 속도
	public float Damage = 5;

	private List<Transform> enemiesInRange = new List<Transform>(); // 범위 내 적 리스트
	private Coroutine shootingCoroutine;

	protected void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Enemy")) // 적이 들어오면 리스트에 추가
		{
			enemiesInRange.Add(other.transform);
			if (shootingCoroutine == null)
			{
				shootingCoroutine = StartCoroutine(ShootProjectiles());
			}
		}
	}

	protected void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Enemy")) // 적이 나가면 리스트에서 제거
		{
			enemiesInRange.Remove(other.transform);
			if (enemiesInRange.Count == 0 && shootingCoroutine != null)
			{
				StopCoroutine(shootingCoroutine);
				shootingCoroutine = null;
			}
		}
	}
	private IEnumerator ShootProjectiles()
	{
		while (enemiesInRange.Count > 0)
		{
			Transform target = enemiesInRange[0]; // 첫 번째 적을 타겟으로 설정
			if (target != null)
			{
				FireProjectile(target);
			}
			yield return new WaitForSeconds(1f / fireRate);
		}
		shootingCoroutine = null;
	}
	protected abstract void FireProjectile(Transform target);

	protected void UpdatgeFireRate(float point)
	{
		fireRate += point;
	}

	protected void UpdatgeProjectileSpeed(float point)
	{
		projectileSpeed += point;
	}


}
