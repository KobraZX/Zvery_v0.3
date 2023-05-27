using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float currentHealth;
    private Animator anim;
    public float currentHealth2;
    public Image UIHP;
    private float t = 4f;

    void Start()
    {
        anim = GetComponent<Animator>();
        MaxHealth *= Timer.rounds;
        currentHealth = MaxHealth;
        currentHealth2 = currentHealth;
        if (UIHP != null) { UIHP.fillAmount = MaxHealth / (100f * Timer.rounds); }
    }

    void Update()
    {
        ProverkaHP();
        currentHealth2 = currentHealth;
        if (UIHP != null) { UIHP.fillAmount = currentHealth / (100f * Timer.rounds); }
    }
    
    private void ProverkaHP()
    {
        if (currentHealth <= 0)
        {
            if (t == 4f)
            {
                EnemyManager.EnemyDead();
                anim.SetTrigger("Dead");
            }
            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            t -= Time.deltaTime;
            if (t <= 0)
                Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword_Player")
        {
            currentHealth -= PlayerDamage.swordDamage;
        }
        if (other.gameObject.tag == "Arrow")
        {
            currentHealth -= PlayerDamage.arrowDamage;
        }
        if (other.gameObject.tag == "Spell")
        {
            currentHealth -= PlayerDamage.spellDamage;
        }
    }
}
