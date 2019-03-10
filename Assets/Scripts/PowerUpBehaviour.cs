using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.tag == "Paddle")
        {
            trig.gameObject.GetComponent<SideWaysControlledMovement>().setScale();
            //print(trig.gameObject.GetComponent<Transform>().localScale.x);
            //collision.collider.gameObject.GetComponent<BrickBehaviour>().getHits()
            Destroy(gameObject);
        }
    }
}
