using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
	public void quit()
	{
		Application.Quit();	
	}

	public void LoadScene(string str)
	{
		SceneManager.LoadScene(str);
	}
}
