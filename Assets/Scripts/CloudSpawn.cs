using UnityEngine;

public class CloudSpawn : MonoBehaviour
{

    private GameObject console;
    public bool inGame;
    public GameObject[] clouds;
    public float spawnTime = 0f;
   

    // initialization
    void Start()
    {
        console = GameObject.FindGameObjectWithTag("Console");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cloudPos = new Vector3();
        Quaternion rotation = new Quaternion();

        if (console.GetComponent<Console>().inGame) // is game running

        {
            if (Time.time >= spawnTime && console.GetComponent<Console>().distance <= 1500) //has suffcient time elapsed since last spawn && is player lower than the edge of space (score of ~1500)
            {
                spawnTime += Random.Range(0.5f, 1f); // random time until next spawn
                int randomIndex = Random.Range(0, clouds.Length - 1); //select random cloud object  
                rotation = Quaternion.Euler(0, 0, 0);
                cloudPos.x = 7;
                cloudPos.y = Random.Range(2f, 10f); // small random variation in y position is more visually appealing 
                cloudPos.z = 0;
                Instantiate(clouds[randomIndex], cloudPos, rotation);

            }
        }

    }
}


















