using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public static int score = 0;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Balloon")){
            // Destroy(other.gameObject);
            // other.gameObject.GetComponent<Animation>().Play();
            Balloon.Poped(other.gameObject);
            score++;
        }
        if(other.gameObject.CompareTag("MoreArrows")){
            Destroy(other.gameObject);
            GameHandler.ArrowsLeft += 15;
        }
    }
}
