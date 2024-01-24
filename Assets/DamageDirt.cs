using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDirt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider other)
    {
        if (other.gameObject.CompareTag("Dirt"))
        { 

        }
    }
}
