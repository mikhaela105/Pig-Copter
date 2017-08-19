using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScroll : MonoBehaviour {
	private float position;
	private float newPos;
	// Use this for initialization
	void Start () 
	{
		position = Random.Range (-2.4f, 2.4f);
		transform.position = new Vector2 (position, transform.position.y); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		position += Time.deltaTime + Random.Range (0.01f, 0.04f);
		newPos = Mathf.PingPong (position, 4.4f) - 2.4f;
		transform.position = new Vector2 (newPos, transform.position.y); 
	}
}
