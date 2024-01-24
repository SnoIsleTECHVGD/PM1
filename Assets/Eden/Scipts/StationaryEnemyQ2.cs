
using System.Collections;
using UnityEngine;

public class StationaryEnemyQ2 : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public float bulletSpeed = 10;
    private Transform target;

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            target = otherCollider.transform;
            Fire();
        }
    }

    void OnTriggerExit(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            target = null;
            StopCoroutine("Fire"); 
        }
    }

    private IEnumerator Fire()
    {
        while (target != null)
        {
            float nextFire = Time.time + 1;
            while (Time.time < nextFire)
            {
                transform.LookAt(target);
                yield return new WaitForEndOfFrame();
            }

            Rigidbody bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.velocity = transform.forward * bulletSpeed;
        }
    }
}