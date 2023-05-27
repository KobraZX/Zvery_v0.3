using UnityEngine;
using UnityEngine.UI;

public class PlayerStamina : MonoBehaviour
{
    [Header("Макс.Стамина персонажа")]
    public static float MaxStamina = 100;  // Максимальное значение выносливости
    public float proverka_MaxStamina;
    public static float currentStamina; // Текущие значение выносливости
    public float currentStamina2; // Текущие значение выносливости(чтоб видеть как меняется)
    [Header("Регенерация Стамины")]
    public float PlusStamina = 5; // Сколько реген.стамины в сек

    [Header("Мину.Стамина при прыжке")]
    public float MinusStamJump = 10; // Сколько тратит стамины на прыжок
    public static float MinusStamJump2; // Чтоб обращаться к значению MinusStamJump из других скриптов

    [Header("Мину.Стамина при шифте")]
    public float MinusStamShift = 1; // Сколько тратит стамины в сек
    public static float MinusStamShift2; // Чтоб обращаться к значению MinusStamShift из других скриптов

    public Image staminaBar;


    void Start()
    {
        currentStamina = MaxStamina;
        MinusStamJump2 = MinusStamJump;
        MinusStamShift2 = MinusStamShift;
        staminaBar.fillAmount = MaxStamina / MaxStamina;
    }

    private void Update()
    {
        proverka_MaxStamina = MaxStamina;
        currentStamina2 = currentStamina;
        staminaBar.fillAmount = currentStamina / MaxStamina;
        StamPlus();
        ProverkaMaxStam();
        ProverkaMinStam();
    }

    private void StamPlus() // Реген стамины
    {
        staminaBar.fillAmount = currentStamina / MaxStamina;
        if (currentStamina < MaxStamina)
        {
            currentStamina += PlusStamina * Time.deltaTime; // Реген стамины в сек       
        }
    }

    private void ProverkaMaxStam() // Чтоб не привышало макс.значения стамины
    {
        if (currentStamina > MaxStamina)
        {
            currentStamina = MaxStamina;
        }
    }

    private void ProverkaMinStam() // Чтоб стамина не ухадила в минус
    {
        if (currentStamina < 0)
        {           
            currentStamina = 0;
        }
    }
}