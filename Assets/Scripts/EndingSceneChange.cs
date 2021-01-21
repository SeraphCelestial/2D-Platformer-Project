using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneChange : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(GameController.playerDeathCount == 0)
		{
			SceneManager.LoadScene("Bonus Level Intro");
		}
		else
		{
			SceneManager.LoadScene("Normal Credits");
		}
		
	}

}
