using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float speed = 3;
    public float enemyHealth = 100;
	// Use this for initialization
	void Start () {
		Vector2 direction = Vector2.down;
        Vector2 velocity = speed * direction;
        GetComponent<Rigidbody2D>().velocity = velocity;
	}

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0){
            Destroy(gameObject);
        }
        
    }
}
