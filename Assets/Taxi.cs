using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taxi : MonoBehaviour
{

    // void MovingTaxi() {

    // }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 0, 0);
        transform.Rotate(0,180,0);
        transform.position = new Vector3(1, 0, 0);
         // Changes the position to x:1, y:1, z:0
           
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
    }
}
