using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
	float speed = 10;
	// Use this for initialization
	void Start () {
		Vector2 direction = Vector2.down;
        Vector2 velocity = speed * direction;
        GetComponent<Rigidbody2D>().velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")){
			Debug.LogError("PlayerHitted");
			other.gameObject.GetComponent<ShooterControl>().playerHealth -= 10f;
			Destroy(gameObject);
		}
	}
	
}
