using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Rigidbody Bullet;
    public Transform BulletTransform;

    public float BulletForce = 10f;

    public float AttackDelay = 2f;

    private bool CanShoot;
    private float AttackTimer;

    private void Awake()
    {
        CanShoot = false;
        AttackTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanShoot == true)
        {
            AttackTimer -= Time.deltaTime;
            if (AttackTimer <= 0)
            {
                AttackTimer = AttackDelay;
                Fire();
            }
        }
    }

    private void Fire()
    {
        Rigidbody bulletInstance = Instantiate(Bullet, BulletTransform.position, BulletTransform.rotation) as Rigidbody;

        bulletInstance.velocity = BulletForce * BulletTransform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CanShoot = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CanShoot = false;
        }
    }
}
