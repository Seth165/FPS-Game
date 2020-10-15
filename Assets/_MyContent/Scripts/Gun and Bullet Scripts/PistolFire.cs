using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    // Is the gun being controlled by the player?
    public bool playerControlled = true;

    // how quickly can the gun be fired?
    public float fireInterval = 1.0f;

    // timer telling us if the gun can be fired again.
    private float fireTimer = 0;

    // Refering to rocket prefab in order to spawn it.
    public GameObject bulletPrefab;

    // A position offset for where the rocket is spawned. 
    public Vector3 spawnOffset;

    // Start is called before the first frame update
    void Start()
    {
        // the gun is able to fire immidiately
        fireTimer = fireInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Advances the timer
        fireTimer += Time.deltaTime;

        // Has it been long enough to fire again?
        if (fireTimer >= fireInterval)
        {
            // If the gun is player controlled, has the fire button been pressed?
            if (playerControlled && Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }
    }

    public void Fire()
    {
        // Spawm a new rocket from our prefab.
        GameObject bulletInstance = GameObject.Instantiate<GameObject>(bulletPrefab);

        // This applies the spawn offset relative to the gun's position.
        bulletInstance.transform.position = transform.position + transform.right * spawnOffset.x + transform.up * spawnOffset.y + transform.forward * spawnOffset.z;

        // Rotate the bullet to match the gun
        bulletInstance.transform.rotation = this.transform.rotation;

        // Reset the shoot time
        fireTimer = 0f;
    }
}
