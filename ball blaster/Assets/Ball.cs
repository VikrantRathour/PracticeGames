using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    
    float speed = 2;
    [HideInInspector]
    public static float ballHealth;
    public TextMesh text;
    void Start()
    {
        ballHealth = Random.Range(0,6);
        Vector2 direction = Vector2.right;
        Vector2 velocity = speed * direction;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    void Update()
    {
        text.GetComponent<TextMesh>().text = "" + ballHealth;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.transform.tag == "Bullet"){
            Destroy(other.gameObject);
        }
    }
    public float ApplyDamage(float damage){
        ballHealth -= damage;
        return ballHealth;
    }
}
    
