using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle{

    private int life;
    private int speed;
    private string name;
    private string state;

    //private const string 

    public Turtle(string nomeTartaruga)
    {
        this.name = nomeTartaruga;
        this.life = 1;
        this.state = "Idle";
    }

    public void walk()
    {
        Debug.Log("Walking!!! " + this.name);
        state = "walk";
    }

    public void rest()
    {
        Debug.Log("Resting!!! " + this.name);
        state = "rest";
    }

    public void fly()
    {
        Debug.Log("Flying!!! " + this.name);
        state = "fly";
    }

    public void jump()
    {
        Debug.Log("jumping!!! " + this.name);
        state = "jump";
    }

    public string getState(){
        return state;
    }

}
