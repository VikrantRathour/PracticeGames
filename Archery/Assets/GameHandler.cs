using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    // float currentTime = 0f;
    // float totalTime = 120f;
    [HideInInspector]
    public static float ArrowsLeft = 30;
    [HideInInspector]
    public static bool ConfirmGameOver = false;
    // [SerializeField]
    // Text countdownText;
    [SerializeField]
    Text ArrowsText;
    [SerializeField]
    Text score;
    [SerializeField]
    Image[] gameOver;
    [SerializeField]
    Text gameOverText;
    [SerializeField]
    Text gameOverScoreText;
    public GameObject spawner;
    public GameObject bow;
    void Start()
    {
        // currentTime = totalTime;
        gameOver[0].enabled = false;
        gameOver[1].enabled = false;
        // gameOver[2].enabled = false;
        gameOverText.text = "";
    }

    void Update()
    {
        // currentTime -= 1 * Time.deltaTime;
        // countdownText.text = "" +(int) currentTime;
        ArrowsText.text = "" + (int) ArrowsLeft; 
        score.text = ""+Arrow.score; 
        // if(ArrowsLeft <= 0){
        if(ConfirmGameOver){
            // currentTime = 0;
            gameOver[0].enabled = true;
            gameOver[1].enabled = true;
            // gameOver[2].enabled = true;
            gameOverText.text = "Out of Arrows";
            gameOverScoreText.text = "Your Score is:" + Arrow.score;
            spawner.SetActive(false);
            bow.SetActive(false);
        }
    }
}
