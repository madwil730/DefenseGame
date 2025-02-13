using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
	public GameObject projectilePrefab; // �߻�ü ������
	public Transform firePoint; // �߻� ��ġ
	public float fireRate = 1f; // �ʴ� �߻� �ӵ�
	public float projectileSpeed = 5f; // �߻�ü �ӵ�
	public float Damage = 5;

	private List<Transform> enemiesInRange = new List<Transform>(); // ���� �� �� ����Ʈ
	private Coroutine shootingCoroutine;

	protected void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Enemy")) // ���� ������ ����Ʈ�� �߰�
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
		if (other.CompareTag("Enemy")) // ���� ������ ����Ʈ���� ����
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
			Transform target = enemiesInRange[0]; // ù ��° ���� Ÿ������ ����
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
