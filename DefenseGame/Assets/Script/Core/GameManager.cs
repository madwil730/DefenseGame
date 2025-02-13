using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	public Round Round;
	public EnemySpqwnManager EnemySpqwnManager;
	[HideInInspector]
	public GameObject upgradeTemp;
	[HideInInspector]
	public int money = 100;
	private float timer = 0f; 

	public TextMeshProUGUI MoneyUI;

	protected override void Awake()
	{
		base.Awake();
		money = 100;
	}

	private void Update()
	{
		timer += Time.deltaTime; // 경과 시간 누적

		if (timer >= 1) // 1초 이상 지났다면
		{
			money += 1; // 돈 증가
			timer = 0f; // 타이머 초기화
		}

		MoneyUI.text = $"돈 :  {money}";
	}
}
