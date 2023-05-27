using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardHp : MonoBehaviour
{
    private int hp = 100;
    public Slider enemyHP;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        enemyHP.value = hp;
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            animator.SetTrigger("dead");
            GetComponent<Collider>().enabled = false;
            enemyHP.gameObject.SetActive(false);
        }
        else
            animator.SetTrigger("damage");
    }
}
