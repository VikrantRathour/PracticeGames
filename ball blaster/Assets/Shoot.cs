using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    public float fireTime = 0.5f;
    private float timer;
    void Update()
    {
        if(timer > fireTime){
            Instantiate(bullet, barrel);
            timer -= fireTime;
        }
        timer += Time.deltaTime;
    }
}
