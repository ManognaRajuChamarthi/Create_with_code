using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //used attributes
    [Header("variables")]
    public MeshRenderer Renderer;
    private float alpha = 0.4f ;
    [RangeAttribute(1f, 100f)]//using rangeattribute to have fun experiance in the inspector
    public float rotationSpeed;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        //changed local scale form 1.3 to 5
        transform.localScale = Vector3.one * 5.0f;

        Material material = Renderer.material;
        //color changed to red and made alpha a variable to a variable instead of hardcoding
        material.color = new Color(1.0f, 0f, 0f, alpha);

    }
    
    void Update()
    {
        //made a variable to control the speed of spining
        transform.Rotate(10.0f * Time.deltaTime * rotationSpeed, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


}
