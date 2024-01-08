using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StationaryEnemyQ2 : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        transform.LookAt(Target, new Vector3(0, 1, 0));
    }
}
