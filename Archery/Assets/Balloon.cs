using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public static float speed = 5;
    public static Animator myAnim;
    void Start()
    {
        Vector2 direction = Vector2.up;
        Vector2 velocity = speed * direction;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    public static void Poped(GameObject balloon){
        
        myAnim = balloon.GetComponent<Animator>();

        myAnim.SetBool("pop", true);
        
        balloon.GetComponent<Rigidbody2D>().simulated = false;
        
    }
}
