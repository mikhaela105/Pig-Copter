using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {

    public Vector2 startPos;
    public GameObject objects;

	// Use this for initialization
	void Start () {

        startPos = this.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        if (startPos.y != this.transform.position.y)
            IntegrationTest.Pass(gameObject);

	}
}
