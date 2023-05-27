using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [Header("����.��")]
    public static float MaxHealth = 100f; // ������������ �������� ��
    public int proverka_MaxHealth;
    [Header("������� ��")]
    public static float currentHealth; // ������� �������� ��
    public float proverka_currentHealth; // ��������
    [Header("����� ��")]
    public float RegenerationHealth = 0; // ������� ����������� �� � ���

    public Image healthBar;

    public GameObject Death;

    void Start()
    {
        Death.SetActive(false);
        healthBar.fillAmount = MaxHealth / 100;
        currentHealth = MaxHealth;
    }

    void Update()
    {
        if (MaxHealth <= 100f)
        {
            healthBar.fillAmount = currentHealth / MaxHealth;
        }
        else if (MaxHealth > 100f)
        {
            healthBar.fillAmount = currentHealth / (MaxHealth);
        }
            
        proverka_currentHealth = currentHealth;
        
    }

    private void OnTriggerEnter(Collider other) // ���� �� ��������� ����-��(���)
    {
        if (other.gameObject.tag == "Damage") // � ������ ���� ����������� ������ ����� 
        {
            currentHealth -= EnemyDamage.damage * Timer.rounds; // ���-�� �����

            if (currentHealth <= 0)
            {
                Death.SetActive(true);
                Time.timeScale = 0f;
                healthBar.fillAmount = 0.0f;
                Destroy(gameObject); // ����������� ������ - ������
            }
        }

    }
}
