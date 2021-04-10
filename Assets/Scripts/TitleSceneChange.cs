using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneChange : MonoBehaviour
{
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			SceneManager.LoadScene("Level 1");
            GameController.playerDeathCount = 0;
        }
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

}
