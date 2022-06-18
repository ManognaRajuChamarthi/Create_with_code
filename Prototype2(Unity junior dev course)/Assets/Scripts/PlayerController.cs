using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 15f)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -15f)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
    }
}
