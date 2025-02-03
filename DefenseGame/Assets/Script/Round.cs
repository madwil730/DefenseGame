using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
	private int index = 0;  // 인덱스 변수
	public TextMeshProUGUI LifeText;



	void OnTriggerEnter2D(Collider2D other)
	{
		// 다른 콜라이더가 들어왔을 때 인덱스를 증가
		index++;
		LifeText.text = index.ToString();
		Debug.Log("Collider Entered! Index: " + index);
	}
}
