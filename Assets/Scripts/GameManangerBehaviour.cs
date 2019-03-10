using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManangerBehaviour : MonoBehaviour
{
    public static string levelDifficulty;
    public GameObject paddle;
    public GameObject specialItemPrefab;
    public GameObject BrickWallStageOnePrefab;
    public GameObject BrickWallStageTwoPrefab;
    public GameObject BrickWallStageThreePrefab;
    public int specialItemInterval;
    bool isStarted = false;
    public float startSpeed = 3;
    private int totalPoints = 0;

    public static GameManangerBehaviour instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != gameObject)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        Invoke("createSpecialItem", 1);
        String stageLevel = PlayerPrefs.GetString("Difficulty");
        if (stageLevel == "Easy")
        {
            GameObject brickWall = Instantiate<GameObject>(BrickWallStageOnePrefab);
            brickWall.transform.position = new Vector2(0f, 0f);
        }
        else if (stageLevel == "Medium")
        {
            GameObject brickWall = Instantiate<GameObject>(BrickWallStageTwoPrefab);
            brickWall.transform.position = new Vector2(0f, 0f);
        }
        else if (stageLevel == "Hard")
        {
            GameObject brickWall = Instantiate<GameObject>(BrickWallStageThreePrefab);
            brickWall.transform.position = new Vector2(-5.6f, 4.6f);
        }
    }

    protected void createSpecialItem()
    {
        GameObject specialItemTemp = Instantiate<GameObject>(specialItemPrefab);
        specialItemTemp.transform.position = new Vector2(UnityEngine.Random.Range(-6, 6), UnityEngine.Random.Range(-4, 1));
        // specialItemTemp.GetComponent<SpecialItemBehaviour>().gameManager = this;
    }

    public void gameOver()
    {
        SceneManager.LoadScene("Scenes/Over", LoadSceneMode.Single);
    }

    public void onSpecialItemCollision()
    {
        //Armazena o tamanho atual para modificar e atribuir ao parametro size que não permite escrita.
        Vector2 paddleCurrentSize = paddle.GetComponent<SpriteRenderer>().size;
        paddleCurrentSize.x += 1;
        //Atualiza tanto o tamanho do sprite como também o do collider.
        paddle.GetComponent<SpriteRenderer>().size = paddleCurrentSize;
        paddle.GetComponent<BoxCollider2D>().size = paddleCurrentSize;

        Invoke("createSpecialItem", 5);
    }

    public void onBallHit(Collider2D collider)
    {
        print(">>> " + collider.name);
        if (collider.tag == "Wall")
            addPoint(10);
        else if (collider.tag == "BrickWeak")
            addPoint(20);
        else if (collider.name == "Lava")
            gameOver();
        
    }

    public void onPowerUpSizeTouch(Collider2D collider)
    {
        if (collider.tag == "PowerUpSize")
        {
            onSpecialItemCollision();
            Destroy(collider.gameObject);
        }
    }

    public void addPoint(int point)
    {
        totalPoints += point;
    }

    public void onGameStart()
    {
        if (!isStarted && (!Input.GetKey(KeyCode.RightArrow) || !Input.GetKey(KeyCode.LeftArrow)))
        {
            Vector2 direction = Vector2.zero;
            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction = (Vector2.up + Vector2.right);
                isStarted = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction = (Vector2.up + Vector2.left);
                isStarted = true;
            }
            GetComponent<Rigidbody2D>().velocity = direction * startSpeed;

        }
    }
}