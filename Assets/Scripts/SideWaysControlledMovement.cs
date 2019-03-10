using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWaysControlledMovement : MonoBehaviour {

    public float limit;
    public float speed = 0.5f;
    Vector2 currentPosition;

    // Update is called once per frame
    void Update () {
        currentPosition =  transform.position;


        if (Input.GetKey(KeyCode.RightArrow) && currentPosition.x < limit )
        {
            currentPosition.x += speed;

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && currentPosition.x > -limit)
        {
            currentPosition.x -= speed;
        }

        transform.position = currentPosition;
    }


    public void setScale()
    {
        transform.localScale = new Vector3(2f, 1.2f);
    }
}