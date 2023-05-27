using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    [Header("Мана")]
    public static float MaxMana = 100f;
    public float proverka_MaxMana;
    public static float currentMana;
    public float proverka_currentMana;
    [Header("Регенерация Маны")]
    public float PlusMana = 5; // Сколько реген.маны в сек

    public Image manaBar;
   
    void Start()
    {
        currentMana = MaxMana;
        manaBar.fillAmount = MaxMana / MaxMana;

        proverka_MaxMana= MaxMana;
        proverka_currentMana = currentMana;
    }

    private void Update()
    {
        
        manaBar.fillAmount = currentMana / MaxMana;

        proverka_MaxMana = MaxMana;
        proverka_currentMana = currentMana;

        ProverkaMaxMana();
        ProverkaMinMana();
        StamPlus();

    }

    private void StamPlus() // Реген стамины
    {
        manaBar.fillAmount = currentMana / MaxMana;
        if (currentMana < MaxMana)
        {
            currentMana += PlusMana * Time.deltaTime; // Реген стамины в сек       
        }
    }

    private void ProverkaMaxMana() // Чтоб не привышало макс.значения маны
    {
        if (currentMana > MaxMana)
        {
            currentMana = MaxMana;
        }
    }

    private void ProverkaMinMana() // Чтоб мана не ухадила в минус
    {
        if (currentMana < 0)
        {
            currentMana = 0;
        }
    }
}
