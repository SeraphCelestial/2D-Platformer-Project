using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl2SceneChange : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("Level 3");
	}

}
