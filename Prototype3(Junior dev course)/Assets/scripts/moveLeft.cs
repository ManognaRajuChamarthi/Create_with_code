using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float movingSpeed;
    private PlayerScript PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * movingSpeed * Time.deltaTime);
        }
        if(transform.position.x <= -15f && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
        
}
