using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float speed;
    public bool chase = false;
    public Transform startingPoint;
    public GameObject player;

    private void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            Debug.Log("Null");
           // return;
        if (chase == true)
            Chase();
        else
            ReturnStartPoint();
        Flip();
    }
    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, player.transform.position) <= 0.5f)
        {
            //change speed,shoot, aniamation
        }
        else
        {
            //reset variables
        }
    }
    private void ReturnStartPoint() 
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);
    }
    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else
            transform.rotation = Quaternion.Euler(0, 180, 0);
    }

} 