using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBehaviour : MonoBehaviour {

    private string Dificulty;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Game");
    }

    public void OnEasyClick()
    {
        PlayerPrefs.SetString("Difficulty", "Easy");
        Dificulty = "Easy";
        Debug.Log("Easy");
    }

    public void OnMediumClick()
    {
        PlayerPrefs.SetString("Difficulty", "Medium");
        Dificulty = "Medium";
        Debug.Log("Medium");
    }

    public void OnHardClick()
    {
        PlayerPrefs.SetString("Difficulty", "Hard");
        Dificulty = "Hard";
        Debug.Log("Hard");
    }

    public string getDificulty()
    {
        return Dificulty;
    }

}
