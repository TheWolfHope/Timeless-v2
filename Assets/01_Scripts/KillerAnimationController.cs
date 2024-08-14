using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KillerAnimationController : MonoBehaviour
{
    public Transform Killer;
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        Vector2 direction = new Vector2(agent.velocity.x, agent.velocity.y).normalized;

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);

    }

}
