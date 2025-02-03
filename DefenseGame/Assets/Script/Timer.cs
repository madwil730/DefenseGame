using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public TextMeshProUGUI tmpText;  // TMP Text ��ü
	private float elapsedTime = 0f;  // ��� �ð� (�� ����)

	void Update()
	{
		// ��� �ð� ������Ʈ
		elapsedTime += Time.deltaTime;

		// �а� �ʷ� ��ȯ
		int minutes = Mathf.FloorToInt(elapsedTime / 60f);  // �� ���
		int seconds = Mathf.FloorToInt(elapsedTime % 60f);  // �� ���

		// TMP �ؽ�Ʈ�� ��� �ð� ǥ��
		tmpText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
