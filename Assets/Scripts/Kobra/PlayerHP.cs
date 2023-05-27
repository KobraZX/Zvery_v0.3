using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [Header("Макс.ХП")]
    public static float MaxHealth = 100f; // Максимальное значение ХП
    public int proverka_MaxHealth;
    [Header("Текущие ХП")]
    public static float currentHealth; // Текущие значение ХП
    public float proverka_currentHealth; // проверка
    [Header("Реген ХП")]
    public float RegenerationHealth = 0; // Сколько регенерации хп в сек

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

    private void OnTriggerEnter(Collider other) // Урон от вхождения куда-то(куб)
    {
        if (other.gameObject.tag == "Damage") // К какому тегу применяется данный метод 
        {
            currentHealth -= EnemyDamage.damage * Timer.rounds; // кол-во урона

            if (currentHealth <= 0)
            {
                Death.SetActive(true);
                Time.timeScale = 0f;
                healthBar.fillAmount = 0.0f;
                Destroy(gameObject); // уничтожение игрока - смерть
            }
        }

    }
}
