using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhearths : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public SpriteRenderer playerSr;
    public PlayerMovemnt playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount; 
        if(health <= 0)
        {
            playerSr.enabled = false;
            playerMovement.enabled = false;

        }

 

    }
}
