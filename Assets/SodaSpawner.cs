using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaSpawner : MonoBehaviour
{

    public GameObject sodaSpawn; 
    // Start is called before the first frame update
    void Start()
    {
        GameObject GameObjectToSpawn = Instantiate(sodaSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
