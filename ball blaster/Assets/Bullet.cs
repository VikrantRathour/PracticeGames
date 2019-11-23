using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;
    float damage = 1; 
    float ballHealthCheck;
    void Start()
    {
        Vector2 direction = Vector2.up;
        Vector2 velocity = speed * direction;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.transform.tag == "Ball"){
            // Destroy(other.gameObject);
            ballHealthCheck = other.gameObject.GetComponent<Ball>().ApplyDamage(damage);
            if(ballHealthCheck <= 0){
                Destroy(other.gameObject);
            }
            Spawner.ballCount -= 1;
        }
    }
}
