using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
	private int index = 50;  // 인덱스 변수
	public TextMeshProUGUI LifeText;
	public int RoundCount;



	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Enemy")
		{
			// 다른 콜라이더가 들어왔을 때 인덱스를 증가
			index--;
			LifeText.text = $"남은 목숨  :  {index}";
			Debug.Log("Collider Entered! Index: " + index);
		}

	}
}
