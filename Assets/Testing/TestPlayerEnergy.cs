using UnityEngine;
using System.Collections;

public class TestPlayerEnergy : MonoBehaviour {

    public float energy = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (this.GetComponent<PlayerScript>().energy < 100)
            IntegrationTest.Pass();

	}
}
