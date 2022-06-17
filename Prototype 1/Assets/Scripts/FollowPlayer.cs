using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variable Declaration

    public GameObject player;
    public Vector3 offSet = new Vector3(0,0,0) ;// dont forget the new keyword when you are initializing a new datatype( like gameobject vectors and manymore)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after the Update Call
    void LateUpdate()
    {
        transform.position = (player.transform.position + offSet);
    }
}
