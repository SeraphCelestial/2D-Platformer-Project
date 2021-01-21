using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetPlayer : MonoBehaviour
{
	public GameObject player;
	private Vector3 playerSpawnLoc;
    private Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        playerSpawnLoc = player.transform.position;
        rb2 = player.GetComponent<Rigidbody2D>();
    }


	void OnCollisionEnter2D(Collision2D collision)
	{
		rb2.velocity = new Vector2(0, 0);
		player.transform.position = playerSpawnLoc;
		GameController.playerDeathCount ++;
		print("Death Count: " + GameController.playerDeathCount);
	}

}
