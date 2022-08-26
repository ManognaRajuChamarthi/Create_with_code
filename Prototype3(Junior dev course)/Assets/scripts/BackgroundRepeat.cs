using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //Variables

    private Vector3 initialPos;
    public float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < initialPos.x - repeatWidth)
        {
            transform.position = initialPos;
        }
    }
}
