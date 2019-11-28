using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
    public GameObject barrel;
    public float fireTime = 0.5f;
    private float timer;
    void Update()
    {
		Vector3 barrelPos = barrel.transform.position;
		Quaternion barrelRot = barrel.transform.rotation;
        if(timer > fireTime){
            Instantiate(bullet, barrelPos, barrelRot);
            timer -= fireTime;
        }
        timer += Time.deltaTime;
    }
}
