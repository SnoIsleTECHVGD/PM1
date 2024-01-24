using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseControl : MonoBehaviour
{
    public FlyingEnemy[] enemyarray;
    public bool inrange;
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (FlyingEnemy enemy in enemyarray)
            {
                enemy.chase = true;
                inrange = true;
            }



        }
    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            foreach (FlyingEnemy enemy in enemyarray)
            {
                enemy.chase = false;
                inrange = false;
            }
        }


    }

//    private void Update()
//    {
//        if(inrange == false)
//        {
//            foreach (FlyingEnemy enemy in enemyarray)
//            {
//                enemy.chase = false;            }
//        }
//    }
}
