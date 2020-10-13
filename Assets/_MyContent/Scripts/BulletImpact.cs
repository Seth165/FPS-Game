using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    public float damage = 10f;



    // checks if bullet has hit an object
    private void OnTriggerEnter(Collider other)
    {
        // if the bullet has hit an enemy
        if (other.gameObject.tag == "Enemy")
        {
            EnemyHealth eHealth = other.gameObject.GetComponent<EnemyHealth>();
            eHealth.health -= damage;
            Destroy(gameObject);
        }
        // if the bullet hits the player
        if (other.gameObject.tag == "Player")
        {
            
        }
        if (other.gameObject.tag == "Environment")
        {
            Destroy(gameObject);
        }
    }

}

    
