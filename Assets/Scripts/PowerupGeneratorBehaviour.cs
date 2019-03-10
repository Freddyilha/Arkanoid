using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGeneratorBehaviour : MonoBehaviour {


    public GameObject PowerUpPrefab;

    // Use this for initialization
    void Start () {
        //Invoke("createPowerUp", 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void createPowerUp()
    {
        //!!!!!!!!!!!!!!!CONFERIRI ESSA PARADA!!!!!!!!!!!!!!!!!!!!!!
        GameObject powerUp = Instantiate<GameObject>(PowerUpPrefab);
        powerUp.transform.position = new Vector2(UnityEngine.Random.Range(-5.6f, 5.6f), 4.5f);
    }

        
}
