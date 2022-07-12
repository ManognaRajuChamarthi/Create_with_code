using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if(other.CompareTag("Ground"))
        {
            Debug.Log("gameOver!");
        }
    }
}
