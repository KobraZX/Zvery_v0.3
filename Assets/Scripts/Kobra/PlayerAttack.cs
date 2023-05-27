using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("������� ����")]
    public static int damage = 10;
    public int takoydamage;

    [Header("������� ������ ������������")]
    public static int stam = 5;
    public int takoystam;

    [Header("�������� �����")]
    public  static float SpeedAttack = 1f;
    public float takoySpeedAttack;

    [Header("������ �����")]
    public float attackRange = 0.5f;

    public Transform attackPoint;
    public LayerMask enemyLayers;
 
    void Start()
    {
        UpdateDamage();
        takoySpeedAttack = SpeedAttack;
    }
    void Update()
    {
        UpdateDamage();
        ProverkaDamage();
    }

    private void UpdateDamage()
    {
        takoydamage = damage;
        takoystam = stam;
    }
    private void ProverkaDamage()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (PlayerStamina.currentStamina >= stam)
            {
                PlayerStamina.currentStamina -= stam;

                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider enemy in hitEnemies)
                {
                    enemy.GetComponent<WizardHp>().TakeDamage(takoydamage);
                }
            }
            if (PlayerStamina.currentStamina < stam)
            {
                return;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawSphere(attackPoint.position, attackRange);
    }
}
