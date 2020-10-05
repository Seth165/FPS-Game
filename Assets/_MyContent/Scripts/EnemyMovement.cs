using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float playerDistance = 3f;
    public float movementSpeed = 4f;

    [HideInInspector]
    public Transform playerTransform;
    [HideInInspector]
    NavMeshAgent agent;
    Rigidbody r;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = playerDistance;
        agent.speed = movementSpeed;
        r = GetComponent<Rigidbody>();
        r.useGravity = false;
        r.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards the player
        agent.destination = playerTransform.position;
        // Always look at the player
        transform.LookAt(new Vector3(playerTransform.transform.position.x, transform.position.y, playerTransform.position.z));
        // Reduce Rigidbody velocity when force is applied from bullet
        r.velocity *= 0.99f;
    }
}
