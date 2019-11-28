using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterControl : MonoBehaviour {

	public static ShooterControl instance;
	private Vector3 touchPosition;
	private Rigidbody2D rb;
	private Vector3 direction;
	private float moveSpeed = 10f;

	public float playerHealth = 100f;

	private void Start() {
		rb = GetComponent<Rigidbody2D>();
		instance = this;
	}
	private void Update() {
		if(Input.touchCount > 0){
			Touch touch = Input.GetTouch(0);
			touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
			touchPosition.z = 0;
			direction = (touchPosition - transform.position);
			rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

			if(touch.phase == TouchPhase.Ended){
				rb.velocity = Vector2.zero;
			}
		}
		
		if(playerHealth <= 0){
			GameHandler.GameOver();
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.CompareTag("Enemy")){
			playerHealth -= 50f;
			Destroy(other.gameObject);
		}
	}
}
