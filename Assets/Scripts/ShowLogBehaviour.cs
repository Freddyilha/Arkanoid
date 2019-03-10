using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLogBehaviour : MonoBehaviour {

    Vector2 startPosition;
    private int counter;
    

    // Use this for initialization
    void Start () {
        //startPosition = transform.position;
        print(RetornaLado());
        
    }
	
	// Update is called once per frame
	void Update () {
        IndicaLado(transform.position.x);
        IncreaseCounter();
        TooLongIdling(counter);
        GettingStuck();
    }

    void IndicaLado(float position)
    {
        if (position > 0)
            Debug.Log("Estou na direita");
        else
            Debug.Log("Estou na esquerda");
    }

    string RetornaLado()
    {
        if (transform.position.x > 0)
            return ("Comecei a direita na posição x=" + transform.position.x);
        else
            return ("Comecei a esquerda na posição x=" + transform.position.x);
    }

    void IncreaseCounter()
    {
        counter += 1;
    }

    void TooLongIdling(int i)
    {

        if (i == 100)
        {
            print("Are you there?");
        }
        else if (i == 200)
        {
            print("HEY! Are you there?");
        }
        else if (i == 300)
        {
            print("Come on do something?");
        }
        else if (i == 400)
        {
            print("I'm getting tired!!!!!?");
        }
        else if (i == 500)
        {
            print("That's it i'm OUT!!!!!");
        }

    }

    void GettingStuck()
    {
        if (transform.position.x > GetComponent<Sideways_Movement>().distance)
        {
            GetComponent<Sideways_Movement>().speed = 0;
            Invoke("ContinueMovement", 5);
        }
    }

    void ContinueMovement()
    {
        GetComponent<Sideways_Movement>().speed = 0.2f;
    }

}
