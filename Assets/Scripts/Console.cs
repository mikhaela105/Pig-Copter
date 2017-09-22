using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Console : MonoBehaviour {

    public GameObject[] Views;
    public GameObject player, distanceText;
    public int distance, distanceIncSpeed;
    public bool show, hide;
    public bool inGame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (CrossPlatformInputManager.GetButtonDown("Play"))
        {
            //BEGIN THE GAME
            NewGame();
            inGame = true;
            HideView(Views[0]);
        }

        if (inGame)
            IncrementScore(distanceIncSpeed);

        if (show)
        {
            ShowView(Views[0]);
            show = false;
        }
	}

    public void NewGame()
    {
        player.GetComponentInChildren<PlayerScript>().Reset();
        distance = 0;
        inGame = true;
        Views[1].active = true;
    }

    public void IncrementScore(int speed)
    {
        distance += speed;
        distanceText.GetComponent<TextMesh>().text = distance.ToString();
    }

    public void GameOver()
    {
        //KILL ALL ENEMIES
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
            Destroy(enemies[i].gameObject);
        
        GameObject[] collectibles = GameObject.FindGameObjectsWithTag("Collectible");
        for (int i = 0; i < collectibles.Length; i++)
            Destroy(collectibles[i].gameObject);

        distance = 0;
        inGame = false;
        Views[1].active = false;
        ShowView(Views[0]);
    }

    public void ShowView(GameObject canvas)
    {
        foreach (Transform child in canvas.transform)
        {
            if (child.GetComponent<Image>())
                child.GetComponent<UIFadeScript>().FadeIn();
            if (child.GetComponentInChildren<Text>())
                child.GetComponentsInChildren<UIFadeScript>()[1].FadeIn(); //First Child
        }
    }

    public void HideView(GameObject canvas)
    {
        foreach (Transform child in canvas.transform)
        {
            if (child.GetComponent<Image>())
                child.GetComponent<UIFadeScript>().FadeOut();
            if (child.GetComponentInChildren<Text>())
                child.GetComponentsInChildren<UIFadeScript>()[1].FadeOut(); //First Child
        }
    }
}
