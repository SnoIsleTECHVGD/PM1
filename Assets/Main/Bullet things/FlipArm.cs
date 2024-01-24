using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipArm : MonoBehaviour
{
    public Sprite left, right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float adjustedAngle = transform.parent.rotation.eulerAngles.z + 90;
        if (adjustedAngle > 360)
            adjustedAngle -= 360;

        if (adjustedAngle > 180)
        {
            GetComponent<SpriteRenderer>().sprite = left;
        }

        else
        {
            GetComponent<SpriteRenderer>().sprite = right;
        }
    }
}
