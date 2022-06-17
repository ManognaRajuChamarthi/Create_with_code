using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables.

    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // these variables are created in the update function so these can not be used in any other functions.
        float horizontal = Input.GetAxis("Horizontal");
        float vertial = Input.GetAxis("Vertical");

        // here we are changing the position and rotation parameters of our gameobject.
        //both of these lines genarally say vector3 in the directions that they want to affect multiply it with
        //Time.Deltatime to make it framerate independent and mutiply it with a variable that affects the rate ot whic these 
        //changes take place and multiply it with the axis value of the input.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertial);
        // we are using an if statement because we want to impliment a condition where we dont want our vehical to rotate if its not moving 
        // If we dont use this condition the vehical will rotate in the same place if we just activate the horizontal axis.
        if (vertial!=0f){
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontal);
        }
        
    }
}
