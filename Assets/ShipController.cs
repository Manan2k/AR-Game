using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.5f;
    public GameObject target; // Assign the target object in the inspector
    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        navMeshAgent.speed = speed;
    }

    private void Update()
    {
        if (target != null)
        {
            navMeshAgent.destination = target.transform.position;
        }
    }

    // Other methods for handling AR interactions, like setting a new destination when tapping on a plane, etc.
}
