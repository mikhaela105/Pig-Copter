using UnityEngine;
using System.Collections;

public class TestAudio : MonoBehaviour {

    AudioSource a;

	// Use this for initialization
	void Start () {
        a = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (a.isPlaying)
            IntegrationTest.Pass();

	}
}
