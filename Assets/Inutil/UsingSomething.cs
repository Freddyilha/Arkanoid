using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingSomething : MonoBehaviour {

    public Turtle turtleOne = new Turtle("Koppa");
    public Turtle turtleTwo = new Turtle("HammeBro");
    public Turtle turtleThree = new Turtle("Troppa");

    // Use this for initialization
    void Start () {
        turtleOne.fly();
        print("state: " + turtleOne.getState());

        turtleTwo.walk();
        print("state: " + turtleTwo.getState());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
