using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InteligenciaArtificialEnemiga : MonoBehaviour
{
    public Transform target;

    NavMeshAgent agent;

    private void Start()
    {
        GameObject playerObject = GameObject.Find("Player");

        if (playerObject != null)
        {
           
            target = playerObject.transform;
        }
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
