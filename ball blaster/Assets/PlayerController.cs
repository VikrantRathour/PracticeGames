using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * speed; 
        // if(Input.GetTouch(0).phase == TouchPhase.Moved)
        //  {
        //      Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
        //      touchDeltaPosition = new Vector2(touchDeltaPosition.x,
        //                                       0);
        //      GetComponent<Rigidbody2D>().velocity = touchDeltaPosition;
        //  }   

        
    }
}
