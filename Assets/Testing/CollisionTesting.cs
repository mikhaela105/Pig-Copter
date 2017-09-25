using UnityEngine;
using System.Collections;

public class CollisionTesting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter2D(Collision2D col)
    {
        IntegrationTest.Pass();
    }
}
