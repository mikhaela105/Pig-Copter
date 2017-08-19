using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
	private BoxCollider2D skyCollider;
	private float skyVerticalLength;
	// Use this for initialization
	void Start () 
	{
		skyCollider = GetComponent<BoxCollider2D> ();
		skyVerticalLength = skyCollider.size.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -skyVerticalLength) 
		{
			repositionBackground ();
		}	
	}

	private void repositionBackground()
	{
		Vector2 skyOffset = new Vector2 (0, 8.87f  * 2.0f);
		transform.position = (Vector2)transform.position + skyOffset;
	}
}
