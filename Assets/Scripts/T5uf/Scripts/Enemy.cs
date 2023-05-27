using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    public float distance;
    private GameObject target;
    public float speed = 10;
    private Vector3 moveDir;
    private CharacterController controller;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
        distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance > 30f)
        {
            animator.SetBool("Idle", true);
            agent.enabled = false;
            //controller.SimpleMove(Vector3.zero);
            
        }
        if (distance < 30f & distance > 4f)
        {
            animator.SetBool("Idle", false);
            
            agent.enabled = true;
            agent.SetDestination(target.transform.position);
            //moveDir = transform.forward * speed;
            //controller.SimpleMove(moveDir);
            animator.SetBool("Run", true);
        }
        if (distance < 4f)
        {
            animator.SetBool("Run", false);
            agent.transform.LookAt(target.transform.position);
            //controller.SimpleMove(Vector3.zero);
            animator.SetTrigger("Attack");
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                agent.enabled = false;
            }
        }
    }
}
