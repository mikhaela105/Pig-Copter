using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour  // simple class to control the movement of clouds in backgroud so they scroll from right to left and will expire after a set time or once game has ended
{
    private GameObject console;
    public bool inGame;
    public float movementSpeed = 1;
    public float downSpeed = 1;
    private float timeAlive;
    private float aliveTime = 25f;

    // Use this for initialization
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
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            transform.Translate(Vector3.down * downSpeed * Time.deltaTime);
            timeAlive += Time.deltaTime;
            if (timeAlive >= aliveTime)// destroys cloud object if it has been alive long enough to pass off screen
                Destroy(gameObject);
        }
        else// destroys cloud object if the game ended
        {
            Destroy(gameObject);
        }
        

    }
}
