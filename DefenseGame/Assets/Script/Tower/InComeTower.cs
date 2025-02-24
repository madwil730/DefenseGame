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
		timer += Time.deltaTime; // 경과 시간 누적

		if (timer >= 1) // 1초 이상 지났다면
		{
			Debug.Log(InCome);
			GameManager.Instance.money += InCome; // 돈 증가
			timer = 0f; // 타이머 초기화
		}

	}

	protected override void FireProjectile(Transform target)
	{
		throw new System.NotImplementedException();
	}
}
