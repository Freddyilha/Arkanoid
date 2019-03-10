using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManangerBehaviour.instance.onBallHit(collision.collider);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManangerBehaviour.instance.onBallHit(other);
    }

}
