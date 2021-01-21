using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	public float acceleration;
	private SpriteRenderer sr;
	private Rigidbody2D rb2;
	public float speedcap;
	public float jumpStrength;
	public bool grounded;
	public GameObject player;
	private Vector3 playerSpawnLoc;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
		rb2 = GetComponent<Rigidbody2D>();
		playerSpawnLoc = player.transform.position;
        rb2 = player.GetComponent<Rigidbody2D>();

    }

	void Update()
	{
		if(rb2.velocity.x > speedcap)
		{
			rb2.velocity = new Vector2(speedcap, rb2.velocity.y);
		}

		if(rb2.velocity.x < -speedcap)
		{
			rb2.velocity = new Vector2(-speedcap, rb2.velocity.y);
		}

		if(Input.GetButtonDown("Jump") && grounded)
		{
			rb2.AddForce(new Vector2(0, jumpStrength));
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			player.transform.position = playerSpawnLoc;
			rb2.velocity = new Vector2(0, 0);
		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("Level 1");
            GameController.playerDeathCount = 0;

        }
    }

    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") < 0)
		{
			sr.flipX = true;
			rb2.AddForce(new Vector2(-acceleration, 0));
		}

		 if(Input.GetAxisRaw("Horizontal") > 0)
		{
			sr.flipX = false;
			rb2.AddForce(new Vector2(acceleration, 0));
		}
    }

	private void OnTriggerStay2D(Collider2D collision)
	{
		if(collision.tag == "Ground")
		{
			grounded = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.tag == "Ground")
		{
			grounded = false;
		}
	}
}
