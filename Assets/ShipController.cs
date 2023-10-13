using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipController : MonoBehaviour
{
    public GameObject target;

    [SerializeField]
    private float speed = 3.5f; // This speed can be adjusted in the Inspector.
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = speed; // Set the speed when the script starts.
    }

    void Update()
    {
        if (target != null)
        {
            navMeshAgent.destination = target.transform.position;
        }
    }

    // Additional logic...
}
