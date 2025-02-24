using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
	public Round Round;
	public EnemySpqwnManager EnemySpqwnManager;
	[HideInInspector]
	public GameObject upgradeTemp;
	[HideInInspector]
	public int money = 100;
	private float timer = 0f;

	[SerializeField]
	public GameObject claer;
	[SerializeField]
	public GameObject fail;

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

	public void Quit()
	{
		Application.Quit();	
	}

	public void LoadScene(string str)
	{
		SceneManager.LoadScene(str);
	}
}
