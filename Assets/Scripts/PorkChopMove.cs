using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkChopMove : MonoBehaviour {


	public int playerSpeed = 10;
	public float moveX;
	public float moveXMobile;
	private bool isDead = false;
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();

		StartCoroutine (gameWait ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isDead == false && GameControl.instance.gameStart == true) 
		{
			
			GameControl.instance.playerScored ();

			moveX = Input.GetAxis ("Horizontal");
			moveXMobile = Input.acceleration.x;
			rb2d.velocity = new Vector2 (moveX * playerSpeed, rb2d.gameObject.GetComponent<Rigidbody2D> ().velocity.y);
			if (transform.position.x <= -2.4f) {
				transform.position = new Vector2 (-2.4f, transform.position.y);
			} 
			else if (transform.position.x >= 2.4f) 
			{
				transform.position = new Vector2 (2.4f, transform.position.y);		
			}

		}
	}

	IEnumerator gameWait()
	{
		GameControl.instance.gameStartText.SetActive (true);


		yield return new WaitUntil (() => GameControl.instance.gameStart == true);

	}
	void OnCollisionEnter2D(Collision2D coll) 
	{	
		print ("working");
		isDead = true;


		if (isDead == true) 
		{
			GameControl.instance.playerDied ();
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
		}	


	}
}
