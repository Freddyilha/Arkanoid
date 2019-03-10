using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviourDebug : MonoBehaviour {

    public float startSpeed = 3;
    bool isStarted = false;
    private int life;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * 5;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Lava")
        {
            SceneManager.LoadScene("Over");
        }
        else if (collision.collider.name == "Ceeling")
        {
            startSpeed += 1;
            print(startSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("OnTriggerEnter2D " + other.name);
    }

}
