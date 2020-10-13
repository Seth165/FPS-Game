using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // this will stop the enemy from moving when it reaches this distance
    public float PlayerDistance = 3f;

    // reference to Player
    private GameObject m_Player;
    // A refence to the NavMeshAgent Component
    private NavMeshAgent m_NavAgent;
    // reference to the rigidbody component
    private Rigidbody m_Rigidbody;

    // this will be set to true once the tank is meant to follow
    private bool m_Follow;

    private void Awake()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player");
        m_NavAgent = GetComponent<NavMeshAgent>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Follow = false;
    }

    private void OnEnable()
    {
        // when the enemy is attacking, kinematic is set to false
        m_Rigidbody.isKinematic = false;
    }
    private void OnDisable()
    {
        // when the enemy is not attacking it goes back to being kinematic
        m_Rigidbody.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_Follow = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_Follow = false;
        }
    }

    private void Update()
    {
        if (m_Follow == false)
        {
            return;
        }

        float distance = (m_Player.transform.position - transform.position).magnitude;

        if (distance > PlayerDistance)
        {
            m_NavAgent.SetDestination(m_Player.transform.position);
            m_NavAgent.isStopped = false;
        }
        else
        {
            m_NavAgent.isStopped = true;
        }
    }
}
