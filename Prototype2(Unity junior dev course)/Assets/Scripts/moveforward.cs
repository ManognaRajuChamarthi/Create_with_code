using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    //Variables
    public float speed = 40.0f;
    public int lowerBound = -5;
    public int upperBound = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z < lowerBound)
        {
            Debug.Log("gameOver!");
            Destroy(gameObject);
        }else if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
    }
}
