using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour {

    public AudioSource[] audios = new AudioSource[3];
    // sound[0] = BrickHitOne
    // sound[1] = PaddleHit
    // sound[2] = BreakBrick

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "BrickWeak")
        {
            //print("auhsdhuas: " + collision.collider.gameObject.GetComponent<BrickBehaviour>().getHits());
            if (collision.collider.gameObject.GetComponent<BrickBehaviour>().getHits() > 2)
                audios[2].Play();
            else
                audios[0].Play();
        }
        else if (collision.collider.tag == "Paddle")
            audios[1].Play();
    }
}
