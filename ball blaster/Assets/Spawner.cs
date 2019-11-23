using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ball;
    public Transform[] points;
    public float spawnTime = 1;
    public int maxBallCount = 4;
    [HideInInspector]
    public static int ballCount = 0;
    private float timer;
    void Update()
    {
        if(timer>spawnTime && ballCount < maxBallCount){
            GameObject newBall = Instantiate(ball, points[Random.Range(0, 4)]);
            ballCount++;
            timer -= spawnTime;
        }
        timer += Time.deltaTime;
    }
}
