using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //Variables
    public GameObject[] animals;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        int index = Random.Range(0, animals.Length - 1);
        Instantiate(animals[index], new Vector3(Random.Range(-15, 15), 0, 19), animals[index].transform.rotation);
       
    }
}
