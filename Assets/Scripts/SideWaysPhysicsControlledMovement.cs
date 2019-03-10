using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWaysPhysicsControlledMovement : MonoBehaviour {

    public float limit = 4.73f;
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

        GetComponent<Rigidbody2D>().position = currentPosition;
    }
}