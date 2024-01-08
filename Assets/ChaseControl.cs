using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseControl : MonoBehaviour
{
    public FlyingEnemy[] enemyarray;
   private void OnTriggerEnter2(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (FlyingEnemy enemy in enemyarray)
            {
                enemy.chase = true;
            }



        }
    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {

            foreach (FlyingEnemy enemy in enemyarray)
            {
                enemy.chase = false;
            }
        }


    }
}
