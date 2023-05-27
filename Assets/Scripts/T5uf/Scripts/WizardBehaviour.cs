using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class WizardBehaviour : MonoBehaviour
{
    public GameObject spell;
    Transform SpawnTransform;
    Transform target;
    NavMeshAgent agent;
    Animator animator;
    float runRange = 30;
    float attackRange = 20;
    float attackTime = 0;
    float angle = 45 * Mathf.PI/180;
    float g = Physics.gravity.y;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        SpawnTransform = GameObject.FindGameObjectWithTag("SpellMaker").transform;
    }

    void Update()
    {
        SpawnTransform.localEulerAngles = new Vector3(-45f, 0f, 0f);
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < runRange && distance > attackRange)
        {
            animator.SetBool("move", true);
            animator.SetBool("idle_combat", false);
            agent.SetDestination(target.position);
        }
        else if (distance > runRange)
        {
            animator.SetBool("move", false);
            agent.SetDestination(transform.position);
        }
        else if (distance < attackRange)
        {
            agent.SetDestination(transform.position);
            transform.LookAt(target.position);
            animator.SetBool("idle_combat", true);
            attackTime -= Time.deltaTime;
            if (attackTime <= 0) 
            { 
                animator.Play("attack_short_001"); 
                Vector3 fromTo = target.position - transform.position;
                Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);
                float x = fromToXZ.magnitude;
                float y = fromTo.y;
                float v2 = (g * x * x) / (2 * ( y - Mathf.Tan(angle) * x) * Mathf.Pow(Mathf.Cos(angle), 2));
                float v = Mathf.Sqrt(Mathf.Abs(v2));
                GameObject newSpell = Instantiate(spell, SpawnTransform.position, Quaternion.identity);
                newSpell.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;
                attackTime = 3; 
            }

        }
    }
}