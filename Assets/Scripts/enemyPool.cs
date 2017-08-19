using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPool : MonoBehaviour {
	public int enemyPoolSize = 5;
	public GameObject enemiesPrefab;
	public float spawnRate;
	private GameObject[] enemies;
	private Vector2 firstOffscreenPosition = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawn;
	private float positionX;
	private float positionY;
	private int currentEnemy = 0;
	// Use this for initialization
	void Start () 
	{
		enemies = new GameObject[enemyPoolSize];
		for (int i = 0; i < enemyPoolSize; i++) 
		{
			enemies [i] = Instantiate (enemiesPrefab, firstOffscreenPosition, Quaternion.identity) as GameObject;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		timeSinceLastSpawn += Time.deltaTime;
		spawnRate = Random.Range (5.0f, 10.0f);
		if (timeSinceLastSpawn >= spawnRate) 
		{
			timeSinceLastSpawn = 0;
			positionY = Random.Range (8.0f, 15.0f);
			positionX = Random.Range (-2.4f, 2.4f);
			enemies [currentEnemy].transform.position = new Vector2 (positionX, positionY);
			currentEnemy++;
			if (currentEnemy >= enemyPoolSize) 
			{
				currentEnemy = 0;
			}
		}
	}
}
