using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardIdleBehaviour : StateMachineBehaviour
{
    Transform player;
    float runRange = 30;
    float attackRange = 20;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {
        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance < runRange && distance >  attackRange)
            animator.SetBool("move", true);
        if (distance < attackRange)
            animator.SetBool("idle_combat", true);
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
