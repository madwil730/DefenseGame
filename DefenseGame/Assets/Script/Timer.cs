using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public TextMeshProUGUI tmpText;  // TMP Text 객체
	private float elapsedTime = 0f;  // 경과 시간 (초 단위)

	void Update()
	{
		// 경과 시간 업데이트
		elapsedTime += Time.deltaTime;

		// 분과 초로 변환
		int minutes = Mathf.FloorToInt(elapsedTime / 60f);  // 분 계산
		int seconds = Mathf.FloorToInt(elapsedTime % 60f);  // 초 계산

		// TMP 텍스트에 경과 시간 표시
		tmpText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
