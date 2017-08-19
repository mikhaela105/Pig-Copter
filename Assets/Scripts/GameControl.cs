using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {

	public GameObject enemySpawn;
	public static GameControl instance;
	public GameObject gameOverText;
	public GameObject gameStartText;
	public float scrollSpeed = -1.5f;
	public bool gameover = false;
	public bool gameStart = false;
	public int score = 0;
	public Text scoreText;
	// Use this for initialization
	void Awake () 
	{
		
		if (instance == null) {
			instance = this;
		} else if (instance != this) 
		{
			Destroy (gameObject);
		}
		enemySpawn.GetComponent<enemyPool> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameover == true && Input.GetKey(KeyCode.Space))//&& Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
		if (gameStart == false && Input.GetKey(KeyCode.Space)) 
		{
			enemySpawn.GetComponent<enemyPool> ().enabled = true;
			gameStarted ();
		}
	}


	public void playerScored()
	{
		score ++;
		scoreText.text = "Score: " + score.ToString ();

	}
	public void playerDied()
	{
		gameOverText.SetActive (true);
		gameover = true;
	}

	public void gameStarted()
	{
		GameControl.instance.gameStartText.SetActive (false);
		gameStart = true;
	}
}
