using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeTower : Tower
{
	private Projectile projectile;
	[HideInInspector]
	public int InCome;

	private float timer = 0f;


	private void Update()
	{
		timer += Time.deltaTime; // ��� �ð� ����

		if (timer >= 1) // 1�� �̻� �����ٸ�
		{
			GameManager.Instance.money += InCome; // �� ����
			timer = 0f; // Ÿ�̸� �ʱ�ȭ
		}

	}

	protected override void FireProjectile(Transform target)
	{
		throw new System.NotImplementedException();
	}
}
