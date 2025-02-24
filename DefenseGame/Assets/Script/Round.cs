using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
	private int index = 50;  // �ε��� ����
	public TextMeshProUGUI LifeText;
	public int RoundCount;



	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Enemy")
		{

			if(index <=0)
				GameManager.Instance.fail.SetActive(true);	
			// �ٸ� �ݶ��̴��� ������ �� �ε����� ����
			index--;
			LifeText.text = $"���� ���  :  {index}";
			Debug.Log("Collider Entered! Index: " + index);
		}

	}
}
