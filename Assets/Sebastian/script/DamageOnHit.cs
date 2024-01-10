 using UnityEngine;

[RequireComponent(typeof(stats))]
public class DamageOnHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        stats hitStats = collision.gameObject.GetComponent<stats>();
        stats ourstats = GetComponent<stats>();

        if (hitStats != null)
        {
            hitStats.health -= ourstats.attack - hitStats.defense;

            if (hitStats.health <= 0)
            {
                Destroy(hitStats.gameObject);
            }
        }

       }

    }

  
