using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Transform[] EnemySpawnPoints;
    public GameObject EnemyPrefab;
    public float spawnTime = 1f;
    public float timer;
    public Text playerHealthText;
    private void Update() {
        if(timer > spawnTime){
            GameObject newEnemy = Instantiate(EnemyPrefab, EnemySpawnPoints[Random.Range(0,3)]);
            timer -= spawnTime;
        }

        timer += Time.deltaTime;
        Debug.LogError(ShooterControl.instance.playerHealth);
        playerHealthText.text = "Health: " + ShooterControl.instance.playerHealth.ToString();
    }

    public static void GameOver(){
        Time.timeScale = 0;
    }
}
