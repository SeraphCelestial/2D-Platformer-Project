using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatKeybinds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))

        {
            SceneManager.LoadScene("Level 1");
        }

        if (Input.GetKeyDown(KeyCode.F2))

        {
            SceneManager.LoadScene("Level 2");
        }

        if (Input.GetKeyDown(KeyCode.F3))

        {
            SceneManager.LoadScene("Level 3");
        }

        if (Input.GetKeyDown(KeyCode.F4))

        {
            SceneManager.LoadScene("Bonus Level");
        }

        if (Input.GetKeyDown(KeyCode.F5))

        {
            GameController.playerDeathCount = 0;
        }

        if(Input.GetKeyDown(KeyCode.F6))

        {
            SceneManager.LoadScene("True Credits");
        }
    }
}
