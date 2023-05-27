using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; 
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distant = Vector3.Distance(transform.position, target.position);
        if (distant >= 10)
        {
            animator.SetBool("isRunning", false);
            agent.SetDestination(transform.position);
        }
        else if (distant < 10 && distant > 2)
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isAttacking", false);
            agent.SetDestination(target.position);
        }
        else if (distant <= 2)
        {
            agent.SetDestination(transform.position);
            animator.SetBool("isAttacking", true);
            transform.LookAt(target);
        }
    }
}
