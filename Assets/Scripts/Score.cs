using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    PlayerController playerController;

    public GameObject ball;

    int score = 0;
    
    void Awake() {
        playerController = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerController>();
    }
    
    void Start () {
        score = 0;
	}

    void Update()
    {
        if (ball.transform.position.x < 10)
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
    }

}
