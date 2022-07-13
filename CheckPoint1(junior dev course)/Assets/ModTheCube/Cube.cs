using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    //used attributes
    [Header("variables")]
    public MeshRenderer Renderer;
    private float alpha = 0.4f ;
    public float rotationSpeed = 10;
    //public Slider slider;

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
        
        Rotate();

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Rotate()
    {
        
        //made a variable to control the speed of spining
        transform.Rotate(10.0f * Time.deltaTime * rotationSpeed, 0.0f, 0.0f);
    }


}
