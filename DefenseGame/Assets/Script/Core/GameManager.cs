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
		timer += Time.deltaTime; // ��� �ð� ����

		if (timer >= 1) // 1�� �̻� �����ٸ�
		{
			money += 1; // �� ����
			timer = 0f; // Ÿ�̸� �ʱ�ȭ
		}

		MoneyUI.text = $"�� :  {money}";
	}
}
