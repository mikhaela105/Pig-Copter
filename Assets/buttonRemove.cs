using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonRemove : MonoBehaviour { // removes buttons once game begins
    private GameObject console;
    public bool inGame;
    void Start()
    {
        console = GameObject.FindGameObjectWithTag("Console");
    }

    // Update is called once per frame
    void Update()
    {
        inGame = console.GetComponent<Console>().inGame;

        if (inGame)
        {
            Destroy(gameObject);
        }
	}
}
