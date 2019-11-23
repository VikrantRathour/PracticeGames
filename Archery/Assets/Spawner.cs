using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] balloons;
    public Transform[] points;
    public GameObject MoreArrows;
    public float spawnTime = 0.5f;
    private float timer;
    private float MoreArrowsSpawnTime = 45f;
    private float timerForArrows = 0;
    private float timerForSpeed = 0;
    void Update()
    {
        if(timerForSpeed >= 10){
            Balloon.speed += 1;
            timerForSpeed = 0;
            spawnTime -= 0.05f;
        }
        if(timer > spawnTime){
            GameObject newBall = Instantiate(balloons[Random.Range(0,3)], points[Random.Range(0, 5)]);
            timer -= spawnTime;
        }
        if(timerForArrows > MoreArrowsSpawnTime){
            GameObject newBall = Instantiate(MoreArrows, points[Random.Range(0, 5)]);
            timerForArrows -= MoreArrowsSpawnTime;
        }
        timer += Time.deltaTime;
        timerForSpeed += Time.deltaTime;
        timerForArrows += Time.deltaTime;
    }
}
