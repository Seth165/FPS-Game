using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    public float damage = 10f;



    // checks if bullet has hit an object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyHealth eHealth = other.gameObject.GetComponent<EnemyHealth>();
            eHealth.health -= damage;
        }
        if (other.gameObject.tag == "Player")
        {
            // add player script
        }
        Destroy(gameObject);
    }

}

    
