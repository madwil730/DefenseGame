using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
	private int index = 0;  // �ε��� ����
	public TextMeshProUGUI LifeText;



	void OnTriggerEnter2D(Collider2D other)
	{
		// �ٸ� �ݶ��̴��� ������ �� �ε����� ����
		index++;
		LifeText.text = index.ToString();
		Debug.Log("Collider Entered! Index: " + index);
	}
}
