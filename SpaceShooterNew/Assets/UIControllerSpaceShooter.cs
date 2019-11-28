using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControllerSpaceShooter : MonoBehaviour
{
    public static UIControllerSpaceShooter instance;
    public GameObject scoreText;
    public float score = 0;
    private void Start() {
        if(instance == null){
            instance = this;
        }
    }

    private void Update() {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
