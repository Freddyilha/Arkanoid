using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour {

    private int hits;
    private Color[] colours = new Color[] { new Color(0f, 1f, 1f), new Color(0f, 1f, 0f) };
    public Sprite[] spritesList = new Sprite[2];

    // Use this for initialization
    void Start () {
        hits = 0;
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "ball")
        {
            //print(hits);
            if (hits > 1)
                Destroy(gameObject);
            else
            {
                GetComponent<SpriteRenderer>().sprite = spritesList[hits];
                GetComponent<SpriteRenderer>().color = colours[hits];
            }
            hits += 1;
        }
        
    }

    public int getHits()
    {
        return hits;
    }
}
