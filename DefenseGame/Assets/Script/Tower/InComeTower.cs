using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeTower : Tower
{
	private Projectile projectile;
	public int InCome = 1;

	private float timer = 0f;


	private void Start()
	{
		InCome = 1;
	}
	private void Update()
	{
		timer += Time.deltaTime; // ��� �ð� ����

		if (timer >= 1) // 1�� �̻� �����ٸ�
		{
			Debug.Log(InCome);
			GameManager.Instance.money += InCome; // �� ����
			timer = 0f; // Ÿ�̸� �ʱ�ȭ
		}

	}

	protected override void FireProjectile(Transform target)
	{
		throw new System.NotImplementedException();
	}
}
