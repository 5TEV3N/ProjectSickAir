using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    PlayerController playerController;

    public Text scoreTextUI;
    public Text GameOverTextUI;
    public GameObject ball;
    public int score = 0;
    public Rigidbody rb;
    public bool isGameOver;

    void Awake()
    {
        playerController = GameObject.Find("PlayerManager").GetComponent<PlayerController>();
        GameOverTextUI.gameObject.SetActive(false);
    }
    
    void Start () {
        score = 0;
	}

    void Update()
    {
        scoreTextUI.text = "Score: " + score;

        if (ball.transform.position.y <= -3.1)
        {
            GameOver();
            isGameOver = true;
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.R))
            {
                isGameOver = false;
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }

    }
    
    public void ScoreKeeper()
    {
        score++;
    }

    public void GameOver()
    {
        GameOverTextUI.gameObject.SetActive(true);
    }

}
