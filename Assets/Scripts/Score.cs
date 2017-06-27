using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    PlayerController playerController;

    public Text scoreTextUI;

    public GameObject ball;
    public int score = 0;
    public Rigidbody rb;

    void Awake() {
        playerController = GameObject.Find("PlayerManager").GetComponent<PlayerController>();
    }
    
    void Start () {
        score = 0;
	}

    void Update()
    {
        scoreTextUI.text = "Score: " + score;

        if (ball.transform.position.y <= -2)
        {
            GameOver();
        }

    }
    
    public void ScoreKeeper()
    {
        score++;
    }

    public void GameOver()
    {
        Application.Quit();
        print("gameober");
    }

}
