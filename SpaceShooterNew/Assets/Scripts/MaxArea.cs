using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxArea : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D other) {
        Debug.LogError("df");
        Destroy(other.gameObject);
    }
}
